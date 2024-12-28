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
        public event EventHandler MethodApplied;
        public AddMethodForm(Box box)
        {
            _box = box;

            InitializeComponent();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            updateListBox();

            // Trigger the event
            MethodApplied?.Invoke(this, EventArgs.Empty);

            this.Close();
        }

        public void updateListBox()
        {

            _box.Methods.Add(new Methods(Name));



        }
    }
}
