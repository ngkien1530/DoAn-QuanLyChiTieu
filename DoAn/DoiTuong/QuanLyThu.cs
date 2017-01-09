using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.DoiTuong
{
    class QuanLyThu : QuanLy
    {
        private string noiDung;
        private DateTime thoiGian;
        private string ghiChu;
        private string soTien;
        private string iD;

        public string NoiDung
        {
            get
            {
                return noiDung;
            }

            set
            {
                noiDung = value;
            }
        }

        public DateTime ThoiGian
        {
            get
            {
                return thoiGian;
            }

            set
            {
                thoiGian = value;
            }
        }

        public string GhiChu
        {
            get
            {
                return ghiChu;
            }

            set
            {
                ghiChu = value;
            }
        }

        public string SoTien
        {
            get
            {
                return soTien;
            }

            set
            {
                soTien = value;
            }
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
