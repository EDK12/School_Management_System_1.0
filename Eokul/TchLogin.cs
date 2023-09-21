using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eokul
{
    public partial class TchLogin : Form
    {
        public TchLogin()
        {
            InitializeComponent();
        }
        Sqlconnect conn = new Sqlconnect();
        private void loginbutton_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from Table_Teacher Where OgrtAdSoyad = @p1 and OgrtSifre = @p2", conn.link());
            cmd.Parameters.AddWithValue("@p1", tchAd.Text);
            cmd.Parameters.AddWithValue("@p2", tchPw.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                TchDetails tcd = new TchDetails();
                tcd.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı adı veya şifre girdiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.link().Close();
        }

        private void Pwsee_Click(object sender, EventArgs e)
        {
            bool durum = tchPw.UseSystemPasswordChar;
            if (durum)
            {
                tchPw.UseSystemPasswordChar = false;
                Pwsee.Text = "Şifreyi Gösterme";
            }
            else
            {
                tchPw.UseSystemPasswordChar = true;
                Pwsee.Text = "Şifreyi göster";
            }
        }
    }
}
