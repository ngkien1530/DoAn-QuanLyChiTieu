using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DoAn.DuLieu
{
    class DuLieuQuanLyChi
    {
        public List<DoiTuong.QuanLyChi> LoadQuanLyChi()
        {
            var KnSql = new DuLieu.KetNoiSQL();
            SqlConnection con = KnSql.con;

            string querry = "select * from QuanLyChi";
            SqlDataReader rdr = null;
            SqlCommand com = new SqlCommand(querry, con);


            List<DoiTuong.QuanLyChi> listChi = new List<DoiTuong.QuanLyChi>();
            try
            {
                con.Open();
                rdr = com.ExecuteReader();
                while (rdr.Read())
                {
                    DoiTuong.QuanLyChi QLChi = new DoiTuong.QuanLyChi();
                    QLChi.ID = (string)rdr["ID"];
                    QLChi.VatPham = (string)rdr["VatPham"];
                    QLChi.ThoiGian = (DateTime)rdr["ThoiGian"];
                    QLChi.SoTien = (string)rdr["SoTien"];
                    QLChi.GhiChu = (string)rdr["GhiChu"];

                    listChi.Add(QLChi);
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
            return listChi;
        }
    }
}
