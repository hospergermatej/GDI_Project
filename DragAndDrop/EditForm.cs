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
    public partial class EditForm : Form
    {
        private Box _box;

        public EditForm(Box box)
        {

            _box = box;



            InitializeComponent();
        }

        public void UpdateBox()
        {
            _box.Methods.Clear();

            _box.Attributes.Add(AttributeTextBox.Text);
            _box.Methods.Add(MethodTextBox.Text);
            _box.Classes.Add(ClassNameTextBox.Text);

        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            UpdateBox();
            
            this.Close();
        }
    }
}
