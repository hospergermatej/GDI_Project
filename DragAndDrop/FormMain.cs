using System.Windows.Forms;

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

            if (_canvas.IsInCollisisonWithRedButton(e.X, e.Y) != null)
            {
                _canvas.RemoveBox(_canvas.IsInCollisisonWithRedButton(e.X, e.Y)!);
                pictureBox.Refresh();
            }

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



            if (_canvas.IsInCollisionWithBox(e.X, e.Y) != null)
            {
                EditForm editForm = new EditForm(_canvas.IsInCollisionWithBox(e.X, e.Y)!);
                editForm.ShowDialog();

            }


            if (_canvas.IsInCollisionWithBlackEllipse(e.X, e.Y) != null)
            {
                Box start = new Box(pictureBox.Location.X + pictureBox.Width / 2, pictureBox.Location.Y + pictureBox.Height / 2);
                Box end = new Box(pictureBox.Location.X + pictureBox.Width / 2, pictureBox.Location.Y + pictureBox.Height / 2);



                _canvas.AddLine(start, end);


            }

        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Exportbutton1_Click(object sender, EventArgs e)
        {
            using (Bitmap bitmap = new Bitmap(pictureBox.Width, pictureBox.Height))
            {
                pictureBox.DrawToBitmap(bitmap, new Rectangle(0, 0, pictureBox.Width, pictureBox.Height));

                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "PNG Files (.png)|.png",
                    DefaultExt = "png"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        bitmap.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                        MessageBox.Show("PNG exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error saving image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void SaveButton1_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
               
                List<Box> boxes = _canvas._boxes;
                saveFileDialog.Filter = "JSON files (.json)|.json|All files (.)|.";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    LoadSaveDiagram.Save(boxes, saveFileDialog.FileName);
                }
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JSON files (.json)|.json|All files (.)|.";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    List<Box> Boxes = LoadSaveDiagram.Load(filePath);
                    _canvas._boxes = Boxes;
                    pictureBox.Refresh();
                }
            }
        }


    }
}
