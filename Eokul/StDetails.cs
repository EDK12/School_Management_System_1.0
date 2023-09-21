using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eokul
{
    public partial class StDetails : Form
    {
        public StDetails()
        {
            InitializeComponent();
        }
        public string numara;
        Sqlconnect conn = new Sqlconnect();
        private void StDetails_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select DersAd,Sınav1,Sınav2,Sınav3,Proje,Ort,Durum from Table_Not Inner Join Table_Ders on Table_Not.DersID = Table_Ders.DersID where StID = @p1", conn.link());
            cmd.Parameters.AddWithValue("@p1", numara);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
