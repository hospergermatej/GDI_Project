using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace DragAndDrop
{
    public class Line
    {
        public Box Start { get; set; }
        public Box End { get; set; }

        public Point StartP => new Point(Start.PositionX + Start.Width / 2, Start.PositionY + Start.Height / 2);
        public Point EndP => new Point(End.PositionX + End.Width / 2, End.PositionY + End.Height / 2);

       

        public Line(Box start, Box end)
        {
            Start = start;
            End = end;
        }

        public void Draw(Graphics g)
        {
            g.DrawLine(Pens.Black, StartP, EndP);
        }

    }
}
