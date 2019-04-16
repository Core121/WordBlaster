using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordBlaster.Libraries;
using WordBlaster.Shapes;

namespace WordBlaster.AbstractFactory
{
    class LevelTwoFactory : FactoryIF
    {
        public LibrariesIF createLibrary()
        {
            var x = Activator.CreateInstance(null, "WordBlaster.Libraries.LevelTwoLibrary");
            LibrariesIF library = (LibrariesIF)x.Unwrap();
            return library;
        }

        public GameShapesIF createShape()
        {
            var x = Activator.CreateInstance(null, "WordBlaster.Shapes.BlueShip1");
            GameShapesIF shape = (GameShapesIF)x.Unwrap();
            return shape;
        }
        public int getLevel()
        {
            return 2;
        }

        public int getDelay()
        {
            return 20;
        }
    }
}
