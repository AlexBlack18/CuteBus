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
    public partial class premia : Form
    {
        public premia()
        {
            InitializeComponent();
        }

        private void premiaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.premiaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cuteBusDataSet);

        }

        private void premia_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cuteBusDataSet.premia". При необходимости она может быть перемещена или удалена.
            this.premiaTableAdapter.Fill(this.cuteBusDataSet.premia);

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

        private void back_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            premiaEdit premiaEdit = new premiaEdit();
            premiaEdit.Show();
            this.Close();
        }
    }
}
