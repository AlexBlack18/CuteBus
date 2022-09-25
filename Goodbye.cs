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
    public partial class Goodbye : Form
    {
        public Goodbye()
        {
            InitializeComponent();
        }

        private void Goodbye_Load(object sender, EventArgs e)
        {
            t = new Timer();
            t.Interval = 1 * 1000;
            t.Tick += new EventHandler(onTick);
            t.Enabled = true;
        }

        private Timer t;
        void onTick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
