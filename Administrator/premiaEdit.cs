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
    public partial class premiaEdit : Form
    {
        public premiaEdit()
        {
            InitializeComponent();
        }

        private void premiaEdit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cuteBusDataSet.premia". При необходимости она может быть перемещена или удалена.
            this.premiaTableAdapter.Fill(this.cuteBusDataSet.premia);

        }

        private void back_Click(object sender, EventArgs e)
        {
            premia premia = new premia();
            premia.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            premiaBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            premiaBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            premiaBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            premiaBindingSource.MoveLast();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            premiaBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageRemove messageRemove = new MessageRemove();
            if (messageRemove.ShowDialog() == DialogResult.Yes)
            {
                premiaBindingSource.RemoveCurrent();
            }
            else
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.premiaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cuteBusDataSet);
        }
    }
}
