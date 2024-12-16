namespace DragAndDrop
{
    public partial class FormMain : Form
    {
        private Canvas _canvas;
        

        public FormMain()
        {
            _canvas = new Canvas();

            InitializeComponent();
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            _canvas.Unselect();
            pictureBox.Refresh();
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            _canvas.Select(e.X, e.Y);
            pictureBox.Refresh();
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            _canvas.Move(e.X, e.Y);
            pictureBox.Refresh();
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            _canvas.Draw(e.Graphics);
        }

        private void AddClassButton_Click(object sender, EventArgs e)
        {
            _canvas.AddBox(100, 100);
            pictureBox.Refresh();
        }

        private void pictureBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(_canvas.IsInCollisionWithBox(e.X, e.Y)!= null)
            {
                EditForm editForm = new EditForm(_canvas.IsInCollisionWithBox(e.X, e.Y)!);

                //do konstruktoru editformu dat jako vstup vystup funkce isincollisionwithbox
               
            }
        }
    }
}
