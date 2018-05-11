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
    public partial class sender : Form
    {
        public sender()
        {
            InitializeComponent();
        }
        public List<serveraunty.RISHTA> AllReceiver = new List<serveraunty.RISHTA>();
        public static List<serveraunty.RISHTA> senders;
        serveraunty.Service1 ser = new serveraunty.Service1();


        private void button1_Click(object sender, EventArgs e)
        {
            cuuu = ser.AllSender().ToList<serveraunty.RISHTA>();
            List<serveraunty.Service1> serve = new List<serveraunty.Service1>();



            List<serveraunty.RISHTA> fsss = ser.Allrishtay().ToList<serveraunty.RISHTA>();

            //  List<serveraunty.RISHTA> a = ser.

            serveraunty.RISHTA r1 = new serveraunty.RISHTA();
            serveraunty.RISHTA r2 = new serveraunty.RISHTA();
            serveraunty.RISHTA r3 = new serveraunty.RISHTA();
            r1.Name = "afifa";
            r2.Name = "uuu";



            fsss.Add(r1);
            fsss.Add(r2);


            cuuu.Add(r1);
            cuuu.Add(r2);
            /*  dataGridViewSender.Columns["Age"].Visible = false;
              dataGridViewSender.Columns["Gender"].Visible = false;
              dataGridViewSender.Columns["Height"].Visible = false;
              dataGridViewSender.Columns["Income"].Visible = false;
              dataGridViewSender.Columns["Profession"].Visible = false;
              dataGridViewSender.Columns["Allowedcontact"].Visible = false;
              dataGridViewSender.Columns["age"].Visible = false;*/

            BindingSource a = new BindingSource();
            a.DataSource = cuuu;
            dataGridView1.DataSource = a;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 1)
            {

                serveraunty.RISHTA r = new serveraunty.RISHTA();
                r = cuuu[e.RowIndex];
                // r = ser.seekofrishta(Convert.ToString(dataGridViewSender.Rows[e.RowIndex].Cells[0].Value));
                //MessageBox.Show((Convert.ToString(dataGridViewSender.Rows[e.RowIndex].Cells[0].Value)));
                details frm = new details(r);
                frm.Show();
                this.Hide();

              

            }
            if (e.ColumnIndex == 2)
            {
                serveraunty.RISHTA r = new serveraunty.RISHTA();
                r = cuuu[e.RowIndex];
                receiver frmmm = new receiver(r);

                frmmm.Show();
                this.Hide();

            }
        }
        List<serveraunty.RISHTA> cuuu;
    }
    }

