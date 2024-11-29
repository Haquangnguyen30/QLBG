using DocumentFormat.OpenXml.Drawing.Diagrams;
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
    public class SanPhamDAL:DatabaseConnect
    {
        SqlConnection _conn = DatabaseConnect._conn;
        public DataTable getDSSP(String searchStr)
        {
            try
            {
                String sSql = "SELECT sp.maSP, sp.tenSP, sp.mau, sp.giaNhap FROM sanPham sp WHERE sp.tinhTrang = 1 " +
                                $"AND (sp.tenSP LIKE '%{searchStr}%' OR sp.mau LIKE '%{searchStr}%')";

                SqlDataReader reader = DatabaseConnect.queryData(sSql);

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Mã SP");
                dataTable.Columns.Add("Tên SP");
                dataTable.Columns.Add("Màu sắc");
                dataTable.Columns.Add("Giá nhập");

                while (reader.Read())
                {
                    DataRow row = dataTable.NewRow();
                    row["Mã SP"] = reader.GetString(0);
                    row["Tên SP"] = reader.GetString(1);
                    row["Màu sắc"] = reader.GetString(2);
                    row["Giá nhập"] = reader.IsDBNull(3) ? "None" : reader.GetDouble(3).ToString("N0");

                    dataTable.Rows.Add(row);
                }

                reader.Close();
                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public int suaGiaNhapSP(String maSP, String giaNhap)
        {
            try
            {
                String updateString = "UPDATE sanPham SET " +
                                        $"giaNhap = {giaNhap} " +
                                        $"WHERE maSP = '{maSP}'";
                List<SqlParameter> list = new List<SqlParameter>();
                list = null;

                return DatabaseConnect.updateData(updateString, null);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi sửa giá nhập sản phẩm: " + ex.ToString());
                return 0;
            }
        }

        public int getSoLuongKichCo(String maSP, int makichCo)
        {
            try
            {
                if (_conn.State != ConnectionState.Open) _conn.Open();

                int soLuong = 0;
                String queryString = $"SELECT sk.soLuong FROM sanPham_KichCo sk WHERE sk.maSP = '{maSP}' AND sk.makichCo = {makichCo}";

                SqlDataReader reader = DatabaseConnect.queryData(queryString);
                if (reader.Read())
                {
                    if (!reader.IsDBNull(0))
                    {
                        soLuong = reader.GetInt32(0);
                    }
                }
                reader.Close();
                return soLuong;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi lấy số lượng của kích cỡ: " + ex.ToString());
                return -1;
            }
            finally
            {
                if (_conn.State == ConnectionState.Open) _conn.Close();
            }
        }

        public int suaSoLuongKichCo(String maSP, int maKichCo, int soLuong)
        {
            try
            {
                if (_conn.State != ConnectionState.Open) _conn.Open();

                String sql = "UPDATE sanPham_KichCo SET " +
                                        $"soLuong = @soLuong " +
                                        $"WHERE maSP = @maSP AND makichCo = @maKichCo";

                using (SqlCommand sqlCommand = new SqlCommand(sql, _conn))
                {
                    sqlCommand.Parameters.AddWithValue("@soLuong", soLuong);
                    sqlCommand.Parameters.AddWithValue("@maSP", maSP);
                    sqlCommand.Parameters.AddWithValue("@maKichCo", maKichCo);

                    return sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi cập nhật số lượng của kích cỡ: " + ex.ToString());
                return 0;
            }
            finally
            {
                if (_conn.State == ConnectionState.Open) _conn.Close();
            }
        }

        public int themSoLuongKichCo(String maSP, int maKichCo, int soLuong)
        {
            try
            {
                if(_conn.State != ConnectionState.Open) _conn.Open();

                String sql = "INSERT INTO sanPham_KichCo (maSP, makichCo, soLuong, tinhTrang) " +
                                "VALUES (@maSP, @makichCo, @soLuong, @tinhTrang)";

                using(SqlCommand sqlCommand = new SqlCommand(sql, _conn))
                {
                    sqlCommand.Parameters.AddWithValue("@maSP", maSP);
                    sqlCommand.Parameters.AddWithValue("@makichCo", maKichCo);
                    sqlCommand.Parameters.AddWithValue("@soLuong", soLuong);
                    sqlCommand.Parameters.AddWithValue("@tinhTrang", true);

                    return sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi thêm số lượng của kích cỡ: " + ex.ToString());
                return 0;
            }
            finally
            {
                if(_conn.State == ConnectionState.Open) _conn.Close();
            }
        }

        public bool isMaSPExist(String maSP)
        {
            try
            {
                if (_conn.State != ConnectionState.Open) _conn.Open();

                String sql = $"SELECT COUNT(*) FROM sanPham s WHERE s.tinhTrang = 1 AND s.maSP = '{maSP}'";

                using (SqlCommand sqlCommand = new SqlCommand(sql, _conn))
                {
                    int result = (int)sqlCommand.ExecuteScalar();

                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi kiểm tra sản phẩm tồn tại: " + ex.Message);
                return false;
            }
            finally
            {
                if(_conn.State == ConnectionState.Open) _conn.Close();
            }
        }
        
        //PhuocDo
        public DataTable getDSSanPham()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT s.maSP, s.tenSP, s.giaBan, COALESCE(SUM(sk.soLuong), 0) AS soLuong, s.img, s.giaNhap, s.mau, s.maLoai " +
                                                   "FROM sanPham s LEFT JOIN sanPham_KichCo sk ON s.maSP = sk.maSP " +
                                                   "WHERE s.tinhTrang = 1 " +
                                                   "GROUP BY s.maSP, s.tenSP, s.giaBan, s.img, s.giaNhap, s.mau, s.maLoai;", _conn);

            da.Fill(dt);
            return dt;
        }
        public DataTable getMaSP()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT maSP FROM sanPham", _conn);
            da.Fill(dt);
            return dt;
        }
        public bool addSanPham(SanPhamDTO sanPham)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO sanPham (maSP, tenSP, giaBan, soLuong, img, giaNhap, mau, tinhTrang, maLoai) " +
                                                "VALUES (@maSP, @tenSP, @giaBan, @soLuong, @img, @giaNhap, @mau, @tinhTrang, @maLoai)", _conn);
                cmd.Parameters.AddWithValue("@maSP", sanPham.maSP);
                cmd.Parameters.AddWithValue("@tenSP", sanPham.tenSP);
                cmd.Parameters.AddWithValue("@giaBan", sanPham.giaBan);
                cmd.Parameters.AddWithValue("@soLuong", sanPham.soLuong);
                cmd.Parameters.AddWithValue("@img", sanPham.img);
                cmd.Parameters.AddWithValue("@giaNhap", sanPham.giaNhap);
                cmd.Parameters.AddWithValue("@mau", sanPham.mau);
                cmd.Parameters.AddWithValue("@tinhTrang", sanPham.tinhTrang);
                cmd.Parameters.AddWithValue("@maLoai", sanPham.maLoai);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
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
        public bool updateSanPham(SanPhamDTO sanPham)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE sanPham " +
                                                "SET tenSP = @tenSP, giaBan = @giaBan, giaNhap = @giaNhap, mau = @mau, maLoai = @maLoai, img = @img " +
                                                "WHERE  maSP = @maSP; "
                                                , _conn);
                cmd.Parameters.AddWithValue("@tenSP", sanPham.tenSP);
                cmd.Parameters.AddWithValue("@giaBan", sanPham.giaBan);
                cmd.Parameters.AddWithValue("@giaNhap", sanPham.giaNhap);
                cmd.Parameters.AddWithValue("@mau", sanPham.mau);
                cmd.Parameters.AddWithValue("@maLoai", sanPham.maLoai);
                cmd.Parameters.AddWithValue("@img", sanPham.img);
                cmd.Parameters.AddWithValue("@maSP", sanPham.maSP);       
                if (cmd.ExecuteNonQuery () > 0)
                {
                    return true;
                }
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
        public bool deleteSanPham(SanPhamDTO sanPham)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE sanPham " +
                                                "SET tinhTrang = @tinhTrang " +
                                                "WHERE maSP = @maSP; "
                                                , _conn);
                cmd.Parameters.AddWithValue("@tinhTrang", sanPham.tinhTrang);
                cmd.Parameters.AddWithValue("@maSP", sanPham.maSP);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
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
        //"SELECT s.maSP, s.tenSP, s.giaBan, COALESCE(SUM(sk.soLuong), 0) AS soLuong, s.giaNhap, s.mau, s.maLoai " +
        //                                           "FROM sanPham s LEFT JOIN sanPham_KichCo sk ON s.maSP = sk.maSP " +
        //                                           "WHERE s.tinhTrang = 1 AND (maSP LIKE @search OR tenSP LIKE @search OR mau LIKE @search OR maLoai LIKE @search)" +
        //                                           "GROUP BY s.maSP, s.tenSP, s.giaBan, s.giaNhap, s.mau, s.maLoai;"
        public DataTable searchSanPham(string strSearch)
        {
            DataTable dt = new DataTable();
            string query = "SELECT s.maSP, s.tenSP, s.giaBan, COALESCE(SUM(sk.soLuong), 0) AS soLuong, s.img, s.giaNhap, s.mau, s.maLoai " +
                           "FROM sanPham s LEFT JOIN sanPham_KichCo sk ON s.maSP = sk.maSP " +
                           "WHERE s.tinhTrang = 1 AND (s.maSP LIKE @search OR s.tenSP LIKE @search OR s.mau LIKE @search OR s.maLoai LIKE @search)" +
                           "GROUP BY s.maSP, s.tenSP, s.giaBan, s.img, s.giaNhap, s.mau, s.maLoai;";

            using (SqlDataAdapter da = new SqlDataAdapter(query, _conn))
            {
                da.SelectCommand.Parameters.AddWithValue("@search", "%" + strSearch + "%");
                da.Fill(dt);

            }
            return dt;
        }
    }
}
