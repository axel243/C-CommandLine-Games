using System;

namespace Ganzenbord
{
    public class Dobbelsteen
    {
        private int nummer;
        public Dobbelsteen()
        {
        }

        public int gooiDobbelsteen()
        {
            nummer = 0;
            Random rnd = new Random();
            switch (rnd.Next(1,7))
            {
                case 1:
                    nummer += 1;
                    break;
                case 2:
                    nummer += 2;
                    break;
                case 3:
                    nummer += 3;
                    break;
                case 4:
                    nummer += 4;
                    break;
                case 5:
                    nummer += 5;
                    break;
                case 6:
                    nummer += 6;
                    break;
            }
            Console.WriteLine("\n Je hebt " + nummer + " gegooid!");
            return nummer;
        }
    }
}