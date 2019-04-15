using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordBlaster.Filter
{
    public class RandomFilter : FilterIF
    {
        public string Filter(string data)
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            int i = random.Next(0, data.Length - 1);
            String letter = data.ElementAt(i).ToString();
            data = data.Replace(letter, "_"); //replace random letter
            return data;
        }
    }
}
