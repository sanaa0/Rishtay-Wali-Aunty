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
    public partial class receiver : Form
    {
        serveraunty.RISHTA cu = new serveraunty.RISHTA();
        public List<serveraunty.RISHTA> AllReceiver = new List<serveraunty.RISHTA>();
        public List<serveraunty.RISHTA> senders = new List<serveraunty.RISHTA>();
        serveraunty.Service1 serve = new serveraunty.Service1();
    
        public receiver(serveraunty.RISHTA rr)

        {
            InitializeComponent();
            cu = rr;

        
}
        List<serveraunty.RISHTA> fs;

        List<serveraunty.RISHTA> fs1;
        private void button1_Click(object sender, EventArgs e)
        {
            serveraunty.RISHTA r1 = new serveraunty.RISHTA();
            serveraunty.RISHTA r2 = new serveraunty.RISHTA();
            serveraunty.RISHTA r3 = new serveraunty.RISHTA();


            r1.Name = "Afifa";
            r2.Name = "hi";
            r3.Name = "uu";

            serveraunty.Service1 serve = new serveraunty.Service1();
           

            BindingSource b = new BindingSource();
            serve.addInSent(cu, r2);



            dataGridView1.DataSource = fs;

            MessageBox.Show("hey");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {

                serveraunty.RISHTA r = new serveraunty.RISHTA();
                r = fs[e.RowIndex];
                // r = ser.seekofrishta(Convert.ToString(dataGridViewSender.Rows[e.RowIndex].Cells[0].Value));
                //MessageBox.Show((Convert.ToString(dataGridViewSender.Rows[e.RowIndex].Cells[0].Value)));
                details frmm = new details(r);


                frmm.Show();
                this.Hide();

            }
            if (e.ColumnIndex == 2)
            {
                serveraunty.RISHTA r = new serveraunty.RISHTA();
                r = serve.seekofrishta(Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value));
                MessageBox.Show(Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value));
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
