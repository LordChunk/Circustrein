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

        public List<Dier> Dieren = new List<Dier>();

        public Dier.Maten VleesEterMaat()
        {
            //Return grootte van vleeseter
            return Dieren.Find(Dier => Dier.Vleeseter).Grootte;
        }

        public void dierAdd(Dier nieuwDier) => Dieren.Add(nieuwDier);

        public override string ToString()
        {
            return "Wagon";
        }
    }
}
