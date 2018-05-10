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
    public partial class paid : Form
    {
        public paid()
        {
            InitializeComponent();
        }

        private void paid_Load(object sender, EventArgs e)
        {
            serveraunty.Service1 yo = new serveraunty.Service1();
            serveraunty.RISHTA r1 = new serveraunty.RISHTA();
            serveraunty.RISHTA r2 = new serveraunty.RISHTA();
            serveraunty.RISHTA r3 = new serveraunty.RISHTA();
            serveraunty.RISHTA r4 = new serveraunty.RISHTA();


            r1.Name = "sidra";
            r2.Name = "nabeela";
            r3.Name = "shabana";
            r4.Name = "salma";

            yo.addpes(r1);
            yo.addpes(r2);
            yo.addper(r3);
            yo.addper(r4);







            
            List < serveraunty.RISHTA > ds1 = yo.paysender().ToList<serveraunty.RISHTA>();
            List<serveraunty.RISHTA> ds2 = yo.payreceiver().ToList<serveraunty.RISHTA>();
            //List<serveraunty.RISHTA> ds3 = yo.payreq().ToList<serveraunty.RISHTA>();


            BindingSource b1 = new BindingSource();
            b1.DataSource = ds1;
            dataGridView1.DataSource = b1;


            BindingSource b2 = new BindingSource();
            b2.DataSource = ds2;
            dataGridView3.DataSource = b2;

            
            dataGridView1.Columns["email"].Visible = false;
            dataGridView1.Columns["password"].Visible = false;
            dataGridView1.Columns["fatherName"].Visible = false;
            dataGridView1.Columns["gender"].Visible = false;
            dataGridView1.Columns["age"].Visible = false;
            dataGridView1.Columns["city"].Visible = false;
            dataGridView1.Columns["religion"].Visible = false;
            dataGridView1.Columns["cast"].Visible = false;
            dataGridView1.Columns["income"].Visible = false;
            dataGridView1.Columns["height"].Visible = false;
            dataGridView1.Columns["contact"].Visible = false;
            dataGridView1.Columns["profession"].Visible = false;
            dataGridView1.Columns["allowedcontact"].Visible = false;
            dataGridView1.Columns["rishtacamespecified"].Visible = false;
            dataGridView1.Columns["allowedcontactspecified"].Visible = false;
            dataGridView1.Columns["rishtacame"].Visible = false;
            dataGridView1.Columns["statussspecified"].Visible = false;
            dataGridView1.Columns["sitatussspecified"].Visible = false;
            dataGridView1.Columns["sitatuss"].Visible = false;
            dataGridView1.Columns["statuss"].Visible = false;
            dataGridView1.Columns["status"].Visible = false;
            dataGridView1.Columns["statusspecified"].Visible = false;




            /*dataGridView3.Columns["email"].Visible = false;
            dataGridView3.Columns["password"].Visible = false;
            dataGridView3.Columns["fatherName"].Visible = false;
            dataGridView3.Columns["gender"].Visible = false;
            dataGridView3.Columns["age"].Visible = false;
            dataGridView3.Columns["city"].Visible = false;
            dataGridView3.Columns["religion"].Visible = false;
            dataGridView3.Columns["cast"].Visible = false;
            dataGridView3.Columns["income"].Visible = false;
            dataGridView3.Columns["height"].Visible = false;
            dataGridView3.Columns["contact"].Visible = false;
            dataGridView3.Columns["profession"].Visible = false;
            dataGridView3.Columns["allowedcontact"].Visible = false;
            dataGridView3.Columns["rishtacamespecified"].Visible = false;
            dataGridView3.Columns["allowedcontactspecified"].Visible = false;
            dataGridView3.Columns["rishtacame"].Visible = false;
            dataGridView3.Columns["statussspecified"].Visible = false;
            dataGridView3.Columns["sitatussspecified"].Visible = false;
            dataGridView3.Columns["sitatuss"].Visible = false;
            dataGridView3.Columns["statuss"].Visible = false;
            dataGridView3.Columns["statusspecified"].Visible = false;
            dataGridView3.Columns["status"].Visible = false;*/





           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            serveraunty.Service1 yo = new serveraunty.Service1();
            MessageBox.Show("ACCESS GRANTED");
            yo.allowofdetails();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
