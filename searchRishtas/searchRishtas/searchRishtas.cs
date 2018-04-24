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
    public partial class searchRishtas : Form
    {
        serveraunty.RISHTA rr=new serveraunty.RISHTA();
        public searchRishtas()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            serveraunty.Service1 s = new serveraunty.Service1();
            dataGridView1.AutoGenerateColumns = false;
            int row = e.RowIndex;

            if (e.ColumnIndex == 1) 
            {
                 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }


    }
}
