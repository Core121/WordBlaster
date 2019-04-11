using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordBlaster.Shapes
{
    class Diamond : GameShapesIF
    {
        public void DrawShape(Graphics g, int x, String word)
        {
            // Create a new pen.
            Pen pen = new Pen(Color.Beige, 1);
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            g.DrawEllipse(pen, new Rectangle(x, 0, 75, 75));
            g.DrawString(word, new Font("Arial", 10, FontStyle.Bold), myBrush, new PointF(x + 20, 32));
            // Draw a rectangle.

            //Dispose of the pen.
            pen.Dispose();
            g.Dispose();
        }
    }
}
