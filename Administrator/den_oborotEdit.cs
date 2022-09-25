using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuteBus.Administrator
{
    public partial class den_oborotEdit : Form
    {
        public den_oborotEdit()
        {
            InitializeComponent();
        }

        private void den_oborotEdit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cuteBusDataSet.denegnuy_oborot". При необходимости она может быть перемещена или удалена.
            this.denegnuy_oborotTableAdapter.Fill(this.cuteBusDataSet.denegnuy_oborot);

        }

        private void back_Click(object sender, EventArgs e)
        {
            den_oborot den_Oborot = new den_oborot();
            den_Oborot.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            denegnuy_oborotBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            denegnuy_oborotBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            denegnuy_oborotBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            denegnuy_oborotBindingSource.MoveLast();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            denegnuy_oborotBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageRemove messageRemove = new MessageRemove();
            if (messageRemove.ShowDialog() == DialogResult.Yes)
            {
                denegnuy_oborotBindingSource.RemoveCurrent();
            }
            else
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.denegnuy_oborotBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cuteBusDataSet);
        }
    }
}
