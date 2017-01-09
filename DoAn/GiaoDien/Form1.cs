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
            dataGridViewChi.Visible = false;
            dataGridViewThu.Visible = false;

            CaiDatBangThu();
            ThemVaoBangThu();

            CaiDatBangChi();
            ThemVaoBangChi();
            //if(ThuTab.Active == true)
            //{
            //    CaiDatBangThu();
            //    ThemVaoBangThu();
            //    dataGridViewThu.Visible = true;
            //    dataGridViewChi.Visible = false;
            //}
            //else if(ChiTab.Active == true)
            //{
            //    CaiDatBangChi();
            //    ThemVaoBangChi();
            //    dataGridViewChi.Visible = true;
            //    dataGridViewThu.Visible = false;
            //}
        }

        private void CaiDatBangChi()
        {

            dataGridViewChi.ColumnCount = 5;

            dataGridViewChi.Columns[0].Name = "STT";
            dataGridViewChi.Columns[0].Width = 55;
            dataGridViewChi.Columns[1].Name = "Vật phẩm";
            dataGridViewChi.Columns[1].Width = 100;
            dataGridViewChi.Columns[2].Name = "Số tiền";
            dataGridViewChi.Columns[2].Width = 80;
            dataGridViewChi.Columns[3].Name = "Thời gian";
            dataGridViewChi.Columns[3].Width = 80;
            dataGridViewChi.Columns[4].Name = "Ghi chú";
            dataGridViewChi.Columns[4].Width = 120;

        }

        private void ThemVaoBangChi()
        {
            var duLieuQLChi = new DuLieu.DuLieuQuanLyChi();
            List<DoiTuong.QuanLyChi> listChi = new List<DoiTuong.QuanLyChi>();
            listChi = duLieuQLChi.LoadQuanLyChi();
            for (int i = 0; i < listChi.Count(); i++)
            {
                dataGridViewChi.Rows.Add(listChi[i].ID, listChi[i].VatPham, listChi[i].SoTien, listChi[i].ThoiGian, listChi[i].GhiChu);
            }

        }

        private void CaiDatBangThu()
        {

            dataGridViewThu.ColumnCount = 5;

            dataGridViewThu.Columns[0].Name = "STT";
            dataGridViewThu.Columns[0].Width = 55;
            dataGridViewThu.Columns[1].Name = "Nội dung";
            dataGridViewThu.Columns[1].Width = 100;
            dataGridViewThu.Columns[2].Name = "Số tiền";
            dataGridViewThu.Columns[2].Width = 80;
            dataGridViewThu.Columns[3].Name = "Thời gian";
            dataGridViewThu.Columns[3].Width = 80;
            dataGridViewThu.Columns[4].Name = "Ghi chú";
            dataGridViewThu.Columns[4].Width = 120;

        }

        private void ThemVaoBangThu()
        {
            var duLieuQLThu = new DuLieu.DuLieuQuanLyThu();
            List<DoiTuong.QuanLyThu> listThu = new List<DoiTuong.QuanLyThu>();
            listThu = duLieuQLThu.LoadQuanLyThu();
            for (int i = 0; i < listThu.Count(); i++)
            {
                dataGridViewThu.Rows.Add(listThu[i].ID, listThu[i].NoiDung, listThu[i].SoTien, listThu[i].ThoiGian, listThu[i].GhiChu);
            }

        }

        private void ThuTab_ActiveChanged(object sender, EventArgs e)
        {

            dataGridViewThu.Visible = true;
            dataGridViewChi.Visible = false;
        }

        private void ChiTab_ActiveChanged(object sender, EventArgs e)
        {

            dataGridViewChi.Visible = true;
            dataGridViewThu.Visible = false;
        }
    }
}
