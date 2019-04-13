using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordBlaster.Libraries
{
    class LevelFiveLibrary : LibrariesIF
    {
        String[] common = {"landowner","conductor","rebellion","agreement","interface","execution","liability","extension","economist","candidate","inspector","butterfly","eavesdrop","explosion","nightmare","inflation","fabricate","beginning","formulate","foreigner","violation","reconcile","classroom","deviation","communist","expansion","chemistry","sensitive","adventure","magnitude","injection","vegetable","therapist","detective","radiation","highlight","privilege","authorise","depressed","miserable","fireplace","neighbour","incentive","cooperate","volunteer","encourage","copyright","guerrilla","reference","broadcast","secretion","ignorance","staircase","practical","represent","policeman","evolution","bloodshed","disappear","influence","character","attention","reproduce","exception","leftovers","craftsman","telephone","formation","financial","reduction","executrix","advertise","insurance","secretary","recording","photocopy","satellite","lifestyle","modernize","direction","defendant","favorable","essential","favourite","recession","frequency","courtship","guideline","temporary","unanimous","cigarette","satisfied","hierarchy","departure","tradition","selection","penetrate","machinery","marketing","mechanism"}; public string generateWord()
        {
                Random random = new Random(Guid.NewGuid().GetHashCode());
                int i = random.Next(0, common.Length - 1);
                return common[i];
        }
    }
}
