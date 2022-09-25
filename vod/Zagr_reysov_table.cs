using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuteBus.Voditel
{
    public partial class Zagr_reysov_table : Form
    {
        public Zagr_reysov_table()
        {
            InitializeComponent();
        }

        private void zagr_reysovBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.zagr_reysovBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cuteBusDataSet);

        }

        private void Zagr_reysov_table_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cuteBusDataSet.zagr_reysov". При необходимости она может быть перемещена или удалена.
            this.zagr_reysovTableAdapter.Fill(this.cuteBusDataSet.zagr_reysov);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            zagr_reysovBindingSource.MoveLast();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            zagr_reysovBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            zagr_reysovBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            zagr_reysovBindingSource.MoveFirst();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Vodila voditel = new Vodila();
            voditel.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Zagr_reysov zagr_Reysov = new Zagr_reysov();
            zagr_Reysov.Show();
            this.Close();
        }
    }
}
