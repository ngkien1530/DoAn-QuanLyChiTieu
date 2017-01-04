using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.DoiTuong
{
    class NguoiDung
    {
        private string iD;
        private string tenTaiKhoan;
        private string matKhau;
        private string hoVaTen;
        public string ID
        {
            get { return iD; }
            set { iD = value; }
        }
        public string TenTaiKhoan
        {
            get { return tenTaiKhoan; }
            set { tenTaiKhoan = value; }
        }
        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }
        public string HoVaTen
        {
            get { return hoVaTen; }
            set { hoVaTen = value; }
        }
        
    }
}
