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
    public partial class zagrugenost_rey : Form
    {
        public zagrugenost_rey()
        {
            InitializeComponent();
        }

        private void zagr_reysovBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.zagr_reysovBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cuteBusDataSet);

        }

        private void zagrugenost_rey_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cuteBusDataSet.zagr_reysov". При необходимости она может быть перемещена или удалена.
            this.zagr_reysovTableAdapter.Fill(this.cuteBusDataSet.zagr_reysov);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            zagr_reysovBindingSource.MoveFirst();
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
            zagr_reysovBindingSource.MoveLast();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            zagrugenost_reyEdit zagrugenost_ReyEdit = new zagrugenost_reyEdit();
            zagrugenost_ReyEdit.Show();
            this.Close();
        }

        private System.Windows.Forms.DataGridViewColumn COL;

        private void button6_Click(object sender, EventArgs e)
        {
            COL = new System.Windows.Forms.DataGridViewColumn();

            switch (listBox1.SelectedIndex)
            {
                case 0:
                    COL = dataGridViewTextBoxColumn1;
                    break;
                case 1:
                    COL = dataGridViewTextBoxColumn2;
                    break;
                case 2:
                    COL = dataGridViewTextBoxColumn3;
                    break;
            }
            if (radioButton1.Checked)
                zagr_reysovDataGridView.Sort(COL,
               System.ComponentModel.ListSortDirection.Ascending);
            else
                zagr_reysovDataGridView.Sort(COL,
               System.ComponentModel.ListSortDirection.Descending);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            zagr_reysovBindingSource.Filter = "рейс='" + comboBox1.Text + "'";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            zagr_reysovBindingSource.Filter = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < zagr_reysovDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < zagr_reysovDataGridView.RowCount - 1; j++)
                {
                    zagr_reysovDataGridView[i, j].Style.BackColor = Color.White;
                    zagr_reysovDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }
            for (int i = 0; i < zagr_reysovDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < zagr_reysovDataGridView.RowCount - 1; j++)
                {
                    if (zagr_reysovDataGridView[i,
                   j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        zagr_reysovDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        zagr_reysovDataGridView[i, j].Style.ForeColor = Color.Blue;

                    }
                }
            }
        }
    }
}
