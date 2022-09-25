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
    public partial class voditelEdit : Form
    {
        public voditelEdit()
        {
            InitializeComponent();
        }

        private void voditelEdit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cuteBusDataSet.voditel". При необходимости она может быть перемещена или удалена.
            this.voditelTableAdapter.Fill(this.cuteBusDataSet.voditel);

        }

        private void back_Click(object sender, EventArgs e)
        {
            voditeli voditeli = new voditeli();
            voditeli.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            voditelBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            voditelBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            voditelBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            voditelBindingSource.MoveLast();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            voditelBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageRemove messageRemove = new MessageRemove();
            if (messageRemove.ShowDialog() == DialogResult.Yes)
            {
                voditelBindingSource.RemoveCurrent();
            }
            else
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.voditelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cuteBusDataSet);
        }
    }
}
