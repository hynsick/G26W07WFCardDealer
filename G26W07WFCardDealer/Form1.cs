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
        // 테스트용 
        // 현재 화면에 보여 주는 패의 번호 (-1은 아직 아무것도 보여 주지 않은 상태)
        private int previewIndex = -1;

        // CheckCardTest의 index번째 패를 화면에 표시한다. (실행 화면 캡처용)
        // 범위를 벗어나면 처음/끝으로 돌아가도록 나머지 연산을 사용한다.
        private void ShowPreviewHand(int index)
        {
            previewIndex = (index + CheckCardTest.Count) % CheckCardTest.Count;

            // 로직: 정해 둔 패를 가져온다.
            List<Card> hand = CheckCardTest.GetHand(previewIndex);

            // 뷰: 카드 이미지를 5개의 PictureBox에 표시한다.
            Card1.Image = GetCardImage(hand[0]);
            Card2.Image = GetCardImage(hand[1]);
            Card3.Image = GetCardImage(hand[2]);
            Card4.Image = GetCardImage(hand[3]);
            Card5.Image = GetCardImage(hand[4]);

            // 로직 호출: 판별 결과를 라벨에 표시한다.
            ResultLabel.Text = CheckCard.Evaluate(hand);
        }

        // 방향키 입력을 폼 전체에서 받는다.
        // 버튼에 포커스가 있어도 방향키가 포커스 이동에 쓰이지 않도록 ProcessCmdKey를 사용한다.
        // →: 다음 족보, ←: 이전 족보, Home: 첫 번째 족보
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Right)
            {
                ShowPreviewHand(previewIndex + 1);
                return true;
            }
            if (keyData == Keys.Left)
            {
                // 아직 시작 전(-1)이면 마지막 족보부터 보여 준다.
                ShowPreviewHand(previewIndex < 0 ? CheckCardTest.Count - 1 : previewIndex - 1);
                return true;
            }
            if (keyData == Keys.Home)
            {
                ShowPreviewHand(0);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
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