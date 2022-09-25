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
    public partial class Hello : Form
    {
        public Hello()
        {
            InitializeComponent();
        }

        private void Hello_Load(object sender, EventArgs e)
        {
            t = new Timer();
            t.Interval = 1 * 1000;
            t.Tick += new EventHandler(newClick);
            t.Enabled = true;
        }
        private Timer t;
        void newClick(object sender, EventArgs e)
        {
            button1.PerformClick();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
        }
    }
}
