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

        
        private Point StartP => new Point(Start.PositionX + Start.Width / 2, Start.PositionY + Start.Height / 2);
        private Point EndP => new Point(End.PositionX + End.Width / 2, End.PositionY + End.Height / 2);

        public Line(Box start, Box end) 
        {
            start = Start;
            end = End;
        }



        public void Draw(Graphics g)
        {
            g.DrawLine(Pens.Black, StartP, EndP);
        }
        
    }
}
