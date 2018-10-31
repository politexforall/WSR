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
    public partial class ab : Form
    {
        public ab()
        {
            InitializeComponent();
        }

        DateTime voteTime = new DateTime(2018, 11, 24, 6, 0, 0);
        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan timeremaining = voteTime - DateTime.Now;
            toolStripStatusLabel1.Text = timeremaining.Days + " дней " + timeremaining.Hours + " часов и " + timeremaining.Minutes + " минут до старта марафона";

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Interactive_map inmap = new Interactive_map();
            this.Hide();
            inmap.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            about ab = new about();
            this.Hide(); ab.Show();
        }
    }
}
