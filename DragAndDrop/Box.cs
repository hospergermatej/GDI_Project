using System.Runtime.InteropServices;

namespace DragAndDrop
{
    public class Box
    {
        public int PositionX { get; private set; }
        public int PositionY { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }
        public List<string> Attributes { get; set; }
        public List<string> Methods { get; set; }
        
        public List<string> Classes { get; set; }

        
        

        public int MinWidth = 100;
        public int MinHeight = 80;
        public int MaxWidth = 220;
        public int MaxHeight = 220;

        

        private Brush _color;
        private string _text;

        public Box(int x, int y)
        {
            PositionX = x;
            PositionY = y;
            Width = 150;
            Height = 180;
            _color = Brushes.LightGray;
            _text = $"{Classes}";

            Classes = new List<string>() { "Class" };
            Attributes = new List<string>() { "Attribute" };
            Methods = new List<string>() { "Methods" };

        }

        public void Select()
        {
            
            
        }

        public void Unselect()
        {
            _color = Brushes.LightGray;
            
        }

        public void Move(int x, int y)
        {
            PositionX = x;
            PositionY = y;
        }

        public void Resize(int w, int h)
        {
            if (w < MinWidth)
                w = MinWidth;

            if (h < MinHeight)
                h = MinHeight;

            if (w > MaxWidth)
                w = MaxWidth;

            if (h > MaxHeight)
                h = MaxHeight;

            Width = w;
            Height = h;
        }

        public void Draw(Graphics g)
        {
            g.TranslateTransform(PositionX, PositionY);
            g.FillRectangle(_color, 0, 0, Width, Height);

            g.FillRectangle(Brushes.Black, Width - 10, Height - 10, 10, 10);
            g.DrawString(Attributes[0], new Font("Arial", 10), Brushes.Black, 10, 30);
            g.DrawString(Methods[0], new Font("Arial", 10), Brushes.Black, 10, 50);


            //pocitani textu na stred
            SizeF textSize = g.MeasureString(_text, new Font("Arial", 10));
            float textX = (Width - textSize.Width) / 2;
            float textY = 10;
            float totalHeight = textY + textSize.Height + 10;

            g.DrawString(_text, new Font("Arial", 10), Brushes.Black, textX, textY);
            g.ResetTransform();
        }

        public bool IsInCollision(int x, int y)
        {
            return x > PositionX && x <= PositionX + Width
                && y > PositionY && y <= PositionY + Height;


        }

        

        public bool IsInCollisionWithCorner(int x, int y)
        {
            return x > (PositionX + Width - 10) && x <= PositionX + Width
                && y > (PositionY + Height - 10) && y <= PositionY + Height;
        }
    }
}
