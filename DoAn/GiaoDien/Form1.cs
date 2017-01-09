using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void CaiDatBangThongKe()
        {
            dataGridView3.ColumnCount = 4;
            dataGridView3.Columns[0].Name = "Thời Gian";
            dataGridView3.Columns[0].Width = 100;
            dataGridView3.Columns[1].Name = "Thời Gian";
            dataGridView3.Columns[1].Width = 100;
            dataGridView3.Columns[2].Name = "Thời Gian";
            dataGridView3.Columns[2].Width = 100;
            dataGridView3.Columns[3].Name = "Thời Gian";
            dataGridView3.Columns[3].Width = 100;
        }
    }
}
