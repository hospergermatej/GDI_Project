using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragAndDrop
{
    public class Line
    {
        public Box Start { get; set; }
        public Box End { get; set; }

        public void SearchPoints(Box start, Box end)
        {
            Point StartPoint = new Point(start.PositionX, start.PositionY);
            Point EndPoint = new Point(end.PositionX, end.PositionY);

            StartP = StartPoint;
            EndP = EndPoint;
        }


        private Point StartP { get; set;}
        private Point EndP { get; set; }

        public Line(Box start, Box end) 
        {
            start = Start;
            end = End;
           SearchPoints(start, end);
        }



        public void Draw(Graphics g)
        {
            g.DrawLine(Pens.Black, StartP, EndP);
        }
        
    }
}
