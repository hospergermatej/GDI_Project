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
    public partial class AddAttributeForm : Form
    {
        private Box _box;
        public event EventHandler AttributeApplied;

        public AddAttributeForm(Box box)
        {

            _box = box;
            InitializeComponent();

        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            updateListBox();

            // Trigger the event
            AttributeApplied?.Invoke(this, EventArgs.Empty);

            this.Close();
        }

        public void updateListBox()
        {

            //_box.Attributes.Add(new ClassAttribute(0, NametextBox1.Text, DataTypetextBox1.Text));



        }

        private void ExitButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
