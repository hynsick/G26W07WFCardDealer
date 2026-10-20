using System;
using System.Collections.Generic;
using System.Text;

namespace G26W07WFCardDealer
{
    internal class CheckCard
    {
        public static string Evaluate(List<Card> hand)
        {
            // 오름차순 정렬
            List<int> ranks = hand.Select(c => (int)c.Rank).OrderBy(r => r).ToList();

            // 플러시 체크 (모두 같은 무늬인지 확인)
            bool isFlush = true;
            Suit firstSuit = hand[0].Suit;
            foreach (var card in hand)
            {
                if (card.Suit != firstSuit) isFlush = false;
            }

            // 스트레이트 체크
            bool isWheel = ranks[0] == 2 && ranks[1] == 3 && ranks[2] == 4 && ranks[3] == 5 && ranks[4] == 14;
            bool isStraight = isWheel || (ranks.Distinct().Count() == 5 && ranks[4] - ranks[0] == 4);
            bool isRoyal = isStraight && ranks[0] == 10;

            // 숫자별 개수를 세는 1차원 배열 (인덱스 2~14 사용)
            int[] counts = new int[15];
            foreach (var card in hand)
            {
                counts[(int)card.Rank]++;
            }

            int fourCardCount = 0;
            int tripleCount = 0;
            int pairCount = 0;

            // 배열을 돌며 포카드, 트리플, 페어 개수 집계
            for (int i = 2; i <= 14; i++)
            {
                if (counts[i] == 4) fourCardCount++;
                if (counts[i] == 3) tripleCount++;
                if (counts[i] == 2) pairCount++;
            }

            // 족보 반환
            if (isStraight && isFlush)
            {
                if (isRoyal) return "로열 스트레이트 플러시";
                if (isWheel) return "백스트레이트 플러시";
                return "스트레이트 플러시";
            }
            if (fourCardCount == 1) return "포카드";
            if (tripleCount == 1 && pairCount == 1) return "풀하우스";
            if (isFlush) return "플러시";
            if (isRoyal) return "마운틴";
            if (isWheel) return "백스트레이트";
            if (isStraight) return "스트레이트";
            if (tripleCount == 1) return "트리플";
            if (pairCount == 2) return "투 페어";
            if (pairCount == 1) return "원 페어";

            return "하이 카드";
        }
    }
}
