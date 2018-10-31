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
    public partial class CoordinatorForm : Form
    {
        public CoordinatorForm()
        {
            InitializeComponent();
        }

        DateTime voteTime = new DateTime(2018, 11, 24, 6, 0, 0);
        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan timeremaining = voteTime - DateTime.Now;
            toolStripStatusLabel1.Text = timeremaining.Days + " дней " + timeremaining.Hours + " часов и " + timeremaining.Minutes + " минут до старта марафона";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide(); f1.Show();
        }
    }
}
