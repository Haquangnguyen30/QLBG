using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DocumentFormat.OpenXml.Office.Word;
using System.Windows.Forms;

namespace DAL
{
    public class HoaDonDAL : DatabaseConnect
    {
        SqlConnection _conn = DatabaseConnect._conn;
        public DataTable getDSHD()
        {
            var cmd = new SqlCommand("SELECT hd.maHD, hd.maNV, kh.tenKH, hd.ngayLap, hd.tongTien, hd.tienGiam, hd.tienKhachDua, hd.tienThua, hd.tinhTrang FROM hoaDon hd JOIN khachHang kh ON hd.maKH=kh.maKH", _conn);
            var da = new SqlDataAdapter(cmd);
            var dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        // tạo hóa đơn
        public int TaoHoaDon(HoaDonDTO hoaDon)
        {
            try
            {
                // Chuỗi truy vấn với OUTPUT INSERTED.maHD để lấy mã hóa đơn vừa thêm
                string insertString = "INSERT INTO hoaDon (maNV, maKH, ngayLap, tongTien, maKM, tienGiam, tienKhachDua, tienThua,tinhTrang) " +
                                      "OUTPUT INSERTED.maHD VALUES (@maNV, @maKH, @ngayLap, @tongTien, @maKM, @tienGiam, @tienKhachDua, @tienThua,@tinhTrang)";

                // Tạo danh sách tham số
                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@maNV", hoaDon.maNV),
                    new SqlParameter("@maKH", hoaDon.maKH),
                    new SqlParameter("@ngayLap", hoaDon.ngayLap),
                    new SqlParameter("@tongTien", hoaDon.tongTien),
                    new SqlParameter("@maKM", hoaDon.maKM),
                    new SqlParameter("@tienGiam", hoaDon.tienGiam), 
                    new SqlParameter("@tienKhachDua", hoaDon.tienKhachDua),
                    new SqlParameter("@tienThua", hoaDon.tienThua),
                    new SqlParameter("@tinhTrang", hoaDon.tinhTrang)
                };

                // Gọi phương thức thực thi và lấy giá trị mã hóa đơn
                return DatabaseConnect.queryScalar(insertString, parameters);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi thêm hóa đơn: " + ex.Message);
                return 0; // Trả về 0 nếu xảy ra lỗi
            }
        }

        // lấy mã hóa đơn mới nhất
        public int GetMaHoaDonMoiNhat()
        {
            try
            {
                using (var cmd = new SqlCommand("SELECT TOP 1 maHD FROM hoaDon ORDER BY maHD DESC", _conn))
                {
                    _conn.Open();
                    var result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToInt32(result);
                    }


                    return -1;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return -1;
            }
            finally
            {
                _conn.Close();
            }
        }

        public DataTable TimKiemHoaDon(string key)
        {
            try
            {
                using (var cmd = new SqlCommand("SELECT hd.maHD, hd.maNV, kh.tenKH, hd.ngayLap, hd.tongTien, hd.tienGiam, hd.tienKhachDua, hd.tienThua, hd.tinhTrang FROM hoaDon hd JOIN khachHang kh ON hd.maKH=kh.maKH WHERE (hd.maHD LIKE @key OR hd.maNV LIKE @key OR hd.maKH LIKE @key)", _conn))
                {
                    cmd.Parameters.AddWithValue("@key", "%" + key + "%");
                    var da = new SqlDataAdapter(cmd);
                    var dt = new DataTable();
                    da.Fill(dt);

                    return dt;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                _conn.Close();
            }
        }

        public DataTable getHoaDonChuaDoi()
        {
            try
            {
                if (_conn.State != ConnectionState.Open) _conn.Open();

                String sql = "SELECT maHD, ngayLap FROM hoaDon WHERE tinhTrang = 1";

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("maHD");
                dataTable.Columns.Add("ngayLap");

                using (var cmd = new SqlCommand(sql, _conn))
                {
                    using (var da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dataTable);
                    }
                }

                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lấy danh sách hóa đơn có thể đổi hàng: {ex.Message}");
                return null;
            }
            finally
            {
                if (_conn.State == ConnectionState.Open)
                    _conn.Close(); // Đảm bảo đóng kết nối nếu nó đang mở
            }
        }

        public void updateTinhTrangHoaDon(String maHD)
        {
            try
            {
                if (_conn.State != ConnectionState.Open) _conn.Open();

                String sql = @"UPDATE hoaDon SET tinhTrang = 0 WHERE maHD = @maHD";

                using (SqlCommand cmd = new SqlCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@maHD", maHD);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                _conn.Close();
            }
        }

        public int getMaKMByMaHD(int maHD)
        {
            try
            {
                if (_conn.State != ConnectionState.Open) _conn.Open();

                String sql = @"SELECT maKM FROM hoaDon WHERE maHD = @maHD";

                using (SqlCommand cmd = new SqlCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@maHD", maHD);
                    return (int)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi lấy mã KM bằng mã HD: " + ex.Message);
                return 0;
            }
            finally
            {
                _conn.Close();
            }
        }
    }
}
