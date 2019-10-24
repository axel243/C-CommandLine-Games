using System;
using System.Collections;

namespace Ganzenbord
{
    public class Spelen
    {
        static Dobbelsteen dobbelsteen = new Dobbelsteen();
        static Spelbord spelbord = new Spelbord();
        static ArrayList spelers = new ArrayList();
        
        public static void Speel()
        {
            spelbord.Staat = true;
            addSpeler();
            while (spelbord.Staat == true) {
                foreach (Speler speler in spelers) {
                    if (speler.doetMee ) {
                        if (speler.beurtOverslaan == true || speler.put == true)
                        {
                            Console.WriteLine(speler.naam + " moet een beurt overslaan");
                            speler.beurtOverslaan = false;
                        }
                        else {
                            Console.WriteLine("\n" + speler.naam + " Toets g in om de dobbelsteen te gooien");
                            var throwDice = Console.ReadKey();
                            if (throwDice.Key != ConsoleKey.G)
                            {
                                spelbord.Staat = false;
                            }
                            else {
                                int dobbelsteenWaarde = dobbelsteen.gooiDobbelsteen();
                                speler.position += dobbelsteenWaarde;
                                spelbord.SpelbordVakken(speler.position, dobbelsteenWaarde, spelers);
                                Console.WriteLine(speler.naam + " staat op vakje: " + speler.position);
                            }
                        }
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
                Speler speler = new Speler(naam, 0, true, false, false);
                spelers.Add(speler);
            }

            Console.WriteLine("Dit zijn de spelers: ");
            foreach (Speler speler in spelers)
            {
                Console.WriteLine(speler.naam);
            }

        }
    }
}