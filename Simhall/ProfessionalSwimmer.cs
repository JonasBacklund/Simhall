using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simhall
{
    class ProfessionalSwimmer : Swimmer
    {
        public override void SetSuit(BathingSuit suit)
        {
            if (suit != null)
            {
                base.SetSuit(suit);
            }
            else
            {
                Console.WriteLine("The TV company will get in trouble! You need a suit!");
            }
        }
    }
}
