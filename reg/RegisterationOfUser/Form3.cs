using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisterationOfUser
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool f = false;
            bool ff = false;
            serveraunty.Service1 s = new serveraunty.Service1();
            s.loginof( textBox1.Text,textBox2.Text,out f, out ff );
             if (ff)
            {
              MessageBox.Show("user is successfully logged in");
            textBox1.Text = "";
           textBox2.Text = "";
          }
          else
          {
            MessageBox.Show("invalid user");
          }
          }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Form10 frm = new Form10();
            //frm.Show();
            //this.Hide();
        }
    }

        

        
    }

