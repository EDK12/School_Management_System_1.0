using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eokul
{
    public partial class Page : Form
    {
        public Page()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StLogin st = new StLogin();
            st.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TchLogin tch = new TchLogin();
            tch.Show();
            this.Hide();
        }
    }
}
