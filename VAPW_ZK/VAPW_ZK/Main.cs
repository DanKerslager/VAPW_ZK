using System.Media;
using System.Windows.Forms;
using System.Xml.Schema;

namespace VAPW_ZK
{
    public partial class Main : Form
    {
        public List<int> ints;
        public Dictionary<Hrac, int> scores;
        public Dictionary<Hrac, int> numbers;

        public Main()
        {
            InitializeComponent();
            this.scores = new Dictionary<Hrac, int>();
            this.numbers = new Dictionary<Hrac, int>();

            dataGridView1.Columns[0].Name = "Player";
            dataGridView1.Columns[1].Name = "Score";

            newPlayer();
            newPlayer();
            newPlayer();
        }

        public void newPlayer()
        {
            Hrac newPlay = new Hrac();
            this.scores[newPlay] = 0;
            this.numbers[newPlay] = 0;
            newPlay.Show();
            //Players.Add(player);
            newPlay.OnClickHandler += checkNum;
            newPlay.NumberChange += changeNum;
            newPlay.OnNameHandler += refreshGrid;
            newPlay.newPlay += newPlayer;
            refreshGrid();
        }

        private void checkNum(Hrac sender, int number)
        {
            bool found = false;
            foreach (var item in this.numbers)
            {
                if (item.Value == number && item.Key != sender) { found = true; break; }
            }
            if (found) {
                this.scores[sender] += 1;

            }
            else
            {
                this.scores[sender] -= 1;
            }
            sender.setScore(this.scores[sender]);
            refreshGrid();
        }


        private void refreshGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (var game in this.scores)
            {
                dataGridView1.Rows.Add(game.Key.Name, game.Value);
            }
        }

        private void changeNum(Hrac sender, int number)
        {
            this.numbers[sender] = number;
        }
    }
}
