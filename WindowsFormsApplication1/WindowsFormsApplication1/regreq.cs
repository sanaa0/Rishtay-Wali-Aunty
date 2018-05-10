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
    public partial class regreq : Form
    {
       public  List<serveraunty.RISHTA> selectedData;
        public regreq()
        {
            InitializeComponent();
        }


        serveraunty.Service1 serve = new serveraunty.Service1();
        BindingSource b = new BindingSource();

        private void button1_Click(object sender, EventArgs e)
        {
            serveraunty.RISHTA r1 = new serveraunty.RISHTA();
            serveraunty.RISHTA r2 = new serveraunty.RISHTA();
            serveraunty.RISHTA r3 = new serveraunty.RISHTA();

            r1.Name = "Afifa";
            r1.Age = "afifa";
            r2.Name = "sara";
            r2.Age = "sara";
            r3.Name = "sana";
            r3.Age = "sana";

            serveraunty.Service1 serve = new serveraunty.Service1();
            BindingSource b = new BindingSource();
            //List<serveraunty.RISHTA> rishtass;

            serve.addrishtatobeapprovedof(r1);
            serve.addrishtatobeapprovedof(r2);
            serve.addrishtatobeapprovedof(r3);
            selectedData = serve.getlist().ToList<serveraunty.RISHTA>();
           // rishtas = rishtass;
            b.DataSource = selectedData;


           
            dataGridView1.DataSource = b;
            /* dataGridView1.Columns["email"].Visible = false;
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
            */








        }


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void regreq_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            serveraunty.Service1 serve = new serveraunty.Service1();

            if (e.ColumnIndex == 0)
            {
                serveraunty.RISHTA r;
                r = serve.getr((Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value)));
                textBox1.Text = r.Name;
                details d = new details(r);
                d.Show();
                this.Hide();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("here at permsi");
            serveraunty.Service1 b = new serveraunty.Service1();
            // serveraunty.RISHTA y = new serveraunty.RISHTA();
           List<serveraunty.RISHTA> temp1 = b.Ddlj().ToList<serveraunty.RISHTA>();
            MessageBox.Show(Convert.ToString(temp1.Count));
            b.fromtobetodone(selectedData.ToArray());
          //.fromtobetodone()
            List<serveraunty.RISHTA> temp = b.Allrishtay().ToList<serveraunty.RISHTA>();
            MessageBox.Show(Convert.ToString(temp.Count));
            //MessageBox.Show("here at end");



        }
    }
}
