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
    public partial class MessageRemove : Form
    {
        public MessageRemove()
        {
            InitializeComponent();
            Program.f1 = this;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }
    }
}
