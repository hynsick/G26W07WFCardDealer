using System.Collections.Generic;
using static G26W07WFCardDealer.Rank;

namespace G26W07WFCardDealer
{
    // 실행 화면 캡처용 테스트 데이터.
    // 족보 13종을 하나씩 확인할 수 있도록 정해진 패를 보관한다.
    // UI 타입을 사용하지 않고 Card 객체만 다루므로 View와 분리되어 있다.
    internal class CheckCardTest
    {
        // 족보 순위 순서(로열 스트레이트 플러시 ~ 하이 카드)대로 5장씩 담은 패 목록
        private static readonly Card[][] Hands =
        {
            // 1. 로열 스트레이트 플러시
            new[] { new Card(Suit.Spades, Ace), new Card(Suit.Spades, King), new Card(Suit.Spades, Queen), new Card(Suit.Spades, Jack), new Card(Suit.Spades, Ten) },
            // 2. 백스트레이트 플러시
            new[] { new Card(Suit.Hearts, Ace), new Card(Suit.Hearts, Two), new Card(Suit.Hearts, Three), new Card(Suit.Hearts, Four), new Card(Suit.Hearts, Five) },
            // 3. 스트레이트 플러시
            new[] { new Card(Suit.Clubs, Five), new Card(Suit.Clubs, Six), new Card(Suit.Clubs, Seven), new Card(Suit.Clubs, Eight), new Card(Suit.Clubs, Nine) },
            // 4. 포카드
            new[] { new Card(Suit.Spades, Nine), new Card(Suit.Hearts, Nine), new Card(Suit.Diamonds, Nine), new Card(Suit.Clubs, Nine), new Card(Suit.Spades, Two) },
            // 5. 풀하우스
            new[] { new Card(Suit.Spades, King), new Card(Suit.Hearts, King), new Card(Suit.Diamonds, King), new Card(Suit.Clubs, Four), new Card(Suit.Spades, Four) },
            // 6. 플러시
            new[] { new Card(Suit.Diamonds, Two), new Card(Suit.Diamonds, Five), new Card(Suit.Diamonds, Seven), new Card(Suit.Diamonds, Nine), new Card(Suit.Diamonds, Jack) },
            // 7. 마운틴
            new[] { new Card(Suit.Spades, Ace), new Card(Suit.Hearts, King), new Card(Suit.Diamonds, Queen), new Card(Suit.Clubs, Jack), new Card(Suit.Spades, Ten) },
            // 8. 백스트레이트
            new[] { new Card(Suit.Spades, Ace), new Card(Suit.Hearts, Two), new Card(Suit.Diamonds, Three), new Card(Suit.Clubs, Four), new Card(Suit.Spades, Five) },
            // 9. 스트레이트
            new[] { new Card(Suit.Clubs, Eight), new Card(Suit.Spades, Jack), new Card(Suit.Spades, Nine), new Card(Suit.Clubs, Seven), new Card(Suit.Clubs, Ten) },
            // 10. 트리플
            new[] { new Card(Suit.Spades, Seven), new Card(Suit.Hearts, Seven), new Card(Suit.Diamonds, Seven), new Card(Suit.Clubs, Two), new Card(Suit.Spades, Nine) },
            // 11. 투 페어
            new[] { new Card(Suit.Clubs, Three), new Card(Suit.Diamonds, Nine), new Card(Suit.Clubs, Two), new Card(Suit.Clubs, Nine), new Card(Suit.Spades, Two) },
            // 12. 원 페어
            new[] { new Card(Suit.Spades, Nine), new Card(Suit.Hearts, Three), new Card(Suit.Clubs, Two), new Card(Suit.Diamonds, Five), new Card(Suit.Hearts, Nine) },
            // 13. 하이 카드
            new[] { new Card(Suit.Hearts, Eight), new Card(Suit.Clubs, Seven), new Card(Suit.Spades, King), new Card(Suit.Clubs, Six), new Card(Suit.Diamonds, Five) }
        };

        // 준비된 패의 개수 (Form1에서 순환 범위를 계산할 때 사용)
        public static int Count => Hands.Length;

        // index번째 패를 새 List로 복사해서 돌려준다.
        // 원본 배열이 외부에서 바뀌지 않도록 복사본을 반환한다.
        public static List<Card> GetHand(int index)
        {
            return new List<Card>(Hands[index]);
        }
    }
}