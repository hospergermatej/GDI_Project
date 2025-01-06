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
    public partial class EditMethodForm : Form
    {
        private List<string> Arguments { get; set; }
        private Box _box;
        public EditMethodForm(List<string> arguments)
        {

            InitializeComponent();
            Arguments=arguments;
        }

       

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            Arguments.Add(NametextBox1.Text);
            
            this.Close();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
