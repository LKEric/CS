using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03oc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            ListShow();
            

        }
        public void ListShow()
        {
            
            listView.View = View.Details;
            listView.Columns.Add("Name", 100);
            listView.Columns.Add("Age", 50);
            listView.Columns.Add("Address", 100);
            listView.Columns.Add("YOE", 50);
            listView.Columns.Add("Phone", 100);
            listView.Columns.Add("Email", 100);
            listView.Columns.Add("Date", 100);
        }
        public bool checkValid()
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (txtName.Text == "")
            {
                MessageBox.Show("Input Name!!");
                return false;
            }
            if (txtExp.Text == "")
            {
                MessageBox.Show("Input Year of Experience!!");
                return false;
            }
            else
            {
                int i = int.Parse(txtExp.Text);
                if (i < 0 || i > 2)
                {
                    MessageBox.Show("Year of Experience limit 0->2 year");
                    return false;
                }
            }
            if (txtAge.Text == "")
            {
                MessageBox.Show("Input Age!!");
                return false;
            }
            if (txtAdd.Text == "")
            {
                MessageBox.Show("Input Address!!");
                return false;
            }
            if (txtPhone.Text == "")
            {
                MessageBox.Show("Input Phone!!");
                return false;
            }
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Input Email!!");
                return false;
            }else if (!re.IsMatch(txtEmail.Text))
            {
                MessageBox.Show("Invalid Email!");
                return false;
            }


            return true;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtExp_TextChanged(object sender, EventArgs e)
        {
            String st = txtExp.Text.ToString();
            if (st.Length > 0)
            {
                if (!char.IsDigit(st[st.Length - 1]))
                {
                    MessageBox.Show("Enter the digit!");
                    txtExp.Text = "";

                }
                
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkValid())
            {
                string[] arr = new string[7];
                arr[0] = txtName.Text.ToString();
                arr[1] = txtAge.Text.ToString();
                arr[2] = txtAdd.Text.ToString();
                arr[3] = txtExp.Text.ToString();
                arr[4] = txtPhone.Text.ToString();
                arr[5] = txtEmail.Text.ToString();
                arr[6] = dtp.Text.ToString();
                ListViewItem lvt = new ListViewItem(arr);
                listView.Items.Add(lvt);
            }
        }

       

        private void btnDel_Click(object sender, EventArgs e)
        {
            listView.SelectedItems[0].Remove();
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*txtName.Text = listView.SelectedItems[0].SubItems[0].Text;
            txtAge.Text = listView.SelectedItems[0].SubItems[1].Text.ToString();
            txtAdd.Text = listView.SelectedItems[0].SubItems[2].Text.ToString();
            txtExp.Text = listView.SelectedItems[0].SubItems[3].Text.ToString();
            txtPhone.Text = listView.SelectedItems[0].SubItems[4].Text.ToString();
            txtEmail.Text = listView.SelectedItems[0].SubItems[5].Text.ToString();*/
            

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (checkValid())
            {
                string[] arr = new string[7];
                arr[0] = txtName.Text.ToString();
                arr[1] = txtAge.Text.ToString();
                arr[2] = txtAdd.Text.ToString();
                arr[3] = txtExp.Text.ToString();
                arr[4] = txtPhone.Text.ToString();
                arr[5] = txtEmail.Text.ToString();
                arr[6] = dtp.Text.ToString();
                ListViewItem lvt = new ListViewItem(arr);
                int i = listView.SelectedItems[0].Index;
                listView.SelectedItems[0].Remove();
                listView.Items.Insert(i, lvt);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String filename = "employee.txt";
            FileStream fs = new FileStream(filename, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            int n = listView.Items.Count;

            for(int i = 0; i < n; i++)
            {
                sw.Write(listView.Items[i].SubItems[0].Text);
                sw.Write(", ");
                sw.Write(listView.Items[i].SubItems[1].Text);
                sw.Write(", ");
                sw.Write(listView.Items[i].SubItems[2].Text);
                sw.Write(", ");
                sw.Write(listView.Items[i].SubItems[3].Text);
                sw.Write(", ");
                sw.Write(listView.Items[i].SubItems[4].Text); 
                sw.Write(", ");
                sw.Write(listView.Items[i].SubItems[5].Text); 
                sw.Write(", ");
                sw.Write(listView.Items[i].SubItems[6].Text);
                sw.WriteLine();

            }
            sw.Close();
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            String st = txtAge.Text.ToString();
            if (st.Length > 0)
            {
                if (!char.IsDigit(st[st.Length - 1]))
                {
                    MessageBox.Show("Enter the digit!");
                    txtAge.Text = "";

                }

            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            String st = txtPhone.Text.ToString();
            if (st.Length > 0)
            {
                if (!char.IsDigit(st[st.Length - 1]))
                {
                    MessageBox.Show("Enter the digit!");
                    txtPhone.Text = "";

                }

            }
        }
    }
}
