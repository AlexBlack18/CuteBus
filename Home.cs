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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            Program.home = this;
        }

        private void vuhod_Click(object sender, EventArgs e)
        {
            Exit_Form exit_Form = new Exit_Form();
            exit_Form.ShowDialog();
        }

        private void vhod_Click(object sender, EventArgs e)
        {
            Auth auth = new Auth();
            auth.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            About_Form about_Form = new About_Form();
            about_Form.ShowDialog();
        }
    }
}
