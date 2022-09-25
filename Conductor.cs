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
    public partial class Conductor : Form
    {
        public Conductor()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Auth auth = new Auth();
            auth.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cond.zagr_rey zagr_Rey = new cond.zagr_rey();
            zagr_Rey.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cond.den_oborot den_Oborot = new cond.den_oborot();
            den_Oborot.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cond.passagirpot passagirpot = new cond.passagirpot();
            passagirpot.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cond.zag_napr zag_Napr = new cond.zag_napr();
            zag_Napr.Show();
            this.Close();
        }
    }
}
