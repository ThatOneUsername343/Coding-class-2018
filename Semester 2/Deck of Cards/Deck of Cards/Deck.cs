﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_of_Cards
{
    class Deck
    {
        List<Cards> deck = new List<Cards>();
        List<Cards> discard = new List<Cards>();
        public Deck()
        {
            foreach (var face in Enum.GetValues(typeof(cardFace)))
            {
                foreach (var suit in Enum.GetValues(typeof(Suit)))
                {
                    deck.Add(new Cards((cardFace)face, (Suit)suit));
                }
            }
        }

        public void Shuffle()
        {
            Random rand = new Random();
            int rholder = rand.Next();
            Cards Holder = deck[rholder];
            deck.RemoveAt(rholder);
            deck.Add(Holder);
        }

        public Cards Draw()
        {
            Cards thatOneCard;
            if (deck.Count > 0)
            {
                thatOneCard = deck.Last();
                deck.RemoveAt(deck.Count() - 1);
                return thatOneCard;
            }

            else
            {
                Console.WriteLine("STACK UNDERFLOW BIACH!!!!");
                return deck[0];
            }
        }

        public void Discard()
        {
            Cards discardCards;
            discardCards = deck.Last();
            discard.Add(discardCards);
            deck.RemoveAt(deck.Count());
        }

        public void PrintDeck()
        {
            for (int i = 0; i < deck.Count; i++)
            {
                Console.WriteLine(deck[i] + ",");
            }
        }

        public void PrintDiscard()
        {
            for (int i = 0; i < discard.Count; i++)
            {
                Console.WriteLine(discard[i] + ",");
            }
        }
    }
}
