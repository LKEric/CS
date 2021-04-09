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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            lv1.GridLines = true;
            lv1.FullRowSelect = true;
            lv1.View = View.Details;
            lv1.Columns.Add("Date", 100);
            lv1.Columns.Add("Name", 50);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtSecurutyCode.Text = (txtSecurutyCode.Text + "0");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtSecurutyCode.Text = (txtSecurutyCode.Text + "1");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtSecurutyCode.Text = (txtSecurutyCode.Text + "2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtSecurutyCode.Text = (txtSecurutyCode.Text + "3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtSecurutyCode.Text = (txtSecurutyCode.Text + "4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtSecurutyCode.Text = (txtSecurutyCode.Text + "5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtSecurutyCode.Text = (txtSecurutyCode.Text + "6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtSecurutyCode.Text = (txtSecurutyCode.Text + "7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtSecurutyCode.Text = (txtSecurutyCode.Text + "8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtSecurutyCode.Text = (txtSecurutyCode.Text + "9");
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            txtSecurutyCode.Text = "";
        }

        private void btnt_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string Ra = "Restricted Accsess";
            string date = now.ToString();
            
            switch (txtSecurutyCode.Text)
            {
                case "1645":
                    Ra = "Techinicians";
                    break;
                case "1689":
                    Ra = "Techinicians";
                    break;
                case "8345":
                    Ra = "Custodians";
                    break;
                case "9998":
                    Ra = "Scientist";
                    break;
                case "1006":
                    Ra = "Scientist";
                    break;
                case "1008":
                    Ra = "Scientist";
                    break;
            }
            string[] arr = new string[2];
            arr[0] = date;
            arr[1] = Ra;
            ListViewItem ktl = new ListViewItem(arr);
            lv1.Items.Add(ktl);
            

        }
    
    }
}
