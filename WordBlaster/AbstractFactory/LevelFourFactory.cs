using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordBlaster.Libraries;
using WordBlaster.Shapes;

namespace WordBlaster.AbstractFactory
{
    class LevelFourFactory : FactoryIF
    {
        public LibrariesIF createLibrary()
        {
            var x = Activator.CreateInstance(null, "WordBlaster.Libraries.LevelFourLibrary");
            LibrariesIF library = (LibrariesIF)x.Unwrap();
            return library;
        }

        public GameShapesIF createShape()
        {
            var x = Activator.CreateInstance(null, "WordBlaster.Shapes.BlueShip2");
            GameShapesIF shape = (GameShapesIF)x.Unwrap();
            return shape;
        }
        public int getLevel()
        {
            return 4;
        }

        public int getDelay()
        {
            return 5;
        }
    }
}
