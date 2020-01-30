using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simhall
{
    class YoungSwimmer : Swimmer
    {
        private bool tired = false;
        public override void Swim()
        {
            if (tired == true)
            {
                Console.WriteLine("I'm so tired - time to get out.");
            }
            else
            {
                tired = true;
                Console.WriteLine("Splish splash - it's so fun in the bath!");
            }
        }
    }
}
