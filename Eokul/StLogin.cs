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
    public partial class StLogin : Form
    {
        public StLogin()
        {
            InitializeComponent();
        }
        Sqlconnect conn = new Sqlconnect();
        private void loginbutton_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from Table_St Where stAdSoyad = @p1 and stNumber = @p2", conn.link());
            cmd.Parameters.AddWithValue("@p1", stAd.Text);
            cmd.Parameters.AddWithValue("@p2", stPw.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                StDetails std = new StDetails();
                std.numara = txtID.Text;
                std.Show();
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
            bool durum = stPw.UseSystemPasswordChar;
            if (durum)
            {
                stPw.UseSystemPasswordChar = false;
                Pwsee.Text = "Şifreyi Gösterme";
            }
            else
            {
                stPw.UseSystemPasswordChar = true;
                Pwsee.Text = "Şifreyi göster";
            }
        }

        private void ErrorLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
