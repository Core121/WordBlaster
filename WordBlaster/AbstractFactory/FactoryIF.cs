using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordBlaster.Libraries;
using WordBlaster.Shapes;

namespace WordBlaster.AbstractFactory
{
    interface FactoryIF
    {
        GameShapesIF createShape();
        LibrariesIF createLibrary();
        int getLevel();
        int getDelay();
    }
}
