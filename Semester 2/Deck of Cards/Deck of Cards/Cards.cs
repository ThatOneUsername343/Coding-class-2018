using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_of_Cards
{
    public enum Suit
    {
        Diamonds,
        Hearts,
        Spades,
        Clubs
    }

    public enum cardFace
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }

    public class Cards
    {
        public cardFace face;
        public Suit suit;

        public Cards(cardFace face, Suit suit)
        {
            //int I = (int)face;
            this.face = face;
            this.suit = suit;
        }

        public static Dictionary<cardFace, int> CardValues = new Dictionary<cardFace, int>()
        {
            {cardFace.Ace, 11},
            {cardFace.Two, 2},
            {cardFace.Three, 3 },
            {cardFace.Four, 4 },
            {cardFace.Five, 5 },
            {cardFace.Six, 6 },
            {cardFace.Seven, 7 },
            {cardFace.Eight, 8 },
            {cardFace.Nine, 9 },
            {cardFace.Ten, 10 },
            {cardFace.Jack, 10 },
            {cardFace.Queen, 10 },
            {cardFace.King, 10 }
        };

        public void Print()
        {
            Console.WriteLine("____________________");
            Console.WriteLine("|" + face + " " + suit + "|");
            Console.WriteLine("____________________");
        }
    }
}
