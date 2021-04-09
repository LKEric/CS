using System;
using System.Windows.Forms;

namespace Lab03
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public void UCLN()
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a = a - b;
                else b = b - a;

            }
            if (a == 0)
                txtKq.Text = b.ToString();
            else
                txtKq.Text = a.ToString();
        }
        public void BSCNN()
        {
            int n1 = int.Parse(txtA.Text);
            int n2 = int.Parse(txtB.Text);
            int bscnn, hcf = 1;
            int j = (n1 < n2) ? n1 : n2;

            for (int i = 1; i <= j; i++)
            {

                if (n1 % i == 0 && n2 % i == 0)
                {
                    hcf = i;
                }
            }

            bscnn = (n1 * n2) / hcf;
            txtKq.Text = bscnn.ToString();
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (rdBCNN.Checked)
                BSCNN();
            if (rdUCLN.Checked)
                UCLN();
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtKq.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
