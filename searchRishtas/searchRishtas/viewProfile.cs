using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace searchRishtas
{
    public partial class viewProfile : Form
    {
        private serveraunty.RISHTA rishtaToView;
        public viewProfile()
        {
            InitializeComponent();
        }

        public viewProfile(serveraunty.RISHTA r)
        {
            InitializeComponent();
            rishtaToView = r;
        }

        private void viewProfile_Load(object sender, EventArgs e)
        {
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
    }
}
