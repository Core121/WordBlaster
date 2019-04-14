using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordBlaster.Shapes;

namespace WordBlaster.Libraries
{
    public class LevelThreeLibrary : LibrariesIF
    {
        String[] common = {"shrink","gossip","battle","broken","carrot","insist","secure","thrust","period","spread","occupy","depend","create","driver","strong","safety","linger","ballet","master","canvas","impact","likely","return","shadow","weapon","basket","ribbon","number","sister","follow","leader","mature","relief","memory","singer","manner","ignore","island","resort","offset","mother","pledge","defend","flower","danger","method","refund","animal","volume","stress","scrape","cheese","finger","frozen","annual","extend","border","wonder","profit","chance","school","pastel","foster","camera","kidnap","shorts","format","twitch","topple","throne","admire","borrow","forbid","rescue","matrix","output","horror","praise","clinic","trance","report","forest","prefer","fossil","poetry","tumble","embark","sailor","member","burial","unique","second","system","bottom","friend","facade","sermon","mosque","stream","answer"};
        public string generateWord()
        {
                Random random = new Random(Guid.NewGuid().GetHashCode());
                int i = random.Next(0, common.Length - 1);
                return common[i];
        }
    }
}
