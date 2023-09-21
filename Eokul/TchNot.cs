using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eokul
{
    public partial class TchNot : Form
    {
        public TchNot()
        {
            InitializeComponent();
        }
        DataSetNotTableAdapters.Table_NotTableAdapter ds = new DataSetNotTableAdapters.Table_NotTableAdapter();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.NotEkle(byte.Parse(txtDersId.Text),Convert.ToInt16(txtStNo.Text),byte.Parse(txtE1.Text), byte.Parse(txtE2.Text), byte.Parse(txtE3.Text), byte.Parse(txtP.Text),Convert.ToDecimal(txtOrt.Text), checkBox1.Checked);
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.NotListesi();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.NotSil(byte.Parse(txtNotID.Text));
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.NotUpdate(byte.Parse(txtDersId.Text), Convert.ToInt16(txtStNo.Text), byte.Parse(txtE1.Text), byte.Parse(txtE2.Text), byte.Parse(txtE3.Text), byte.Parse(txtP.Text), Convert.ToDecimal(txtOrt.Text), checkBox1.Checked, Convert.ToInt32(txtNotID.Text));
        }
        double Calc()
        {
            double ort;
            int Sınav1 = Convert.ToInt32(txtE1.Text);
            int Sınav2 = Convert.ToInt32(txtE2.Text);
            int Sınav3 = Convert.ToInt32(txtE3.Text);
            int Proje = Convert.ToInt32(txtP.Text);
            ort = ((Sınav1 + Sınav2 + Sınav3) / 3) * 0.8 + Proje * 0.2;
            return ort;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            txtOrt.Text = Calc().ToString();
        }

        private void TchNot_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.NotListesi();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNotID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtDersId.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtStNo.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtE1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtE2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtE3.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtP.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtOrt.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            checkBox1.Checked = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[8]);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
