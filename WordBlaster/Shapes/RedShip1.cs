using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordBlaster.Shapes
{
    public class RedShip1 : GameShapesIF
    {
        Font font = new Font("Arial", 10, FontStyle.Bold);
        public void DrawShape(Graphics g, int x, String word)
        {
            // Create a new pen.
            Pen greenPen = new Pen(Color.Green, 1);
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            Image img = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\Images\\level3Red.png");
            img.RotateFlip(RotateFlipType.Rotate270FlipNone);

            double y = x / 10;
            if (y % 2 == 0)
            {
                g.DrawImage(img, new Point(x, 0));
                g.DrawString(word, font, myBrush, new PointF(x + 10, 22));
            }
            else
            {
                g.DrawImage(img, new Point(x, 10));
                g.DrawString(word, font, myBrush, new PointF(x + 10, 32));
            }

            // Draw a rectangle.

            //Dispose of the pen.
            greenPen.Dispose();
            g.Dispose();
        }
    }
}
