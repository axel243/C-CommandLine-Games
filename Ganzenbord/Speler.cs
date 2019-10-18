using System;
using System.Collections;
using System.Transactions;

namespace Ganzenbord
{
    public class Speler
    {
        public String naam { get; set; }
        public int position { get; set; }

        public Speler(String naam, int position)
        {
            this.naam = naam;
            this.position = position;
           
        }

    }
}