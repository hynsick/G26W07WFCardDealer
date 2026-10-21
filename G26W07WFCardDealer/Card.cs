using System;
using System.Collections.Generic;
using System.Text;

namespace G26W07WFCardDealer
{
    // 카드 무늬. 화면 표현(이미지 등)과 무관하게 의미만 나타낸다.
    public enum Suit { Spades, Hearts, Diamonds, Clubs }

    // 카드 숫자. 정수값을 직접 지정해서 (int)card.Rank로 크기 비교와 정렬을 바로 할 수 있다.
    // Two부터 Ten까지는 앞 값에서 1씩 자동으로 늘어나 숫자와 같아지고,
    // Jack 이후는 읽기 쉽도록 값을 명시했다.
    // Ace는 가장 큰 수인 14로 두며, A,2,3,4,5(백스트레이트)는 CheckCard에서 따로 처리한다.
    public enum Rank
    {
        Two = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack = 11, Queen = 12, King = 13, Ace = 14
    }

    // 카드 한 장. 무늬(Suit)와 숫자(Rank)만 가진다.
    // 이미지 이름 같은 화면 표현이 없어서 View와 독립적이고,
    // 포커 외의 다른 카드 게임에서도 그대로 재사용할 수 있다.
    public class Card
    {
        // get만 있는 속성이라 생성할 때 한 번 정해지면 바꿀 수 없다. (불변)
        public Suit Suit { get; }
        public Rank Rank { get; }

        // 무늬와 숫자를 받아 카드를 만든다.
        public Card(Suit suit, Rank rank)
        {
            Suit = suit;
            Rank = rank;
        }
    }
}