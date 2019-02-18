namespace Circustrein
{
    public class Dier
    {
        public enum Groottes
        {
            Groot = 5,
            Middelgroot = 3,
            Klein = 1,
            Geen = 0
        }
        
        public Groottes Grootte;
        public bool EetVlees { get; set; }
        public string Naam { get; set; }

        public Dier(Groottes grootte, bool eetVlees, string naam)
        {
            Grootte = grootte;
            EetVlees = eetVlees;
            Naam = naam;
        }


        public override string ToString()
        {
            //orgineel
            //return Naam;
            //Tijdelijk voor makkelijker debuggen
            //return Grootte +" "+ Vleeseter;
            return $"{Grootte} ({(EetVlees ? "Vlees" : "Planten")})";
        }

        public string getSoort()
        {
            return EetVlees ? "vleeseeter" : "planteneter";
        }
    }
}
