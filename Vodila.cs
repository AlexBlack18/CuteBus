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
    public partial class Vodila : Form
    {
        public Vodila()
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
            Voditel.Zagr_napr_table zagr = new Voditel.Zagr_napr_table();
            zagr.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Voditel.Zagr_reysov_table zagr = new Voditel.Zagr_reysov_table();
            zagr.Show();
            this.Close();
        }
    }
}
