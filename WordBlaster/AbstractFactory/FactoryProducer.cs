using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordBlaster.AbstractFactory
{
    class FactoryProducer
    {
        public static FactoryIF getFactory(int level)
        {
            if (level.Equals(1))
            {
                return new LevelOneFactory();
            }
            else if(level.Equals(2))
            {
                return new LevelTwoFactory();
            }
            else if (level.Equals(3))
            {
                return new LevelThreeFactory();
            }
            else if (level.Equals(4))
            {
                return new LevelFourFactory();
            }
            else if (level.Equals(5))
            {
                return new LevelFiveFactory();
            }
            else
            {
                try
                {
                    var x = Activator.CreateInstance(null, "WordBlaster.AbstractFactory.DynamicLevel");
                    FactoryIF dynlvl = (FactoryIF)x.Unwrap();
                    return dynlvl;
                }
                catch(System.TypeLoadException e)
                {
                    Console.WriteLine("Could not load file, starting normally...");
                    return new LevelOneFactory(); //if we could not load it in just start normally
                }
            }
        }
    }
}
