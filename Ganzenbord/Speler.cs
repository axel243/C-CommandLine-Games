using System;
using System.Collections;
using System.Transactions;

namespace Ganzenbord
{
    public class Speler
    {
        public String naam { get; set; }
        public int position { get; set; }
        public bool doetMee { get; set; }
        public bool beurtOverslaan { get; set; }
        public bool put { get; set; }

        public Speler(String naam, int position, bool doetMee, bool beurtOverslaan, bool put)
        {
            this.naam = naam;
            this.position = position;
            this.doetMee = doetMee;
            this.beurtOverslaan = beurtOverslaan;
            this.put = put;
        }

    }
}