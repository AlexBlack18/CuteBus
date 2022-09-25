using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CuteBus
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
            Program.auth_form = this;
        }

        private void auth_btn_Click(object sender, EventArgs e)
        {
            string type;
            using (SqlConnection sqlcon = new SqlConnection(@"Data Source=ALEX-NOTEBOOK\SQLEXPRESS;Initial Catalog=CuteBus;Integrated Security=True"))
            {
                sqlcon.Open();

                SqlCommand command = new SqlCommand("Select [type] FROM [Auth] WHERE login = @login and password = @password", sqlcon);
                command.Parameters.AddWithValue("@login", login.Text);
                command.Parameters.AddWithValue("@password", password.Text);
                type = (string)command.ExecuteScalar();
            }

            if (type == "Admin")
            {
                MessageAuth messageAuth = new MessageAuth();
                messageAuth.ShowDialog();
                this.Hide();
                Admin admf = new Admin();
                admf.Show();
            }
            else if (type == "Voditel")
            {
                MessageAuth messageAuth = new MessageAuth();
                messageAuth.ShowDialog();
                this.Hide();
                Vodila usf = new Vodila();
                usf.Show();
            }
            else if (type == "Conductor")
            {
                MessageAuth messageAuth = new MessageAuth();
                messageAuth.ShowDialog();
                this.Hide();
                Conductor meneger = new Conductor();
                meneger.Show();
            }
            else
            {
                LoginError loginError = new LoginError();
                loginError.ShowDialog();
                login.Clear();
                password.Clear();
                login.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            password.Focus();
            if (checkBox1.Checked)
            {
                password.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
            }
        }
    }
}
