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
    public partial class details : Form
    {
        private serveraunty.RISHTA r;
        public details(serveraunty.RISHTA rishta)
        {
            InitializeComponent();
            r = rishta ;
        }
        public serveraunty.RISHTA r1 = new serveraunty.RISHTA();

        private void details_Load(object sender, EventArgs e)
        {
            textBox1.Text = r.Name;
            textBox2.Text = r.FatherName;
            textBox3.Text = r.Age;
            textBox4.Text = r.Gender;
            textBox5.Text = r.City;
            textBox6.Text = r.Religion;

            textBox7.Text = r.Cast;
            textBox8.Text = r.Income;
            textBox9.Text = r.Profession;
            textBox10.Text = r.Height;
        }
    }
}
