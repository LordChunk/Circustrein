using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    class Wagon
    {
        public int ruimte = 10;

        public int wagonNummer;

        public List<Dier> Dieren = new List<Dier>();

        public Wagon()
        {
            
        }

        public void dierAdd(Dier nieuwDier) => Dieren.Add(nieuwDier);

        public override string ToString()
        {
            return "Wagon No. " + wagonNummer;
        }
    }
}
