using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BlackJack
{
    public class Spelen
    {
        private static AlleSpelers spelers = new AlleSpelers(spelerLijst);
        private static List<Speler> spelerLijst = new List<Speler>();
        private static Stack<Kaart> deck = new Stack<Kaart>();
        private static Deck kaartendeck = new Deck(new KaartenSet(deck));
        public static void Spel()
        {
            spelers.aantalSpelers(spelerLijst);
            kaartendeck.HoeveelheidSetjes();
            kaartendeck.Shuffle();
            StartingHand();
            while (spelerLijst.Any(s => s.DoetMee == true)){
                foreach (Speler speler in spelerLijst)
                {
                    if (speler.DoetMee == true)
                    {
                        Actie(speler);
                    }
                }
            }
            ResultGame();
        }

         static void Actie(Speler speler)
        {
            Console.WriteLine(speler.Naam + " Kies uw actie: \n" + "K voor kaart vragen \n" + "Q voor het stoppen \n" );
            var invoer = Console.ReadKey();
            if (invoer.Key == ConsoleKey.K)
            {
                speler.AddToHand(deck.Pop());
                Console.WriteLine(speler.Naam + " pakt een kaart");
                speler.PrintValues(speler.Hand);
            }
            else if (invoer.Key == ConsoleKey.Q)
            {
                Console.WriteLine(speler.Naam + " stand! ");
                speler.DoetMee = false;
            }
        }

        static void StartingHand()
        {
            foreach (Speler speler in spelerLijst)
            {
                speler.AddToHand(deck.Pop());
                speler.AddToHand(deck.Pop());
                speler.PrintValues(speler.Hand);
            }
        }

        static void ResultGame()
        {
            List<int> scores = new List<int>();
            foreach (Speler speler in spelerLijst)
            {
                speler.WaardeHand = speler.finalHand(speler.Hand);
                if (speler.WaardeHand < 22)
                {
                    scores.Add(speler.WaardeHand);
                }

                Console.WriteLine(speler.Naam + " " + speler.WaardeHand);
            }

            int finalScore = scores.Max();
            foreach (Speler speler in spelerLijst)
            {
                if (finalScore == speler.WaardeHand)
                {
                    Console.WriteLine("\n" + speler.Naam + " wint!" + speler.WaardeHand);
                    break;
                }
            }
        }
    }
}