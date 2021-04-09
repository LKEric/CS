using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSon.Text);
            int m = int.Parse(txtSom.Text);
            int T = n + m;
            txtKetqua.Text = T.ToString();

        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSon.Text);
            int m = int.Parse(txtSom.Text);
            int T = n - m;
            txtKetqua.Text = T.ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSon.Text);
            int m = int.Parse(txtSom.Text);
            int T = n * m;
            txtKetqua.Text = T.ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSon.Text);
            int m = int.Parse(txtSom.Text);
            float T = (n*1.0f) / m;
            txtKetqua.Text = T.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtKetqua.Text = "";
            txtSom.Text = "";
            txtSon.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
