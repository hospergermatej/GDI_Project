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
        private Canvas _canvas;

        public EditForm(Box box)
        {
            _box = box;

            IsInCollisionWithBox(_box.Width, _box.Height);

            InitializeComponent();
        }

      
        public void IsInCollisionWithBox(int x, int y)
        {
            EditForm editForm = new EditForm(_canvas.IsInCollisionWithBox(x, y)!);
        }

    }
}
