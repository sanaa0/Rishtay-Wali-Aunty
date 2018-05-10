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
    public partial class form7 : Form
    {
        public form7()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            serveraunty.AUNTY a = new serveraunty.AUNTY();
            a.Username = textBox1.Text;

            a.Code = textBox2.Text;
            textBox1.Text = " ";
            textBox2.Text = " ";


            serveraunty.Service1 f = new serveraunty.Service1();
            f.regofadmin(a);

            MessageBox.Show("REGISTERATION AS AN ADMIN IS APPROVED");

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form5 frm = new Form5();
            frm.Show();
            this.Hide();
        }
        int count = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (count == 0)
            {
                MessageBox.Show("YOUR SECRET CODE IS 5410");
                count = 1;
            }
            else if (count == 1)
            {
                MessageBox.Show("YOUR SECRET CODE IS 1234");
                count = 2;
            }
            else if (count == 2)
            {
                MessageBox.Show("YOUR SECRET CODE IS 9876");
                count = 3;
            }
            else
            {
                MessageBox.Show("YOU ARE NOT ALLOWED TO REGISTER AS AN ADMIN");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }


    }
}


