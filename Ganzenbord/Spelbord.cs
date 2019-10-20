using System;

namespace Ganzenbord
{
    public class Spelbord
    {
        private int position;
        public bool Staat { get; set ; }
        private int end = 63;
        Dobbelsteen dobbelsteen = new Dobbelsteen();
        public Spelbord()
        {
        }
        
        
        public int SpelbordVakken(int position, int dobbelsteenwaarde)
        {
            switch (position)
            {
                case 6:
                    Console.WriteLine("Een brug! Deze brug brengt de speler naar vakje 12");
                    position = 12;
                    break;
                case 42:
                    Console.WriteLine("Betrapt in een doolhof! Deze brengt de speler terug naar vakje 39");
                    position = 39;
                    break;
                case 58:
                    Console.WriteLine("Gedood! Begin van start!");
                    position = 0;
                    break;
                case 63:
                    Console.WriteLine("Het spel is afgelopen!!! De speler heeft gewonnen");
                    Staat = false;
                    break;
                case 25: case 45:
                    Console.WriteLine("Oh nee! de speler moet terug naar start!");
                    position = 0;
                    break;
                case 10: case 20: case 30: case 40: case 50: case 60:
                    Console.WriteLine("Op een decimaal vakje! ga nog eens " + dobbelsteenwaarde + " stappen vooruit!");
                    position += dobbelsteenwaarde;
                    break;
            
            }
            if (position > 63) {
                int stappenTerug = position - end;
                position = end - stappenTerug;
                Console.WriteLine("Je gooit teveel!! je moet " + stappenTerug + " van " + end);
            }

            return position;
        }
    }
}