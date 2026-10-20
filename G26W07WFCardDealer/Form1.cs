using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using G26W07WFCardDealer; // 분리한 로직 사용

namespace G26W07WFCardDealer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OnDeal(object sender, EventArgs e)
        {
            // 1. 덱 생성 및 5장 뽑기 (로직)
            Deck deck = new Deck();
            List<Card> hand = deck.Draw(5);

            // 2. 화면에 카드 이미지 띄우기 (뷰)
            Card1.Image = GetCardImage(hand[0]);
            Card2.Image = GetCardImage(hand[1]);
            Card3.Image = GetCardImage(hand[2]);
            Card4.Image = GetCardImage(hand[3]);
            Card5.Image = GetCardImage(hand[4]);

            // 3. 결과 라벨 업데이트 (로직 호출)
            ResultLabel.Text = CheckCard.Evaluate(hand);
        }

        // 비즈니스 로직의 Card 객체를 화면 리소스 이름으로 매핑하는 View 고유 함수
        private Image GetCardImage(Card card)
        {
            string suitName = card.Suit.ToString().ToLower();
            string rankName = card.Rank switch
            {
                Rank.Ace => "ace",
                Rank.Jack => "jack",
                Rank.Queen => "queen",
                Rank.King => "king",
                _ => ((int)card.Rank).ToString()
            };

            // 리소스 이미지 이름 규칙 예외 처리 (J, Q, K는 무늬 뒤에 2가 붙음)
            if (card.Rank == Rank.Jack || card.Rank == Rank.Queen || card.Rank == Rank.King)
            {
                suitName += "2";
            }

            string resourceName = $"{rankName}_of_{suitName}";

            return Properties.Resources.ResourceManager.GetObject(resourceName) as Image
                   ?? Properties.Resources.red_joker;
        }

    }
}