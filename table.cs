using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace КурсоваяТРПО
{
    public partial class table : Form
    {
        public table()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void table_Load(object sender, EventArgs e)
        {
            int year = 2021;
            foreach (People item in Form1.SortList)
                dataGridView1.Rows.Add(item.code, item.fam, year - item.datepost);
        }
    }
}