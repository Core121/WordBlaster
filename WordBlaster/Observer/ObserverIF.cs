using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordBlaster.Observer
{
    public interface ObserverIF
    {
        void notify(WordBlasterForm form);
    }
}
