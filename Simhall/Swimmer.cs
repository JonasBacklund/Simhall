using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simhall
{
    class Swimmer
    {
        private string name;
        private BathingSuit suit;
        public virtual void Swim()
        {
            Console.WriteLine("Splish splash - it's so fun in the bath!");
        }
        public virtual void SetSuit(BathingSuit suit)
        {
            this.suit = suit;
        }
        

        
    }
}
