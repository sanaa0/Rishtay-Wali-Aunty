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
    public partial class searchRishtas : Form
    {
        serveraunty.Service1 s = new serveraunty.Service1();
        List<serveraunty.RISHTA> searches = new List<serveraunty.RISHTA>();
        private serveraunty.RISHTA currRishta = new serveraunty.RISHTA();
        public searchRishtas(serveraunty.RISHTA r)
        {
            InitializeComponent();
            currRishta = r;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            searches = s.getrishta(cmbCategory.Text, txtchoice.Text, currRishta).ToList();
            BindingSource src = new BindingSource();
            src.DataSource = searches;
            dataGridView1.DataSource = src;


            dataGridView1.Columns["Name"].DisplayIndex = 0;
            dataGridView1.Columns["FatherName"].Visible = false;
            dataGridView1.Columns["Age"].Visible = false;
            dataGridView1.Columns["Cast"].Visible = false;
            dataGridView1.Columns["Religion"].Visible = false;
            dataGridView1.Columns["Income"].Visible = false;
            dataGridView1.Columns["Profession"].Visible = false;
            dataGridView1.Columns["Gender"].Visible = false;
            dataGridView1.Columns["City"].Visible = false;
            dataGridView1.Columns["Height"].Visible = false;
            dataGridView1.Columns["Email"].Visible = false;
            dataGridView1.Columns["Password"].Visible = false;
            dataGridView1.Columns["Contact"].Visible = false;
            dataGridView1.Columns["Allowedcontact"].Visible = false;
            dataGridView1.Columns["Allowedcontactspecified"].Visible = false;
            dataGridView1.Columns["Rishtacame"].Visible = false;
            dataGridView1.Columns["Status"].Visible = false;
            dataGridView1.Columns["Statusshow"].Visible = false;
            dataGridView1.Columns["Sitatuss"].Visible = false;
            dataGridView1.Columns["statuss"].Visible = false;
            dataGridView1.Columns["Rishtacamespecified"].Visible = false;
            dataGridView1.Columns["Statussspecified"].Visible = false;
            dataGridView1.Columns["Statusshowspecified"].Visible = false;
            dataGridView1.Columns["Sitatussspecified"].Visible = false;
            dataGridView1.Columns["statussspecified"].Visible = false;

            for (int i = 0; i < searches.Count(); i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = txtchoice.Text;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                serveraunty.RISHTA r = new serveraunty.RISHTA();

                r = searches[e.RowIndex];
                viewProfile vp = new viewProfile(r,currRishta);
                vp.Show();
                this.Hide();

            }
            if (e.ColumnIndex == 2)
            {
                serveraunty.RISHTA r = new serveraunty.RISHTA();
                r = searches[e.RowIndex];

                s.addInSent(currRishta, r);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            acceptReq ar = new acceptReq(currRishta);
            this.Hide();
            ar.Show();
        }

        private void searchRishtas_Load(object sender, EventArgs e)
        {

        }
    }
}
