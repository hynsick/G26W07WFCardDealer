using System;
using System.Collections.Generic;

namespace G26W07WFCardDealer
{
    internal class Deck
    {
        private readonly List<Card> cards;
        private readonly Random random;

        public Deck()
        {
            cards = new List<Card>();
            random = new Random();

            // 이중 반복문으로 52장 덱 생성
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Rank rank in Enum.GetValues(typeof(Rank)))
                {
                    cards.Add(new Card(suit, rank));
                }
            }
        }

        // 5장을 랜덤으로 뽑는 기능
        public List<Card> Draw(int count)
        {
            List<Card> hand = new List<Card>();
            for (int i = 0; i < count; i++)
            {
                int index = random.Next(cards.Count);
                hand.Add(cards[index]);
                cards.RemoveAt(index);
            }
            return hand;
        }
    }
}

