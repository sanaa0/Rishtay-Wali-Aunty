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
    public partial class viewProfile : Form
    {
        private serveraunty.RISHTA rishtaToView;
        private serveraunty.RISHTA currRishta = new serveraunty.RISHTA();
        public viewProfile(serveraunty.RISHTA r,serveraunty.RISHTA curr)
        {
            rishtaToView = r;
            currRishta = curr;
            InitializeComponent();
        }

        private void viewProfile_Load(object sender, EventArgs e)
        {
            label12.Text = currRishta.Name;

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
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            searchRishtas sr = new searchRishtas(currRishta);
            sr.Show();
            this.Hide();
        }
    }
}
