using System;
using System.Security.Cryptography.X509Certificates;

namespace Ganzenbord
{
    class Program
    {
       
        
        private static void Main(string[] args)
        {
            StartSpel();
        }

        static void StartSpel()
        {
            Spelbord spelbord = new Spelbord();
            Console.WriteLine("Wil je ganzenbord met mij spelen? Toets g in om bevestigen");
            var throwDice = Console.ReadKey();
            if (throwDice.Key != ConsoleKey.G)
            {
                spelbord.Staat = false;
                Console.WriteLine( "\n" + "Ander spelletje dan?");
            }
            else
            {
                Spelen.Speel();
            }
          
        }
    }
    }