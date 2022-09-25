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
    public partial class conductor : Form
    {
        public conductor()
        {
            InitializeComponent();
        }

        private void conductorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.conductorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cuteBusDataSet);

        }

        private void conductor_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cuteBusDataSet.conductor". При необходимости она может быть перемещена или удалена.
            this.conductorTableAdapter.Fill(this.cuteBusDataSet.conductor);

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

        private void back_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            conductorEdit conductorEdit = new conductorEdit();
            conductorEdit.Show();
            this.Close();
        }
    }
}
