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
    public partial class Zagr_napr_table : Form
    {
        public Zagr_napr_table()
        {
            InitializeComponent();
        }

        private void zagr_naprBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.zagr_naprBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cuteBusDataSet);

        }

        private void Zagr_napr_table_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cuteBusDataSet.zagr_napr". При необходимости она может быть перемещена или удалена.
            this.zagr_naprTableAdapter.Fill(this.cuteBusDataSet.zagr_napr);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            zagr_naprBindingSource.MoveLast();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            zagr_naprBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            zagr_naprBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            zagr_naprBindingSource.MoveLast();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Vodila voditel = new Vodila();
            voditel.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Zagr_napr zagr_Napr = new Zagr_napr();
            zagr_Napr.Show();
            this.Close();
        }
    }
}
