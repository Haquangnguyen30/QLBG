using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoaiSanPhamDAL:DatabaseConnect
    {
        public DataTable getDSLoaiSanPham()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM loaiSP WHERE tinhTrang = 1",_conn);
            da.Fill(dt);
            return dt;
        }
    }
}
