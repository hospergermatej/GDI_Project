﻿using System.Runtime.InteropServices;

namespace DragAndDrop
{
    public class Box
    {
        public int PositionX { get; private set; }
        public int PositionY { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }
        public List<ClassAttributes> Attributes { get; set; }
        public List<Methods> Methods { get; set; }
        
        public List<string> Classes { get; set; }

        public bool IsAbstract { get; set; }
        

        public int MinWidth = 100;
        public int MinHeight = 100;
        public int MaxWidth = 220;
        public int MaxHeight = 220;

        

        private Brush _color;
        

        public Box(int x, int y)
        {
            PositionX = x;
            PositionY = y;
            Width = 200;
            Height = 150;
            _color = Brushes.GhostWhite;
            IsAbstract = false;
            


            Classes = new List<string>() { "Class" };
            Attributes = new List<ClassAttributes>() { new ClassAttributes(0, "pes", "string") };
            Methods = new List<Methods>() { new Methods(0, "pes", "string",new List<string>()) };

        }

        public void Select()
        {
            
            _color = Brushes.WhiteSmoke;
        }

        public void Unselect()
        {
            _color = Brushes.GhostWhite;
            
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
            g.FillEllipse(Brushes.Black, Width, Height / 2, 10, 10); // na cary
            g.FillEllipse(Brushes.Black, -10, Height / 2, 10, 10); // na cary
            g.FillEllipse(Brushes.Red, 1, textY -10, 10, 10);
            g.DrawLine(Pens.Black, 0, 30, Width, 30);
            g.DrawString("X",new Font("Arial",6),Brushes.Black,3,1);
            g.DrawRectangle(Pens.Black, 0, 0, Width, Height);
            

            g.FillRectangle(Brushes.Black, Width - 10, Height - 10, 10, 10);

            if(IsAbstract)
            {
                g.DrawString(Classes[0], new Font("Arial",10, FontStyle.Italic), Brushes.Black, textX, textY);
            }
            else
            {
                g.DrawString(Classes[0], new Font("Arial", 10), Brushes.Black, textX, textY);
            }


            foreach (ClassAttributes attribute in Attributes)
            {
                float relativeY = textY + 20;
                g.DrawString(attribute.ToString(), new Font("Arial", 10), Brushes.Black, 10, relativeY);
                relativeY += 10;

                g.DrawLine(Pens.Black, 0, relativeY+10, Width, relativeY+10);
            }
           

            foreach (Methods method in Methods)
            {
                float relativeY = textY + 50;
                g.DrawString(method.ToString(), new Font("Arial", 10), Brushes.Black, 10, relativeY);
                relativeY += 10;
            }

            

            g.ResetTransform();
        }

        public void DrawLine(Graphics g, MouseEventArgs e)
        {
            g.DrawLine(Pens.Black,Width + 7,Height / 2,e.X,e.Y);
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

        public bool IsInCollisisonWithRedButton(int x, int y)
        {
            int circleX = PositionX;
            int circleY = PositionY;
            int circleRadius = 13;

            int distanceSquared = (x - circleX) * (x - circleX) + (y - circleY) * (y - circleY);
            int radiusSquared = circleRadius * circleRadius;

            return distanceSquared <= radiusSquared;
        }

        public bool IsInCollisionWithBlackEllipse(int x, int y)
        {
            int circleX = PositionX + Width + 10;
            int circleY = PositionY + Height / 2;
            int circleRadius = 5;

            int distanceSquared = (x - circleX) * (x - circleX) + (y - circleY) * (y - circleY);
            int radiusSquared = circleRadius * circleRadius;

            return distanceSquared <= radiusSquared;
        }


    }
}
