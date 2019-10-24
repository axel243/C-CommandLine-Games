using System;

namespace BlackJack
{
    public class Kaart
    {
        public string TypeKaart { get; }
        public Enum Kleur { get; }

        public int Waarde { get; set; }

        public Kaart(String typeKaart, Enum kleur, int waarde)
        {
            TypeKaart = typeKaart;
            Kleur = kleur;
            Waarde = waarde;
        }
        

    }
}