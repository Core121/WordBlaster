using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordBlaster.Shapes
{
    class Meteoroid : GameShapesIF
    {
        Font font = new Font("Arial", 10, FontStyle.Bold);
        public void DrawShape(Graphics g, int x, String word)
        {
            // Create a new pen.
            Pen greenPen = new Pen(Color.Green, 1);
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            Image img = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\Images\\Asteroid.png");

            double y = x / 10;
            if(y % 4 == 0)
            {
                img.RotateFlip(RotateFlipType.Rotate270FlipNone);
            } else if (y % 3 == 0)
            {
                img.RotateFlip(RotateFlipType.Rotate180FlipNone);
            } else if (y % 2 == 0 )
            {
                img.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }
            g.DrawImage(img, new Point(x, 0));
            g.DrawString(word, font, myBrush, new PointF(x+20, 32));
            // Draw a rectangle.

            //Dispose of the pen.
            greenPen.Dispose();
            g.Dispose();
        }
    }
}
