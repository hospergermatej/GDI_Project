using System.Diagnostics.Eventing.Reader;
using System.Drawing;

namespace DragAndDrop
{
    public class Canvas
    {
        private List<Box> _boxes;
        private Selection? _selection;

        public Canvas()
        {
            _boxes = new List<Box>();
            _selection = null;

        }

        public void Draw(Graphics g)
        {
            foreach (Box box in _boxes)
                box.Draw(g);
        }

        public void Select(int x, int y)
        {
            Unselect();
            for (int i = 0; i < _boxes.Count; i++)
            {
                Box box = _boxes[i];
                if (box.IsInCollisionWithCorner(x, y))
                {
                    //MessageBox.Show("Corner selected!");

                    _selection = new ResizeSelection(box, x, y);
                    _selection.Select();
                    return;
                }
                else if (box.IsInCollision(x, y))
                {
                    _selection = new MoveSelection(box, x, y);
                    _selection.Select();
                    return;
                }
            }
        }
        public void Unselect()
        {
            if (_selection == null)
                return;

            _selection.Unselect();
            _selection = null;
        }

        public void Move(int x, int y)
        {
            if (_selection == null)
                return;

            _selection.Move(x, y);
        }

        public void AddBox(int x, int y)
        {
            Box box = new Box(x, y);
            _boxes.Add(box);
        }

        public Box? IsInCollisionWithBox(int x, int y)
        {
            for(int i = 0; i < _boxes.Count; i++)
            {
                Box box = _boxes[i];
                if (box.IsInCollision(x, y))
                    return box;
            }
            return null; 


        }

        public void RemoveBox(Box box)
        {
            if (box != null)
            {
                _boxes.Remove(box);
            }
        }

        public Box? IsInCollisisonWithRedButton(int x, int y)
        {
            for (int i = 0; i < _boxes.Count; i++)
            {
                Box box = _boxes[i];
                if (box.IsInCollisisonWithRedButton(x, y))
                    return box;
            }
            return null;
        }


        public Box? IsInCollisionWithBlackEllipse(int x, int y)
        {
            for (int i = 0; i < _boxes.Count; i++)
            {
                Box box = _boxes[i];
                if (box.IsInCollisionWithBlackEllipse(x, y))
                    return box;
            }
            return null;
        }

        public void DrawLine(Graphics g, MouseEventArgs e)
        {
            foreach (Box box in _boxes)
                box.DrawLine(g,e);
        }
        

    }
}
