using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circustrein
{
    class Wagon
    {
        public List<Dier> Dieren = new List<Dier>();

        private int ruimte = 10;

        public Dier.DierMaat VleesEterMaat()
        {
            //Return grootte van vleeseter
            try
            {
                return Dieren.Find(Dier => Dier.Vleeseter).Grootte;
            }
            catch (Exception e)
            {
                return Dier.DierMaat.Geen;
            }
        }

        //public void dierAdd(Dier nieuwDier) => Dieren.Add(nieuwDier);
        public bool dierAdd(Dier nieuwDier)
        {
            //Check of wagon nog ruimte heeft en het dier in de wagon mag
            if (nieuwDier.Grootte > VleesEterMaat() && (int) nieuwDier.Grootte <= ruimte)
            {
                Dieren.Add(nieuwDier);
                ruimte -= Dieren.Sum(Dier => (int) Dier.Grootte);
                return true;
            }
            else
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
