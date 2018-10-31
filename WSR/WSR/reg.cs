using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSR
{
    public partial class reg : Form
    {
        public reg()
        {
            InitializeComponent();
      
        }

        private void reg_Load(object sender, EventArgs e)
        {
            textBox2.Text = "Enter your email";
            textBox2.ForeColor = Color.Gray;
            textBox3.Text = "Enter your password";
            textBox3.ForeColor = Color.Gray;
            
        }
        DateTime voteTime = new DateTime(2018, 12, 1, 8, 20, 0);

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan timeremaining = voteTime - DateTime.Now;
            toolStripStatusLabel1.Text = timeremaining.Days + " дней " + timeremaining.Hours + " часов и " + timeremaining.Minutes + " минут до сдачи курсача";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.Text = null;
            textBox2.ForeColor = Color.Black;
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            textBox3.Text = null;
            textBox3.ForeColor = Color.Black;
            textBox3.UseSystemPasswordChar = true;

        }
       
        enum Role {Failed,R,C,A }
      
        static Role GetRole(string login,string password)
        {
            Role role = Role.Failed;
            using (var connection = new SqlConnection("Data Source=ПК-09-К319;Initial Catalog=WSR;Trusted_Connection=Yes;"))
            {
                connection.Open();
                var command = new SqlCommand("Select RoleId from users where email=@email and password=@password", connection);
                command.Parameters.AddWithValue("@email", login);
                command.Parameters.AddWithValue("@password", password);
                using (var dataReader = command.ExecuteReader())
                {
                    if (dataReader.Read())
                    {
                        if ((string)dataReader["Roleid"] == "R")
                        {
                            role = Role.R;
                        }
                        if ((string)dataReader["Roleid"] == "A")
                        {
                            role = Role.A;
                        }
                        if ((string)dataReader["Roleid"] == "C")
                        {
                            role = Role.C;
                        }


                    }
                }
                return role;
            }
        }
        private void login()
        {
            Role role = GetRole(textBox2.Text, textBox3.Text);
            if (role == Role.Failed)
            {
                MessageBox.Show("Неверный логин или пароль", MessageBoxIcon.Error.ToString(),MessageBoxButtons.OK);
            }
            else
            {
                if (role == Role.A)
                {
                    var form = new AdminForm();
                    form.ShowDialog();
                    this.Hide();
                }
                else if (role == Role.C)
                {
                    var form = new CoordinatorForm();
                    form.ShowDialog();
                    this.Hide();
                }
                else if (role == Role.R)
                {
                    var form = new RunnerForm();
                    form.ShowDialog();
                    this.Hide();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            login();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = "Enter your email";
            textBox2.ForeColor = Color.Gray;
            textBox3.Text = "Enter your password";
            textBox3.ForeColor = Color.Gray;
        }

        private void reg_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
