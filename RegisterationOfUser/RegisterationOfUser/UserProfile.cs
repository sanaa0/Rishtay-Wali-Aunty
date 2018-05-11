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
    public partial class UserProfile : Form
    {
        serveraunty.Service1 s = new serveraunty.Service1();
        private serveraunty.RISHTA rishtaToView = new serveraunty.RISHTA();
        public UserProfile(serveraunty.RISHTA r)
        {
            rishtaToView = r;
            InitializeComponent();
        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            lblRishta.Text = rishtaToView.Name;

            textBox1.Text = rishtaToView.Name;
            textBox2.Text = rishtaToView.FatherName;
            textBox3.Text = rishtaToView.Gender;
            textBox4.Text = rishtaToView.Age;
            textBox5.Text = rishtaToView.City;
            textBox6.Text = rishtaToView.Religion;
            textBox7.Text = rishtaToView.Cast;
            textBox8.Text = rishtaToView.Income;
            textBox9.Text = rishtaToView.Profession;
            textBox10.Text = rishtaToView.Height;
            textBox11.Text = rishtaToView.Email;
            textBox12.Text = rishtaToView.Password;
            textBox13.Text = rishtaToView.Contact;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserLogin ul = new UserLogin();
            this.Hide();
            ul.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            searchRishtas sr = new searchRishtas(rishtaToView);
            this.Hide();
            sr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            acceptReq ar = new acceptReq(rishtaToView);
            this.Hide();
            ar.Show();
        }
    }
}
