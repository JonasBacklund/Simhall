using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simhall
{
    class BubbelPool
    {
        private int max = 10;
        private int dirt = 0;
        private List<Swimmer> people = new List<Swimmer>();
        public void GetIn(Swimmer swimmer)
        {
            people.Add(swimmer);
            Dirtier();
        }
        public void GetOut(Swimmer swimmer)
        {
            people.Remove(swimmer);
            Dirtier();
        }
        public void Dirtier()
        {
            dirt++;
            if (dirt == max)
            {
                throw new PoolDirtyException("Pool Became dirty!");
            }
        }
        public void Clean()
        {
            dirt = 0;
            people.Clear();
        }
    }
}
