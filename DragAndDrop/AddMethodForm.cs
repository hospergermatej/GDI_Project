using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragAndDrop
{
    public partial class AddMethodForm : Form
    {
        private Box _box;
        public List<string> Arguments { get; set; }
        public event EventHandler MethodApplied;
        public AddMethodForm(Box box)
        {
            _box = box;
            InitializeComponent();
            Arguments = new List<string>();
            ArgumentsListBox1.DataSource = Arguments;
        }

        public void SetValues()
        {
            ArgumentsListBox1.Items.Clear();

            foreach (string strings  in Arguments)
            {
                ArgumentsListBox1.Items.Add(strings.ToString()!);

            }
        }


        private void ApplyButton_Click(object sender, EventArgs e)
        {
            SetValues();
            
            updateListBox();


            // Trigger the event
            MethodApplied?.Invoke(this, EventArgs.Empty);





            this.Close();
        }

        public void updateListBox()
        {



            _box.Methods.Add(new Method(0, NameTextBox.Text, DataTypeTextBox.Text, Arguments));

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void AddButton_Click(object sender, EventArgs e)
        {
            EditMethodForm editMethodForm = new EditMethodForm(Arguments);
            editMethodForm.ShowDialog();
        }

        private void ArgumentsListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
