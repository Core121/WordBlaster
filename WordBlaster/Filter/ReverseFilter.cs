using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordBlaster.Filter
{
    class ReverseFilter : FilterIF
    {
        public string Filter(string data)
        {
            char[] charArray = data.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
