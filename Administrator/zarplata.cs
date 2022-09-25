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
    public partial class zarplata : Form
    {
        public zarplata()
        {
            InitializeComponent();
        }

        private void zarplataBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.zarplataBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cuteBusDataSet);

        }

        private void zarplata_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cuteBusDataSet.zarplata". При необходимости она может быть перемещена или удалена.
            this.zarplataTableAdapter.Fill(this.cuteBusDataSet.zarplata);

        }

        private void back_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            zarplataBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            zarplataBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            zarplataBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            zarplataBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            zarplataEdit zarplataEdit = new zarplataEdit();
            zarplataEdit.Show();
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
                zarplataDataGridView.Sort(COL,
               System.ComponentModel.ListSortDirection.Ascending);
            else
                zarplataDataGridView.Sort(COL,
               System.ComponentModel.ListSortDirection.Descending);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            zarplataBindingSource.Filter = "id сотрудника='" + comboBox1.Text + "'";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            zarplataBindingSource.Filter = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < zarplataDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < zarplataDataGridView.RowCount - 1; j++)
                {
                    zarplataDataGridView[i, j].Style.BackColor = Color.White;
                    zarplataDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }
            for (int i = 0; i < zarplataDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < zarplataDataGridView.RowCount - 1; j++)
                {
                    if (zarplataDataGridView[i,
                   j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        zarplataDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        zarplataDataGridView[i, j].Style.ForeColor = Color.Blue;

                    }
                }
            }
        }
    }
}
