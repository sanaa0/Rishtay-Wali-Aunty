using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private bool button1_Click(object sender, EventArgs e)
        {   bool isvalid = false;
            bool issvalid = false;
            serveraunty.Service1 k = new serveraunty.Service1();
            serveraunty.AUNTY auntay = new serveraunty.AUNTY();
            auntay.Username = textBox1.Text;
            auntay.Code = textBox2.Text;
            k.loginofadmin(auntay, out isvalid, out issvalid);

            if (isvalid)
            {
                MessageBox.Show("Successfully logged in as an admin");
                adminaprovaltologin logi = new adminaprovaltologin();
                logi.Show();
                this.Hide();

            }
            {
                MessageBox.Show("logging attempt is failed.");
            }
            return issvalid;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            form7 frm = new form7();
            frm.Show();
            this.Hide();

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            form10 frm = new form10();
            frm.Show();
            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
