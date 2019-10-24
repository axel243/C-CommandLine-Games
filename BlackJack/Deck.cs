using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BlackJack
{
    public class Deck : KaartenSet
    {
        public KaartenSet Setje { get; }

        public Deck(KaartenSet setje) : base(setKaarten)
        {
            Setje = setje;
        }

        public void HoeveelheidSetjes()
        {
            Console.WriteLine("Hoeveel setten kaarten wil je? er kunnen max 6 setjes in een deck");
            int aantalsets = Convert.ToInt16(Console.ReadLine());
            while (aantalsets < 1 || aantalsets > 6)
            {
                Console.WriteLine("Kaartensetjes kan alleen 1 of 6 zijn! Voer opnieuw de waarde in");
                aantalsets = Convert.ToInt16(Console.ReadLine());
            }

            for (int i = 0; i < aantalsets; i++)
            {
                VormBasisSet(setKaarten);
            }
        }

        public void Shuffle()
        {
            var values = setKaarten.ToArray();
            Random rnd = new Random();
            setKaarten.Clear();
            foreach (var value in values.OrderBy(x => rnd.Next()))
                setKaarten.Push(value);
        }
        
        public void PrintValues( Stack<Kaart> kaartenset )  {
            foreach ( Kaart kaart in kaartenset )
                Console.WriteLine( "   {0}", kaart.Kleur + " " + kaart.TypeKaart + " " + kaart.Waarde);
            Console.WriteLine();
        }
    }
}