using System;

namespace Ganzenbord
{
    public class Spelen
    {
        static Dobbelsteen dobbelsteen = new Dobbelsteen();
        static Spelbord spelbord = new Spelbord();
        public static void Speel() {
            spelbord.Staat = true;
            while(spelbord.Staat == true) {
                Console.WriteLine("Toets g in om de dobbelsteen te gooien");
                var throwDice = Console.ReadKey();
                Console.WriteLine("\n");
                if (throwDice.Key != ConsoleKey.G)
                {
                    spelbord.Staat = false;
                }
                else
                {
                    spelbord.SpelbordVakken(dobbelsteen.gooiDobbelsteen());
                }
            }
        }
    }
}