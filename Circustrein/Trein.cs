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

        public Wagon AddDierToNewWagon(Dier dier)
        {
            Wagon NewWagon = new Wagon();

            NewWagon.TryAddDier(dier);

            Wagons.Add(NewWagon);

            return NewWagon;
        }

        public List<Dier> SorteerDieren(List<Dier> unorderedDieren)
        {
            //Zet vleeseters eerst
            return unorderedDieren.OrderByDescending(Dier => Dier.EetVlees)
                                    //Sorteer van groot naar klein
                                    .ThenByDescending(Dier => (int)Dier.Grootte)
                                    .ToList();
        }

        public void FillWagons(List<Dier> alleDieren)
        {
            alleDieren = SorteerDieren(alleDieren);

            foreach (Dier currentDier in alleDieren)
            {
                if (currentDier.EetVlees)
                {
                    AddDierToNewWagon(currentDier);
                }
                else
                {
                    bool dierHasSpot = false;

                    foreach(Wagon currentWagon in Wagons)
                    { 
                        dierHasSpot = currentWagon.TryAddDier(currentDier);
                        if (dierHasSpot) break;
                    }

                    if (!dierHasSpot)
                    {
                        AddDierToNewWagon(currentDier);
                    }
                }
            }
        }
    }
}
