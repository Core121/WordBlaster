using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordBlaster.Libraries
{
    class LevelTwoLibrary : LibrariesIF
    {
        String[] common = { "trunk", "voter", "solid", "money", "stuff", "cheap", "spoil", "court", "fever", "harsh", "chief", "tired", "trace", "seize", "utter", "snarl", "trick", "shaft", "weave", "sleep", "brand", "shave", "jelly", "mouse", "block", "aloof", "plane", "fence", "siege", "haunt", "medal", "cheat", "greet", "queue", "asset", "store", "brink", "stage", "berry", "blade", "paint", "scrap", "abbey", "brave", "vague", "lease", "toast", "large", "flock", "teach", "young", "carve", "Bible", "world", "feast", "forum", "stock", "fight", "final", "sweep", "bride", "quiet", "joint", "widen", "patch", "fruit", "small", "attic", "shine", "still", "graze", "field", "punch", "evoke", "snake", "round", "groan", "false", "ready", "penny", "taste", "treat", "trial", "major", "value", "elbow", "quest", "cruel", "dozen", "spill", "layer", "shout", "arena", "tooth", "order", "party", "steel", "rugby", "panic", "think" };
        public string generateWord()
        {
                Random random = new Random(Guid.NewGuid().GetHashCode());
                int i = random.Next(0, common.Length - 1);
                return common[i];
        }
    }
}
