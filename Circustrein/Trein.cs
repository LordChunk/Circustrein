using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    class Trein
    {
        public List<Wagon> Wagons = new List<Wagon>();

        public void addWagon(Wagon nieuweWagon)
        {
            Wagons.Add(nieuweWagon);
        }

        public List<Dier> sorteerDieren(List<Dier> unorderedDieren)
        {
                                    //Zet vleeseters eerst
            return unorderedDieren.OrderByDescending(Dier => Dier.Vleeseter)
                                    //Sorteer van groot naar klein
                                    .ThenByDescending(Dier => (int)Dier.Grootte)
                                    //Convert to list
                                    .ToList();
        }
    }
}
