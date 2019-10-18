using System;

namespace Ganzenbord
{
    class ProgramOOP
    {
    }
}
/*private static void Main(string[] args)
{
    int position = 0;
    int end = 63;
    bool state = true;
    Console.WriteLine("Je staat op start. Gooi je dobbelsteen");
    var throwDice = Console.ReadKey();
    if (throwDice.Key != ConsoleKey.G)
    {
        state = false;
    }
    while(state == true)
    {
        if (position > 63)
        {
            int stappenTerug  = position - end;
            position = end - stappenTerug;
            Console.WriteLine("Je gooit teveel!! je moet " + stappenTerug + " van " + end);
        }
        throwDice = Console.ReadKey();
        Console.WriteLine("\n");
        if (throwDice.Key != ConsoleKey.G)
        {
            state = false;
        }
        Random rnd = new Random();
        int dobbelsteen = rnd.Next(6);
        switch (dobbelsteen)
        {
            case 1:
                Console.WriteLine("Je hebt 1 gegooid!");
                position += 1;
                break;
            case 2:
                Console.WriteLine("Je hebt 2 gegooid!");
                position += 2;
                break;
            case 3:
                Console.WriteLine("Je hebt 3 gegooid!");
                position += 3;
                break;
            case 4:
                Console.WriteLine("Je hebt 4 gegooid!");
                position += 4;
                break;
            case 5:
                Console.WriteLine("Je hebt 5 gegooid!");
                position += 5;
                break;
            case 6:
                Console.WriteLine("Je hebt 6 gegooid!");
                position += 6;
                break;
        }
        Console.WriteLine("Je staat op vakje: " + position);
        switch (position)
        {
            case 6:
                Console.WriteLine("Een brug! Deze brug brengt de speler naar vakje 12");
                position = 12;
                break;
            case 19:
                Console.WriteLine("De speler zit vast op de herberg! Beurt overslaan");
                position = -dobbelsteen;
                break;
            case 31:
                Console.WriteLine("De put! Wacht tot een medespeler je voorbij komt om je op te halen");
                break;
            case 42:
                Console.WriteLine("Betrapt in een doolhof! Deze brengt de speler terug naar vakje 39");
                position = 39;
                break;
            case 58:
                Console.WriteLine("Gedood! Begin van start!");
                position = 0;
                break;
            case 23:
                Console.WriteLine("Gevangen!!! De speler is af!");
                state = false;
                break;
            case 63:
                Console.WriteLine("Het spel is afgelopen!!! De speler heeft gewonnen");
                state = false;
                break;
            case 25: case 45:
                Console.WriteLine("Oh nee! de speler moet terug naar start!");
                position = 0;
                break;
            case 10: case 20: case 30: case 40: case 50: case 60:
                position += dobbelsteen;
                break;
        }
    }
    Console.WriteLine( "\n" + "Ander spelletje dan?");
}
}
}*/