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
    public partial class ClubOpr : Form
    {
        public ClubOpr()
        {
            InitializeComponent();
        }
        Sqlconnect conn = new Sqlconnect();
        public void liste()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Table_Club", conn.link());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void ClubOpr_Load(object sender, EventArgs e)
        {
            liste();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtClubID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtClubAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            liste();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Insert into Table_Club (ClubAd) values (@p1)",conn.link());
            cmd.Parameters.AddWithValue("@p1", txtClubAd.Text);
            cmd.ExecuteNonQuery();
            conn.link().Close();
            MessageBox.Show("Kulüp tabloya eklendi");

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete * from Table_Club where ClubID = @p1", conn.link());
            cmd.Parameters.AddWithValue("@p1",txtClubID.Text);
            cmd.ExecuteNonQuery();
            conn.link().Close();
            MessageBox.Show("Kulüp silindi");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Update Table_Club set ClubAd = @p1 where ClubID = @p2",conn.link());
            cmd.Parameters.AddWithValue("@p1", txtClubAd.Text);
            cmd.Parameters.AddWithValue("@p2", txtClubID.Text);
            cmd.ExecuteNonQuery();
            conn.link().Close();
            MessageBox.Show("Kulüp bilgileri güncellendi");
        }
    }
}
