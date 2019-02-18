using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    public class Trein
    {
        public List<Wagon> Wagons = new List<Wagon>();

        public Wagon CreateWagon()
        {
            Wagon NewWagon = new Wagon();

            Wagons.Add(NewWagon);

            return NewWagon;
        }

        public List<Dier> SorteerDieren(List<Dier> unorderedDieren)
        {
                                    //Zet vleeseters eerst
            return unorderedDieren.OrderByDescending(Dier => Dier.EetVlees)
                                    //Sorteer van groot naar klein
                                    .ThenByDescending(Dier => (int)Dier.Grootte)
                                    //Convert to list
                                    .ToList();
        }

        public void FillWagons(List<Dier> alleDieren)
        {
            alleDieren = SorteerDieren(alleDieren);

            //maak wagon voor elke vleeseter
            for (int i = 0; i < alleDieren.Count; i++)
            {
                Dier currentDier = alleDieren[i];
                if (currentDier.EetVlees)
                {
                    Wagon nieuweWagon = CreateWagon();

                    nieuweWagon.AddDier(currentDier);
                }
                else
                {
                    //Set bool to default
                    bool dierHasSpot = false;

                    //Cycle door alle huidige wagons voor een plaats voor het dier
                    for (int j = 0; j < Wagons.Count && !dierHasSpot /*check of dier al een plek heeft */; j++)
                    {
                        Wagon currentWagon = Wagons[j];

                        dierHasSpot = currentWagon.AddDier(currentDier);
                    }

                    //Check of dier niet in een wagon meer kan en maak een nieuwe wagon
                    if (!dierHasSpot)
                    {
                        Wagon nieuweWagon = CreateWagon();

                        nieuweWagon.AddDier(currentDier);
                    }
                }
            }
        }
    }
}
