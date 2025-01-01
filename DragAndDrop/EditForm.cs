using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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
            InitializeComponent(); // Ensure controls are initialized
            SetValues();
        }


        private void ApplyButton_Click(object sender, EventArgs e)
        {


            SetValues();

            this.Close();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddAttrButton_Click(object sender, EventArgs e)
        {
            AddAttributeForm addAttributeForm = new AddAttributeForm(_box);
            addAttributeForm.AttributeApplied += AddAttributeForm_AttributeApplied;
            addAttributeForm.ShowDialog();




        }


        private void AddAttributeForm_AttributeApplied(object sender, EventArgs e)
        {

            SetValues();
        }


        private void AbstractCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _box.IsAbstract = AbstractCheckBox.Checked;

        }

        private void AttributesListBox1_MouseClick(object sender, MouseEventArgs e)
        {


        }

        private void SetValues()
        {
            AttributesListBox1.Items.Clear();

            foreach (ClassAttribute atribute in _box.Attributes)
            {
                AttributesListBox1.Items.Add(atribute.ToString()!);

            }


            MethodsListBox1.Items.Clear();

            foreach (Method methods in _box.Methods)
            {
                MethodsListBox1.Items.Add(methods.ToString()!);

            }

        }

        private void RemAttrButton_Click(object sender, EventArgs e)
        {
            _box.Attributes.RemoveAt(AttributesListBox1.SelectedIndex);
            SetValues();

        }

        private void AddMetButton_Click(object sender, EventArgs e)
        {
            AddMethodForm addMethodForm = new AddMethodForm(_box);
            addMethodForm.MethodApplied += AddAttributeForm_AttributeApplied;
            addMethodForm.ShowDialog();
        }

        private void RemMetButton_Click(object sender, EventArgs e)
        {
            _box.Methods.RemoveAt(MethodsListBox1.SelectedIndex);
            SetValues();
        }

        private void ClassNameTextBox_TextChanged(object sender, EventArgs e)
        {
           _box.Class = ClassNameTextBox.Text;
        }
    }
}
