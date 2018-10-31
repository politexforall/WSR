using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Tick += timer1_Tick;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Start();
            label2.Text = "Москва, Россия\n"+DateTime.Now.ToShortDateString();
        }
        DateTime voteTime = new DateTime(2018, 11, 24, 6, 0, 0); 

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan timeremaining = voteTime - DateTime.Now;
            label3.Text = timeremaining.Days + " дней " + timeremaining.Hours + " часов и " + timeremaining.Minutes + " минут до старта марафона";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            about ab = new about();
            ab.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            reg rg = new reg();
            this.Hide();
            rg.ShowDialog();
           //eiftjsd0figjdsoifsdf
        }

        public void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            quest que = new quest();
           this.Hide();que.ShowDialog();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
