using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Eokul
{
    public partial class TchOpr : Form
    {
        public TchOpr()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.Table_DersTableAdapter ds = new DataSet1TableAdapters.Table_DersTableAdapter();
        private void TchOpr_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = ds.DersListesi();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.DersListesi();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.DersEkle(txtClubAd.Text);
            MessageBox.Show("Ders başarıyla eklendi");
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            ds.DersSil(byte.Parse(txtClubID.Text));
            MessageBox.Show("Ders silindi");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ds.DersUpdate(txtClubAd.Text, byte.Parse(txtClubID.Text));
            MessageBox.Show("Ders güncellendi");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtClubID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtClubAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
