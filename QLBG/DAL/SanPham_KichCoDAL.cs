using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SanPham_KichCoDAL: DatabaseConnect
    {
        public DataTable getChiTietSoLuong(string maSP)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT k.KichCo, sk.soLuong " +
                                                   "FROM sanPham_KichCo sk JOIN kichCo k ON sk.maKichCo = k.maKichCo " +
                                                   $"WHERE sk.maSP = '{maSP}';", _conn);
            da.Fill(dt);
            return dt;
        }
    }
}
