using System;

namespace BlackJack
{
    public class Kaart
    {
        public string TypeKaart { get; }
        public string Kleur { get; }
        public int Waarde { get; set; }

        public Kaart(String typeKaart, String kleur, int waarde)
        {
            TypeKaart = typeKaart;
            Kleur = kleur;
            Waarde = waarde;
        }
        

    }
}