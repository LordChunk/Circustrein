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
            List<Dier> VleesEterLijst = Dieren.Where(Dier => Dier.EetVlees).ToList();

            if(VleesEterLijst.Count == 0)
            {
                return Dier.Groottes.Geen;
            } else
            {
                return VleesEterLijst.First().Grootte;
            }
        }

        public bool TryAddDier(Dier nieuwDier)
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
