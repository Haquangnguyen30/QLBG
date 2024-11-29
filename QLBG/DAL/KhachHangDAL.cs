using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace DAL
{
    public class KhachHangDAL : DatabaseConnect
    {
        public DataTable getKhachHang()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT maKH, tenKH, sdt FROM khachHang ", _conn);
            DataTable dtKhachHang = new DataTable();
            da.Fill(dtKhachHang);
            return dtKhachHang;
        }
        public List<KhachHangDTO> getList()
        {
            try
            {
                if (_conn.State != ConnectionState.Open)
                {
                    _conn.Open();
                }
                string sql = "select * from khachHang";
                List<KhachHangDTO> list = new List<KhachHangDTO>();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    KhachHangDTO kh = new KhachHangDTO();
                    kh.maKH = reader.GetInt32(reader.GetOrdinal("maKH"));
                    kh.tenKH = reader["tenKH"].ToString();
                    kh.sdt = reader["sdt"].ToString();                   
                    list.Add(kh);
                }

                reader.Close();
                _conn.Close();
                return list;

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }

            return null;

        }

        public DataTable getFindKhachHang(string key)
        {
            DataTable dtKhachHang = new DataTable();
            using (SqlConnection connection = new SqlConnection(_conn.ConnectionString))
            {
                connection.Open();
                string sqlQuery = "SELECT maKH, tenKH, sdt FROM khachHang Where maKH LIKE @key OR tenKH LIKE @key OR sdt LIKE @key ";
                SqlDataAdapter da;
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@key", "%" + key + "%");
                    da = new SqlDataAdapter(command);

                }
                da.Fill(dtKhachHang);
            }

            return dtKhachHang;
        }

        public KhachHangDTO findSdtA(string sdt)
        {
            try
            {
                if (_conn.State != ConnectionState.Open)
                {
                    _conn.Open();
                }
                string sql = string.Format("select * from khachHang where sdt = '{0}'", sdt);
                KhachHangDTO kh = new KhachHangDTO();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    kh.maKH = reader.GetInt32(reader.GetOrdinal("maKH"));
                    kh.tenKH = reader["tenKH"].ToString();
                    kh.sdt = reader["sdt"].ToString();
                }

                reader.Close();
                _conn.Close();
                return kh;

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }

            return null;
        }
        public KhachHangDTO findSdt(string sdt)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_conn.ConnectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM khachHang WHERE sdt = @sdt";
                    KhachHangDTO kh = new KhachHangDTO();

                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@sdt", sdt);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                kh.maKH = reader.GetInt32(reader.GetOrdinal("maKH"));
                                kh.tenKH = reader["tenKH"].ToString();
                                kh.sdt = reader["sdt"].ToString();
                            }
                        }
                    }

                    return kh;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }

            return null;
        }

        public bool suakhachHang(KhachHangDTO kh)
        {
            try
            {
                // Ket noi
                if (_conn.State != ConnectionState.Open)
                {
                    _conn.Open();
                }

                // Query string to update the "tinhTrang" column to 'False' for the specified "maNV"
                string SQL = string.Format("UPDATE khachHang SET tenKH = @tenKH, sdt = @sdt WHERE maKH = @maKH");

                // Create a SqlCommand object
                using (SqlCommand cmd = new SqlCommand(SQL, _conn))
                {
                    // Use parameters to safely pass values into the SQL statement
                    cmd.Parameters.AddWithValue("@maKH", kh.maKH);
                    cmd.Parameters.AddWithValue("@tenKH", kh.tenKH);
                    cmd.Parameters.AddWithValue("@sdt", kh.sdt);
                    // Execute the SQL UPDATE statement
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                        return true;
                }
            }
            catch (Exception e)
            {
                // Handle the exception here or log it.
            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }

            return false;
        }

        public bool themKhachHang(KhachHangDTO tv)
        {
            try
            {
                // Ket noi
                if (_conn.State != ConnectionState.Open)
                {
                    _conn.Open();
                }


                string SQL =
                string.Format("INSERT INTO khachHang( maKH, tenKH, sdt) VALUES ('{0}', N'{1}', '{2}')"
                , tv.maKH, tv.tenKH, tv.sdt);

                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                SqlCommand cmd = new SqlCommand(SQL, _conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }

            return false;
        }
        public int getMaxMaKH()
        {
            try
            {
                String queryString = "SELECT MAX(maKH) FROM khachHang";

                return DatabaseConnect.queryScalar(queryString, null);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy mã khách hàng lớn nhất: " + ex.Message);
                return -1;
            }
        }

    }
}
