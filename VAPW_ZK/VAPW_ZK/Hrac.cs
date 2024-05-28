using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VAPW_ZK
{
    public partial class Hrac : Form
    {
        public int number = 0;
        private System.Windows.Forms.Timer timer;
        Random random = new Random();
        public String Name = "hrac";

        public Hrac()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Tick += ChangeNum;
            timer1.Enabled = true;
            Score_text.Text = "0";
        }

        public void setScore(int score)
        {
            Score_text.Text = score.ToString();
        }

        public delegate void NumberHandler(Hrac sender, int num);
        public event NumberHandler NumberChange;

        private void ChangeNum(object sender, EventArgs e)
        {
            number = random.Next(1, 10);
            this.NumberChange?.Invoke(this, number);
            Num_text.Text = number.ToString();
        }


        public delegate void clickHandler(Hrac sender, int num);
        public event clickHandler OnClickHandler;

        private void button1_Click(object sender, EventArgs e)
        {
            this.OnClickHandler?.Invoke(this, number);
        }


        public delegate void nameHandler();
        public event nameHandler OnNameHandler;

        private void gameName_TextChanged(object sender, EventArgs e)
        {
            Name = gameName.Text;
            this.OnNameHandler?.Invoke();

        }

        public delegate void newPlayHandler();
        public event newPlayHandler newPlay;

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.newPlay?.Invoke();

        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            timer1.Interval = 100 * (int)numericUpDown1.Value;
        }
    }
}
