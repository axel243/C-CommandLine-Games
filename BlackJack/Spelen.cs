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
            Speler dealer = spelers.addDealer();
            spelers.aantalSpelers(spelerLijst);
            kaartendeck.HoeveelheidSetjes();
            kaartendeck.Shuffle();
            StartingHand();
            DealerHand(dealer);
            while (spelerLijst.Any(s => s.DoetMee == true))
            {
                foreach (Speler speler in spelerLijst)
                {
                    if (speler.DoetMee == true)
                    {
                        Actie(speler);
                    }
                }
            }

            spelerLijst.Add(dealer);
            actieDealer(dealer);
            ResultGame(dealer);
        }

        static void Actie(Speler speler)
        {
            if (speler.IsDealer == false)
            {
                Console.WriteLine(speler.Naam + " Kies uw actie: \n" + "K voor kaart vragen \n" +
                                  "Q voor het stoppen \n");
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
        }

        static Speler actieDealer(Speler speler)
        {
            Console.WriteLine(speler.WaardeHand);
            while (spelerLijst.Any(s => s.IsDealer == true))
            {
                if (speler.WaardeHand > 15)
                {
                    speler.DoetMee = false;
                    break;
                }

                speler.AddToHand(deck.Pop());
                speler.WaardeHand = speler.finalHand(speler.Hand);
                speler.PrintValues(speler.Hand);
            }
            return speler;
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

        static Speler DealerHand(Speler speler)
        {
            speler.AddToHand(deck.Pop());
            speler.PrintValues(speler.Hand);
            speler.AddToHand(deck.Pop());
            speler.WaardeHand = speler.finalHand(speler.Hand);
            return speler;
        }

        static void ResultGame(Speler dealer) {
            foreach (Speler speler in spelerLijst) {
                speler.WaardeHand = speler.finalHand(speler.Hand);
                Console.WriteLine(speler.Naam + " " + speler.WaardeHand);
                if (speler.WaardeHand < 22) {
                    if (dealer.WaardeHand < speler.WaardeHand) {
                        Console.WriteLine(speler.Naam + "wint van de dealer! " + speler.WaardeHand);
                    }
                }
            }
        }
    }
}