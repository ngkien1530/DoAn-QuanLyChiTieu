using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DoAn.DuLieu
{
    class KetNoiSQL
    {
        public SqlConnection con;
        public KetNoiSQL()
        {
            try
            {
                string str = "server=.;database=QuanLyChiTieu;integrated security=true;";
                
                con = new SqlConnection(str);

            }
            catch { }
        }
       
    }
}
