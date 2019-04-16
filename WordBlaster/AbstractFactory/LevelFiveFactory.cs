using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordBlaster.Libraries;
using WordBlaster.Shapes;

namespace WordBlaster.AbstractFactory
{
    class LevelFiveFactory : FactoryIF
    {
        public LibrariesIF createLibrary()
        {
            var x = Activator.CreateInstance(null, "WordBlaster.Libraries.LevelFiveLibrary");
            LibrariesIF library = (LibrariesIF)x.Unwrap();
            return library;
        }

        public GameShapesIF createShape()
        {
            var x = Activator.CreateInstance(null, "WordBlaster.Shapes.RedShip2");
            GameShapesIF shape = (GameShapesIF)x.Unwrap();
            return shape;
        }
        public int getLevel()
        {
            return 5;
        }

        public int getDelay()
        {
            return 1;
        }
    }
}
