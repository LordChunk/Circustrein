using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circustrein
{
    public class Wagon
    {
        public List<Dier> Dieren = new List<Dier>();

        public int Ruimte { get; private set; } = 10;

        private Dier.Groottes GrootsteVleeseter()
        {
            //Return grootte van vleeseter
            
            // Vind vleeseter in wagon
            List<Dier> VleesEterLijst = Dieren.Where(Dier => Dier.EetVlees).ToList();

            // Check of wagon een vleeseter heeft
            if(VleesEterLijst.Count == 0)
            {
                return Dier.Groottes.Geen;
            } else
            {
                return VleesEterLijst.First().Grootte;
            }
        }

        //public void dierAdd(Dier nieuwDier) => Dieren.Add(nieuwDier);
        public bool AddDier(Dier nieuwDier)
        {
            //Check of wagon nog ruimte heeft en het dier in de wagon mag
            if (nieuwDier.Grootte > GrootsteVleeseter() && (int) nieuwDier.Grootte <= Ruimte)
            {
                Dieren.Add(nieuwDier);
                Ruimte = 10 - Dieren.Sum(Dier => (int) Dier.Grootte);
                return true;
            } else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return "Wagon";
        }
    }
}
