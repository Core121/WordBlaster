using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordBlaster.Shapes
{
    interface GameShapesIF
    {
        void DrawShape(Graphics g, int x, String word);

    }
}
