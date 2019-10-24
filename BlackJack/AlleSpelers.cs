using System;
using System.Collections.Generic;

namespace BlackJack
{
    public class AlleSpelers
    {
        public List<Speler> spelers { get; }

        public AlleSpelers(List<Speler> spelers)
        {
            spelers = spelers;
        }

        public void aantalSpelers(List<Speler> spelers)
        {
            Console.WriteLine("Met hoeveel mensen spelen we?");
            String invoerSpelers = Console.ReadLine();
            int mensen = Convert.ToInt16(invoerSpelers);
            for (int i = 1; i <= mensen; i++)
            {
                Console.WriteLine("Voer de naam van de speler " + i);
                String naam = Console.ReadLine();
                Speler speler = new Speler(naam, true, 0);
                spelers.Add(speler);
            }

            Console.WriteLine("Dit zijn de spelers: ");
            foreach (Speler speler in spelers)
            {
                Console.WriteLine(speler.Naam);
            }
        }
        
        }
    }
