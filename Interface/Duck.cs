using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Duck : Mascot, IBird
    {
        public string Color
        {
            get; set;
        }

        public string Sound
        {
            get; set;
        }
        public string Age
        {
            get; set;
        }

        public string GetBirdInfo()
        {
            return $"{Name} is a {Color} duck, makes {Sound} sound, and is {Age} years old.";
        }
    }
}
