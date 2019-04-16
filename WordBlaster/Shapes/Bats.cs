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
            Pen greenPen = new Pen(Color.Green, 1);
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Yellow);
            Image img;
            img = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\Images\\bat1.png");
            img.RotateFlip(RotateFlipType.RotateNoneFlipX);

            double y = x / 10;
            if (y % 2 == 0)
            {
                img = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\Images\\bat1.png");
                img.RotateFlip(RotateFlipType.RotateNoneFlipX);
                g.DrawImage(img, new Point(x, 0));
            } else
            {
                img = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + "\\Images\\bat3.png");
                img.RotateFlip(RotateFlipType.RotateNoneFlipX);
                g.DrawImage(img, new Point(x + 5, 25));
            }
            
            g.DrawString(word, font, myBrush, new PointF(x + 20, 32));

            // Draw a rectangle.

            //Dispose of the pen.
            greenPen.Dispose();
            g.Dispose();
        }
    }
}
