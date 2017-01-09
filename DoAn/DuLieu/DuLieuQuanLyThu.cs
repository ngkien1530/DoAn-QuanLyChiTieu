using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DoAn.DuLieu
{
    class DuLieuQuanLyThu
    {
        public List<DoiTuong.QuanLyThu> LoadQuanLyThu()
        {
            var KnSql = new DuLieu.KetNoiSQL();
            SqlConnection con = KnSql.con;

            string querry = "select * from QuanLyThu";
            SqlDataReader rdr = null;
            SqlCommand com = new SqlCommand(querry, con);


            List<DoiTuong.QuanLyThu> listThu = new List<DoiTuong.QuanLyThu>();
            try
            {
                con.Open();
                rdr = com.ExecuteReader();
                while(rdr.Read())
                {
                    DoiTuong.QuanLyThu QLThu = new DoiTuong.QuanLyThu();
                    QLThu.ID = (string)rdr["ID"];
                    QLThu.ThoiGian = (DateTime)rdr["ThoiGian"];
                    QLThu.SoTien = (string)rdr["SoTien"];
                    QLThu.GhiChu = (string)rdr["GhiChu"];

                    listThu.Add(QLThu);
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
            return listThu;
        }

    }
}
