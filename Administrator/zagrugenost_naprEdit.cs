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
    public partial class zagrugenost_naprEdit : Form
    {
        public zagrugenost_naprEdit()
        {
            InitializeComponent();
        }

        private void zagrugenost_naprEdit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cuteBusDataSet.zagr_napr". При необходимости она может быть перемещена или удалена.
            this.zagr_naprTableAdapter.Fill(this.cuteBusDataSet.zagr_napr);

        }

        private void back_Click(object sender, EventArgs e)
        {
            zagrugenost_napr zagrugenost_Napr = new zagrugenost_napr();
            zagrugenost_Napr.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            zagr_naprBindingSource.MoveFirst();
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

        private void button7_Click(object sender, EventArgs e)
        {
            zagr_naprBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageRemove messageRemove = new MessageRemove();
            if (messageRemove.ShowDialog() == DialogResult.Yes)
            {
                zagr_naprBindingSource.RemoveCurrent();
            }
            else
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.zagr_naprBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cuteBusDataSet);
        }
    }
}
