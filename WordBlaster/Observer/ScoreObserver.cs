using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordBlaster.AbstractFactory;

namespace WordBlaster.Observer
{
    class ScoreObserver : ObserverIF
    {
        public void notify(WordBlasterForm form)
        {
            int level = form.getLevel();
            switch (level)
            {
                case 1:
                    form.stopAllTasks();
                    form.NewLevel(2);
                    break;
                case 2:
                    form.stopAllTasks();
                    form.NewLevel(3);
                    break;
                case 3:
                    form.stopAllTasks();
                    form.NewLevel(4);
                    break;
                case 4:
                    form.stopAllTasks();
                    form.NewLevel(5);
                    break;
            }
        }
    }
}
