using System.Xml.Linq;

namespace G26W07WFCardDealer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void OnDeal(object sender, EventArgs e)
        {
            String name = "10_of_clubs";
           
            Card1.Image = Properties.Resources.ResourceManager
               .GetObject(name) as Image
               ?? Properties.Resources.red_joker;
        }
    }
}

