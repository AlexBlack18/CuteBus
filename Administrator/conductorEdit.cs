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
    public partial class conductorEdit : Form
    {
        public conductorEdit()
        {
            InitializeComponent();
        }

        private void conductorEdit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cuteBusDataSet.conductor". При необходимости она может быть перемещена или удалена.
            this.conductorTableAdapter.Fill(this.cuteBusDataSet.conductor);

        }

        private void back_Click(object sender, EventArgs e)
        {
            conductor conductor = new conductor();
            conductor.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conductorBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conductorBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conductorBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conductorBindingSource.MoveLast();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            conductorBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageRemove messageRemove = new MessageRemove();
            if (messageRemove.ShowDialog() == DialogResult.Yes)
            {
                conductorBindingSource.RemoveCurrent();
            }
            else
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.conductorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cuteBusDataSet);
        }
    }
}
