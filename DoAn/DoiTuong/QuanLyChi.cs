using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.DoiTuong
{
    class QuanLyChi : QuanLy
    {
        private string vatPham;
        public string VatPham
        {
            get { return vatPham; }
            set { vatPham = value; }
        }
    }
}
