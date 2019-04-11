using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordBlaster.Shapes
{
    class Bats : GameShapesIF
    {
        Font font = new Font("Arial", 10, FontStyle.Bold);
        public void DrawShape(Graphics g, int x, String word)
        {
            // Create a new pen.
            Pen pen = new Pen(Color.IndianRed, 1);
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            g.DrawEllipse(pen, new Rectangle(x, 0, 75, 75));
            g.DrawString(word, font, myBrush, new PointF(x + 20, 32));
            // Draw a rectangle.

            //Dispose of the pen.
            pen.Dispose();
            g.Dispose();
        }
    }
}
