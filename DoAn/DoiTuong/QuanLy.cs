using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.DoiTuong
{
    class QuanLy
    {
        private string iD;
        private string soTien;
        private DateTime thoiGian;
        private string ghiChu;
        public string SoTien
        {
            get { return soTien; }
            set { soTien = value; }
        }
        public DateTime ThoiGian
        {
            get { return thoiGian; }
            set { thoiGian = value; }
        }
        public string GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }

        public string ID
        {
            get
            {
                return iD;
            }

            set
            {
                iD = value;
            }
        }
    }
}
