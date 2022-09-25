﻿using System;
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
    public partial class passagiropotokiEdit : Form
    {
        public passagiropotokiEdit()
        {
            InitializeComponent();
        }

        private void passagiropotokiEdit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cuteBusDataSet.passagiropotoki". При необходимости она может быть перемещена или удалена.
            this.passagiropotokiTableAdapter.Fill(this.cuteBusDataSet.passagiropotoki);

        }

        private void back_Click(object sender, EventArgs e)
        {
            passagiropotoki passagiropotoki = new passagiropotoki();
            passagiropotoki.Show();
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

        private void button7_Click(object sender, EventArgs e)
        {
            passagiropotokiBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageRemove messageRemove = new MessageRemove();
            if (messageRemove.ShowDialog() == DialogResult.Yes)
            {
                passagiropotokiBindingSource.RemoveCurrent();
            }
            else
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.passagiropotokiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cuteBusDataSet);
        }
    }
}
