using System;
using System.Collections.Generic;

namespace BlackJack
{
    public class Speler
    {
        public string Naam { get; }
        public List<Kaart> Hand { get; }
        public bool DoetMee { get; set; }
        public int WaardeHand { get; set; }

        public Speler(String naam, bool doetMee, int waardeHand)
        {
            Naam = naam;
            Hand = new List<Kaart>();
            DoetMee = doetMee;
            WaardeHand = waardeHand;
        }

        public void PrintValues( List<Kaart> hand )  {
            foreach ( Kaart kaart in hand )
                Console.WriteLine( Naam + " heeft "+  kaart.Kleur + " " + kaart.TypeKaart + " " + kaart.Waarde);
            Console.WriteLine();
        }

        public void AddToHand(Kaart kaart) {
            Hand.Add(kaart);
        }
        
        public int finalHand(List<Kaart> finalHand)
        {
            int score = 0 ;
            foreach (Kaart kaart in finalHand)
            {
                score += kaart.Waarde;
            }

            return score;
        }
    }
}