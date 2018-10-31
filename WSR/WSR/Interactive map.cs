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
    public partial class Interactive_map : Form
    {
        public Interactive_map()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Bitmap image1 = new Bitmap("C://Users//Студент//Desktop//Новая папка (3)//Новая папка//map-icon-start.png");
            label3.Text = "Начало забега жалких людишек";
            pictureBox8.Image = image1;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Bitmap image1 = new Bitmap("C://Users//Студент//Desktop//Новая папка (3)//Новая папка//map-icon-toilets.png");
            label3.Text = "Здесь можно подстричься, но это не точно";
            pictureBox8.Image = image1;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Bitmap image1 = new Bitmap("C://Users//Студент//Desktop//Новая папка (3)//Новая папка//map-icon-medical.png");
            label3.Text = "Добрый доктор айболит вряд ли вылечит твой СПИД ";
            pictureBox8.Image = image1;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Bitmap image1 = new Bitmap("C://Users//Студент//Desktop//Новая папка (3)//Новая папка//map-icon-energy-bars.png");
            label3.Text = "Кушац надо? так вот тут есть";
            pictureBox8.Image = image1;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Bitmap image1 = new Bitmap("C://Users//Студент//Desktop//Новая папка (3)//Новая папка//map-icon-information.png");
            label3.Text = "Тут всякая никому не нужная информация";
            pictureBox8.Image = image1;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Bitmap image1 = new Bitmap("C://Users//Студент//Desktop//Новая папка (3)//Новая папка//map-icon-drinks.png");
            label3.Text = "Выпить или попить, да";
            pictureBox8.Image = image1;
        }
    }
}
