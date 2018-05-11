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
    public partial class acceptReq : Form
    {
        serveraunty.Service1 s = new serveraunty.Service1();
        serveraunty.RISHTA r = new serveraunty.RISHTA();
        serveraunty.RISHTA curr = new serveraunty.RISHTA();
        public acceptReq(serveraunty.RISHTA r)
        {
            InitializeComponent();
            curr = r;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                r = s.seekofrishta(Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value));
                viewProfile vp = new viewProfile(r,curr);
                vp.Show();
                this.Hide();
            }
            if (e.ColumnIndex == 2)
            {
                r = s.seekofrishta(Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value));
                s.addInRecieved(curr, r);
            }
            if (e.ColumnIndex == 3)
            {
                r = s.seekofrishta(Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value));
                s.removeFromRecieved(curr, r);
                s.removeFromSent(r, curr);
            }
        }
    }
}
