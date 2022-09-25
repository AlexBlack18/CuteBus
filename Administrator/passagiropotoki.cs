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
    public partial class passagiropotoki : Form
    {
        public passagiropotoki()
        {
            InitializeComponent();
        }

        private void passagiropotokiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.passagiropotokiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cuteBusDataSet);

        }

        private void passagiropotoki_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cuteBusDataSet.passagiropotoki". При необходимости она может быть перемещена или удалена.
            this.passagiropotokiTableAdapter.Fill(this.cuteBusDataSet.passagiropotoki);

        }

        private void back_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            passagiropotokiBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            passagiropotokiBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            passagiropotokiBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            passagiropotokiBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            passagiropotokiEdit passagiropotokiEdit = new passagiropotokiEdit();
            passagiropotokiEdit.Show();
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
                case 3:
                    COL = dataGridViewTextBoxColumn4;
                    break;
                case 4:
                    COL = dataGridViewTextBoxColumn5;
                    break;
            }
            if (radioButton1.Checked)
                passagiropotokiDataGridView.Sort(COL,
               System.ComponentModel.ListSortDirection.Ascending);
            else
                passagiropotokiDataGridView.Sort(COL,
               System.ComponentModel.ListSortDirection.Descending);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            passagiropotokiBindingSource.Filter = "колличество пассажиров='" + comboBox1.Text + "'";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            passagiropotokiBindingSource.Filter = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < passagiropotokiDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < passagiropotokiDataGridView.RowCount - 1; j++)
                {
                    passagiropotokiDataGridView[i, j].Style.BackColor = Color.White;
                    passagiropotokiDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }
            for (int i = 0; i < passagiropotokiDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < passagiropotokiDataGridView.RowCount - 1; j++)
                {
                    if (passagiropotokiDataGridView[i,
                   j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        passagiropotokiDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        passagiropotokiDataGridView[i, j].Style.ForeColor = Color.Blue;

                    }
                }
            }
        }
    }
}
