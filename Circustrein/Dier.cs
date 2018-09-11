using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    class Dier
    {
        public enum DierMaat
        {
            Groot = 5,
            Middelgroot = 3,
            Klein = 1,
            Geen = 0
        }
        
        public DierMaat Grootte;
        public bool Vleeseter { get; set; }
        public string Naam { get; set; }

        public Dier(DierMaat dierMaat, bool eetVlees, string dierNaam)
        {
            Grootte = dierMaat;
            Vleeseter = eetVlees;
            Naam = dierNaam;
        }


        public override string ToString()
        {
            //orgineel
            //return Naam;
            //Tijdelijk voor makkelijker debuggen
            //return Grootte +" "+ Vleeseter;
            return $"{Grootte} ({(Vleeseter ? "Vlees" : "Planten")})";
        }

        public string getSoort()
        {
            return Vleeseter ? "vleeseeter" : "planteneter";
        }
    }
}
