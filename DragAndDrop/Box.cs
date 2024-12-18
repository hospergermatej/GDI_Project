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
        

        public Box(int x, int y)
        {
            PositionX = x;
            PositionY = y;
            Width = 100;
            Height = 120;
            _color = Brushes.LightGray;
            

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
            //pocitani textu na stred
            SizeF textSize = g.MeasureString(Classes[0], new Font("Arial", 10));
            float textX = (Width - textSize.Width) / 2;
            float textY = 10;
            float totalHeight = textY + textSize.Height + 10;


            g.TranslateTransform(PositionX, PositionY);
            g.FillRectangle(_color, 0, 0, Width, Height);
            g.FillEllipse(Brushes.Red, 1, textY -10, 10, 10);
            g.DrawLine(Pens.Black, 0, 30, Width, 30);
            g.DrawString("X",new Font("Arial",6),Brushes.Black,3,1);
            g.DrawRectangle(Pens.GhostWhite, 0, 0, Width, Height);
            
            

            g.FillRectangle(Brushes.Black, Width - 10, Height - 10, 10, 10);
            g.DrawString(Classes[0], new Font("Arial", 10), Brushes.Black, textX, textY);
            g.DrawString(Attributes[0], new Font("Arial", 10), Brushes.Black, 10, 40);
            g.DrawString(Methods[0], new Font("Arial", 10), Brushes.Black, 10, 70);


            
            

           
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


        //public bool IsInCollisisonWithRedButton(int x, int y)
        //{
        //    return x > (PositionX + 13) && x <= PositionX + 13
        //        && y > (PositionY + 13) && y <= PositionY + 13;
        //}

        public bool IsInCollisisonWithRedButton(int x, int y)
        {
            int circleX = PositionX;
            int circleY = PositionY;
            int circleRadius = 13;

            int distanceSquared = (x - circleX) * (x - circleX) + (y - circleY) * (y - circleY);
            int radiusSquared = circleRadius * circleRadius;

            return distanceSquared <= radiusSquared;
        }

    }
}
