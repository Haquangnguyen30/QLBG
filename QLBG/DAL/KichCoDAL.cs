using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KichCoDAL : DatabaseConnect
    {
        public DataTable getDSKichCo()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM kichCo WHERE tinhTrang = 1", _conn);
            da.Fill(dt);
            return dt;
        }
        public DataTable getMaKC()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT maKichCo FROM kichCo", _conn);
            da.Fill(dt);
            return dt;
        }
        public bool addKichCo(KichCoDTO kichco)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO kichCo(maKichCo, kichCo, tinhTrang) " +
                                    "VALUES(@maKichCo, @kichCo, @tinhTrang)", _conn);
                cmd.Parameters.AddWithValue("@maKichCo", kichco.maKichCo);
                cmd.Parameters.AddWithValue("@kichCo", kichco.kichCo);
                cmd.Parameters.AddWithValue("@kichCo", kichco.kichCo);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
            finally
            {
                _conn.Close();  
            }
            return false;
        }
    }
}
