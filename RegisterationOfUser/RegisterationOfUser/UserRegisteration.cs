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
    public partial class UserRegisteration : Form
    {
        public UserRegisteration()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serveraunty.RISHTA r = new serveraunty.RISHTA();
            r.Email = textBox3.Text;
            r.Password = textBox4.Text;
            r.Name = textBox1.Text;
            r.FatherName = textBox2.Text;
            r.Gender = radioButton1.Text;
            r.Gender = radioButton2.Text;
            r.Age = textBox5.Text;
            r.City = textBox6.Text;
            r.Religion = textBox7.Text;
            r.Cast = textBox8.Text;
            r.Income = textBox9.Text;
            r.Height = textBox10.Text;
            r.Contact = textBox11.Text;
            r.Profession = textBox12.Text;

            serveraunty.Service1 m = new serveraunty.Service1();
            m.addrishtatobeapprovedof( r);
            MessageBox.Show("your request is transferred to the admin");

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserLogin frm = new UserLogin();
            frm.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
