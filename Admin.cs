using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuteBus
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Auth auth = new Auth();
            auth.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Administrator.passagiropotoki passagiropotoki = new Administrator.passagiropotoki();
            passagiropotoki.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Administrator.zagrugenost_napr zagrugenost_Napr = new Administrator.zagrugenost_napr();
            zagrugenost_Napr.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Administrator.zagrugenost_rey zagrugenost = new Administrator.zagrugenost_rey();
            zagrugenost.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Administrator.den_oborot den_Oborot = new Administrator.den_oborot();
            den_Oborot.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Administrator.voditeli voditeli  = new Administrator.voditeli();
            voditeli.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Administrator.conductor conductor = new Administrator.conductor();
            conductor.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Administrator.zarplata zarplata = new Administrator.zarplata();
            zarplata.Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Administrator.premia premia = new Administrator.premia();
            premia.Show();
            this.Close();
        }
    }
}
