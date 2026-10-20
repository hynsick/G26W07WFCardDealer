using System;
using System.Collections.Generic;
using System.Text;

namespace G26W07WFCardDealer
{
    public enum Suit { Spades, Hearts, Diamonds, Clubs }
    public enum Rank
    {
        Two = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack = 11, Queen = 12, King = 13, Ace = 14
    }  
    public class Card
    {
        public Suit Suit { get; }
        public Rank Rank { get; }

        public Card(Suit suit, Rank rank)
        {
            Suit = suit;
            Rank = rank;
        }
    }
}
