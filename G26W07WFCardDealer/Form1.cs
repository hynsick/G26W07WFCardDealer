namespace G26W07WFCardDealer
{
    public partial class Form1 : Form
    {
        private static readonly string[] Suits = ["spades", "hearts", "diamonds", "clubs"];
        private static readonly string[] Values = ["ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "jack", "queen", "king"];
        private readonly Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void OnDeal(object sender, EventArgs e)
        {
            List<string> deck = CreateDeck();
            List<string> hand = deck.OrderBy(x => random.Next()).Take(5).ToList();

            Card1.Image = GetCardImage(hand[0]);
            Card2.Image = GetCardImage(hand[1]);
            Card3.Image = GetCardImage(hand[2]);
            Card4.Image = GetCardImage(hand[3]);
            Card5.Image = GetCardImage(hand[4]);
        }

        private List<string> CreateDeck()
        {
            List<string> deck = new List<string>();
            foreach (string suit in Suits)
            {
                foreach (string value in Values)
                {
                    string suitName = value is "jack" or "queen" or "king" ? suit + "2" : suit;
                    deck.Add($"{value}_of_{suitName}");
                }
            }
            return deck;
        }

        private Image GetCardImage(string cardName)
        {
            return Properties.Resources.ResourceManager.GetObject(cardName) as Image
                   ?? Properties.Resources.red_joker;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }
    }
}
