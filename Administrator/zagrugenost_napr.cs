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
    public partial class zagrugenost_napr : Form
    {
        public zagrugenost_napr()
        {
            InitializeComponent();
        }

        private void zagr_naprBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.zagr_naprBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cuteBusDataSet);

        }

        private void zagrugenost_napr_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cuteBusDataSet.zagr_napr". При необходимости она может быть перемещена или удалена.
            this.zagr_naprTableAdapter.Fill(this.cuteBusDataSet.zagr_napr);

        }

        private void back_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
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

        private void button5_Click(object sender, EventArgs e)
        {
            zagrugenost_naprEdit zagrugenost_NaprEdit = new zagrugenost_naprEdit();
            zagrugenost_NaprEdit.Show();
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
                zagr_naprDataGridView.Sort(COL,
               System.ComponentModel.ListSortDirection.Ascending);
            else
                zagr_naprDataGridView.Sort(COL,
               System.ComponentModel.ListSortDirection.Descending);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            zagr_naprBindingSource.Filter = "рейс='" + comboBox1.Text + "'";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < zagr_naprDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < zagr_naprDataGridView.RowCount - 1; j++)
                {
                    zagr_naprDataGridView[i, j].Style.BackColor = Color.White;
                    zagr_naprDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }
            for (int i = 0; i < zagr_naprDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < zagr_naprDataGridView.RowCount - 1; j++)
                {
                    if (zagr_naprDataGridView[i,
                   j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        zagr_naprDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        zagr_naprDataGridView[i, j].Style.ForeColor = Color.Blue;

                    }
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            zagr_naprBindingSource.Filter = "";
        }
    }
}
