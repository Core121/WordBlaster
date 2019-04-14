using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordBlaster.Libraries
{
    public class LevelFourLibrary : LibrariesIF
    {
        String[] common = { "underline", "architect", "machinery", "professor", "aluminium", "wisecrack", "butterfly", "bloodshed", "suffering", "fascinate", "leftovers", "cultivate", "deviation", "paralyzed", "favorable", "transform", "formulate", "pollution", "captivate", "communist", "copyright", "blue jean", "telephone", "prejudice", "dangerous", "intention", "plaintiff", "violation", "relevance", "publicity", "guarantee", "emergency", "publisher", "disappear", "cathedral", "condition", "treasurer", "committee", "influence", "hostility", "magnitude", "willpower", "privilege", "sanctuary", "fisherman", "nightmare", "incapable", "ice cream", "recommend", "pneumonia", "statement", "temporary", "authority", "variation", "inflation", "consensus", "favourite", "horseshoe", "earthflax", "construct", "incentive", "rebellion", "strategic", "monstrous", "principle", "candidate", "introduce", "attention", "sensitive", "operation", "hierarchy", "chocolate", "liability", "automatic", "available", "encourage", "foreigner", "selection", "gas pedal", "interface", "injection", "essential", "secretion", "speculate", "evolution", "modernize", "satellite", "miserable", "defendant", "community", "offspring", "discovery", "hilarious", "reduction", "craftsman", "formation", "conductor", "eavesdrop", "difficult", "quotation" };
        public string generateWord()
        {
                Random random = new Random(Guid.NewGuid().GetHashCode());
                int i = random.Next(0, common.Length - 1);
                return common[i];
        }
    }
}
