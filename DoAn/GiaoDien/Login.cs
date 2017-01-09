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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            //var ketNoiSql = new D.KetNoiSQL();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            XuLy.XuLyDangNhap XLDN = new XuLy.XuLyDangNhap();
            this.Hide();
            bool status = XLDN.DangNhap("K", "1");
            if(status == true)
            {
                Form1 a = new Form1();
                a.ShowDialog();
            }
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
               
        }
    }
}
