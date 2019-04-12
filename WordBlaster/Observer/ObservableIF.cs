using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordBlaster.Observer
{
    public interface ObservableIF
    {
        void addObserver(ObserverIF observer);
        void removeObserver(ObserverIF observer);
    }
}
