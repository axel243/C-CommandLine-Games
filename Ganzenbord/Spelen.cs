using System;
using System.Collections;

namespace Ganzenbord
{
    public class Spelen
    {
        static Dobbelsteen dobbelsteen = new Dobbelsteen();
        static Spelbord spelbord = new Spelbord();
        static Speler speler = new Speler("", 0, true, false);
        static ArrayList spelers = new ArrayList();
        
        public static void Speel()
        {
            spelbord.Staat = true;
            addSpeler();
            while (spelbord.Staat == true) {
                foreach (Speler speler in spelers) {
                    Console.WriteLine("\n" + speler.naam + " Toets g in om de dobbelsteen te gooien");
                        var throwDice = Console.ReadKey();
                        if (throwDice.Key != ConsoleKey.G)
                        {
                            spelbord.Staat = false;
                        }
                        else
                        {
                            int dobbelsteenWaarde = dobbelsteen.gooiDobbelsteen();
                            speler.position += dobbelsteenWaarde;
                            speler.position = spelbord.SpelbordVakken(speler.position, dobbelsteenWaarde);
                            SpelbordVakkenTwee(speler.position);
                            Console.WriteLine(speler.naam + " staat op vakje: " + speler.position);
                        }
                }
            }
        }

        public static void addSpeler()
        {
            Console.WriteLine("Met hoeveel mensen spelen we?");
            String invoerSpelers = Console.ReadLine();
            int mensen = Convert.ToInt16(invoerSpelers);
            for (int i = 1; i <= mensen; i++)
            {
                Console.WriteLine("Voer de naam van de speler " + i);
                String naam = Console.ReadLine();
                Speler speler = new Speler(naam, 0, true, false);
                spelers.Add(speler);
            }

            Console.WriteLine("Dit zijn de spelers: ");
            foreach (Speler speler in spelers)
            {
                Console.WriteLine(speler.naam);
            }

        }

        public static void SpelbordVakkenTwee(int position) {
            switch (position)
            {
                case 19:
                    Console.WriteLine("De speler zit vast op de herberg! Beurt overslaan");
                    break;
                case 31:
                    Console.WriteLine("De put! Wacht tot een medespeler je voorbij komt om je op te halen");
                    break;
                case 23:
                    Console.WriteLine("Gevangen!!! De speler is af!");
                    break;
            }
        }
    }
}