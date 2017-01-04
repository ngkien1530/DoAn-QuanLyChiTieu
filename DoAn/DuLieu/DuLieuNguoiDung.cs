using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace DoAn.DuLieu
{
    class DuLieuNguoiDung
    {
        
        public List<DoiTuong.NguoiDung> LoadNguoiDung()
        {
            var knSql = new DuLieu.KetNoiSQL();
            SqlConnection con = knSql.con;  // Kết nối sql

            string query = "select * from NguoiDung";
            SqlDataReader rdr = null;
            SqlCommand com = new SqlCommand(query, con);

            List<DoiTuong.NguoiDung> listNguoiDung = new List<DoiTuong.NguoiDung>();
            try
            {
                con.Open();
                rdr = com.ExecuteReader(); // 1.  get an instance of the SqlDataReader
                while (rdr.Read())
                {
                    DoiTuong.NguoiDung nguoiDung = new DoiTuong.NguoiDung();
                    nguoiDung.ID = (string)rdr["ID"];
                    nguoiDung.TenTaiKhoan = (string)rdr["TenTaiKhoan"];
                    nguoiDung.MatKhau = (string)rdr["MatKhau"];
                    nguoiDung.HoVaTen = (string)rdr["HoVaTen"];

                    listNguoiDung.Add(nguoiDung);
                }
                
            }
            finally
            {
                // 3. close the reader
                if (rdr != null)
                {
                    rdr.Close();
                }

                // close the connection
                if (con != null)
                {
                    con.Close();
                }
            }
            return listNguoiDung;
        }
    }
}
