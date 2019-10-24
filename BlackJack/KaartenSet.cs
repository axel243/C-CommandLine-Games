﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace BlackJack
{
    public class KaartenSet
    {
        public static Stack<Kaart> setKaarten = new Stack<Kaart>();
        String[] kleuren = new string[4] {"Harten", "Ruiter", "Schopper", "Klaver"};

        public KaartenSet(Stack<Kaart> setKaarten) {
            KaartenSet.setKaarten = setKaarten;
        }
        
        public Stack<Kaart> VormBasisSet(Stack<Kaart> setKaarten) {
            foreach (String kleur in kleuren) {
                for (int i = 2; i <= 10; i++) { 
                    setKaarten.Push(new Kaart(Convert.ToString(i), kleur, i)); 
                } 
                setKaarten.Push(new Kaart("Boer", kleur, 10));
                setKaarten.Push(new Kaart("Koning", kleur, 10));
                setKaarten.Push(new Kaart("Koningin", kleur, 10));
                setKaarten.Push(new Kaart("Aas", kleur, 11)); 
            }

            return setKaarten;
        }
    }
}