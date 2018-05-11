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
    public partial class UserLogin : Form
    {
        public UserLogin()
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
            List < serveraunty.RISHTA > temp =s.Allrishtay().ToList<serveraunty.RISHTA>();
            serveraunty.RISHTA curr = new serveraunty.RISHTA();
            if (f)
            {
                curr = s.seekofrishta(textBox1.Text);
            textBox1.Text = "";
            textBox2.Text = "";
                UserProfile up = new UserProfile(curr);
                this.Hide();
                up.Show();
          }
          else
          {
            MessageBox.Show("invalid user");
          }
          }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserRegisteration frm = new UserRegisteration();
            frm.Show();
            this.Hide();
        }
    }

        

        
    }

