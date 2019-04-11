using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordBlaster.Shapes
{
    class Circle : GameShapesIF
    {
        Font font = new Font("Arial", 10, FontStyle.Bold);
        public void DrawShape(Graphics g, int x, String word)
        {
            // Create a new pen.
            Pen greenPen = new Pen(Color.Green, 1);
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            g.DrawEllipse(greenPen, new Rectangle(x, 0, 75, 75));
            g.DrawString(word, font, myBrush, new PointF(x+20, 32));
            // Draw a rectangle.

            //Dispose of the pen.
            greenPen.Dispose();
            g.Dispose();
        }
    }
}
