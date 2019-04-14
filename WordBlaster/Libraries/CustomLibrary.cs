using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordBlaster.Libraries;

namespace WordBlaster.Libraries
{
    public class CustomLibrary : LibrariesIF
    {
        String[] common = new string[100];
        public string generateWord()
        {
                Random random = new Random(Guid.NewGuid().GetHashCode());
                int i = random.Next(0, common.Length - 1);
                return common[i];
        }
        public CustomLibrary(String[] common)
        {
            this.common = common;
        }
    }
}
