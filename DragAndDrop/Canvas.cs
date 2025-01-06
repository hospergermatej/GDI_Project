using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace DragAndDrop
{
    public class Canvas
    {
        public List<Box> _boxes;
        private Selection? _selection;
        private List<Line> _lines;
        private Box? _firstClickedBox;



        public Canvas()
        {
            _boxes = new List<Box>();
            _selection = null;
            _lines = new List<Line>();
            _firstClickedBox = null;
        }

        public void Draw(Graphics g)
        {
            foreach (Line line in _lines)
                line.Draw(g);

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
            for (int i = 0; i < _boxes.Count; i++)
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

        public void AddLine(Box box)
        {


            if (_firstClickedBox != null && _firstClickedBox != null)
            {
                Line line = new Line(_firstClickedBox, box);
                _lines.Add(line);
                _firstClickedBox = null;
            }
            _firstClickedBox = box;

        }

    }
        

    
}
