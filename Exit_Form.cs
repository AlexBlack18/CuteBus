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
    public partial class Exit_Form : Form
    {
        public Exit_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.home.Hide();
            this.Hide();
            Goodbye goodbye = new Goodbye();
            goodbye.ShowDialog();
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
