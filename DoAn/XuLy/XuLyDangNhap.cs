using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DoAn.XuLy
{
    class XuLyDangNhap
    {
        public bool DangNhap(string tenDangNhap, string matKhau)
        {
            List<DoiTuong.NguoiDung> listNguoiDung = new List<DoiTuong.NguoiDung>();
            DuLieu.DuLieuNguoiDung duLieuNguoiDung = new DuLieu.DuLieuNguoiDung();

            listNguoiDung = duLieuNguoiDung.LoadNguoiDung();
            for(int i=0;i<listNguoiDung.Count();i++)
            {
                if (tenDangNhap == listNguoiDung[i].TenTaiKhoan && matKhau == listNguoiDung[i].MatKhau)
                    return true;
            }
            return false;
        }
    }
}
