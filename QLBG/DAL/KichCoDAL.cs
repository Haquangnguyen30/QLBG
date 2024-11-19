using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KichCoDAL: DatabaseConnect
    {
        public DataTable getDSKichCo()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM kichCo WHERE tinhTrang = 1",_conn);
            da.Fill(dt);
            return dt;
        }
    }
}
