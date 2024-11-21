using DTO;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KhuyenMaiDAL : DatabaseConnect
    {
        public List<KhuyenMaiDTO> getList()
        {
            try
            {
                _conn.Open();
                string sql = "select * from khuyenMai";
                List<KhuyenMaiDTO> list = new List<KhuyenMaiDTO>();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    KhuyenMaiDTO km = new KhuyenMaiDTO();
                    string MaKhuyenMaistr = reader["maKM"].ToString();
                    int MaKhuyenMai;
                    if (int.TryParse(MaKhuyenMaistr, out MaKhuyenMai))
                    {
                        km.maKM = MaKhuyenMai;
                    }
                    km.tenKM = reader["tenKM"].ToString();
                    km.giaTriGiam= reader.GetInt32(reader.GetOrdinal("giaTriGiam"));
                    string ngayBatDaustr = reader["ngayBD"].ToString();
                    string dateFormat = "dd/MM/yyyy"; // Định dạng ngày tháng
                    DateTime ngayBD;

                    if (DateTime.TryParseExact(ngayBatDaustr, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out ngayBD))
                    {
                        km.ngayBatDau = ngayBD;
                    }
                    string ngayKetThucstr = reader["ngayKT"].ToString();
                    DateTime ngayKT;

                    if (DateTime.TryParseExact(ngayKetThucstr, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out ngayKT))
                    {
                        km.ngayKetThuc = ngayBD;
                    }

                    list.Add(km);
                }

                reader.Close();
                _conn.Close();
                return list;

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;

        }
        public System.Data.DataTable getKhuyenMai()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM khuyenMai where tinhTrang = 1 ", _conn);
            System.Data.DataTable dtKhuyenMai = new System.Data.DataTable();
            adapter.Fill(dtKhuyenMai);
            return dtKhuyenMai;
        }

        public bool ThemKhuyenMai(KhuyenMaiDTO km)
        {
            try
            {
                // Mở kết nối đến CSDL
                _conn.Open();

                // Tạo câu SQL để thêm dữ liệu vào bảng "khuyenMai"
                string SQL = "INSERT INTO khuyenMai (maKM, tenKM,giaTriGiam, ngayBD, ngayKT,tinhTrang) VALUES (@maKM, @tenKM,@giaTriGiam, @ngayBD, @ngayKT,@tinhTrang)";

                // Tạo đối tượng SqlCommand
                using (SqlCommand cmd = new SqlCommand(SQL, _conn))
                {
                    // Thêm tham số để tránh SQL Injection và lỗi định dạng ngày tháng
                    cmd.Parameters.AddWithValue("@maKM", km.maKM);
                    cmd.Parameters.AddWithValue("@tenKM", km.tenKM);
                    cmd.Parameters.AddWithValue("@giaTriGiam", km.giaTriGiam);
                    cmd.Parameters.AddWithValue("@ngayBD", SqlDbType.DateTime).Value = km.ngayBatDau;
                    cmd.Parameters.AddWithValue("@ngayKT", SqlDbType.DateTime).Value = km.ngayKetThuc;
                    cmd.Parameters.AddWithValue("@tinhTrang", true);
                    // Thực thi câu lệnh SQL và kiểm tra
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception e)
            {
                // Xử lý lỗi (có thể in thông báo lỗi hoặc ghi vào file log)
                Console.WriteLine("Lỗi: " + e.Message);
            }
            finally
            {
                // Đóng kết nối CSDL
                _conn.Close();
            }

            return false;
        }

        public bool SuaKhuyenMai(KhuyenMaiDTO khuyenMai)
        {
            try
            {
                // Mở kết nối đến CSDL
                _conn.Open();

                // Câu SQL để cập nhật thông tin khuyến mãi
                string SQL = "UPDATE khuyenMai SET tenKM = @tenKM,giaTriGiam=@giaTriGiam, ngayBD = @ngayBD, ngayKT = @ngayKT,tinhTrang=@tinhTrang WHERE maKM = @maKM";

                // Tạo đối tượng SqlCommand
                using (SqlCommand cmd = new SqlCommand(SQL, _conn))
                {
                    // Sử dụng tham số để an toàn truyền giá trị vào câu SQL
                    cmd.Parameters.AddWithValue("@maKM", khuyenMai.maKM);
                    cmd.Parameters.AddWithValue("@tenKM", khuyenMai.tenKM);
                    cmd.Parameters.AddWithValue("@giaTriGiam", khuyenMai.giaTriGiam);
                    cmd.Parameters.AddWithValue("@ngayBD", SqlDbType.DateTime).Value = khuyenMai.ngayBatDau;
                    cmd.Parameters.AddWithValue("@ngayKT", SqlDbType.DateTime).Value = khuyenMai.ngayKetThuc;
                    cmd.Parameters.AddWithValue("@tinhTrang", khuyenMai.tinhTrang);

                    // Thực hiện câu lệnh SQL UPDATE
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                        return true;
                }
            }
            catch (Exception e)
            {
                // Xử lý lỗi ở đây hoặc ghi vào file log.
            }
            finally
            {
                // Đóng kết nối CSDL
                _conn.Close();
            }

            return false;
        }
        public bool XoaKhuyenMai(int maKhuyenMai)
        {
            try
            {
                // Tạo câu SQL với tham số
                string SQL = "UPDATE khuyenMai SET tinhTrang = @tinhTrang WHERE maKM = @maKM";

                // Sử dụng `using` để đảm bảo tài nguyên được giải phóng
                using (SqlCommand cmd = new SqlCommand(SQL, _conn))
                {
                    // Thêm tham số
                    cmd.Parameters.AddWithValue("@tinhTrang", false);
                    cmd.Parameters.AddWithValue("@maKM", maKhuyenMai);

                    // Mở kết nối
                    if (_conn.State != ConnectionState.Open)
                        _conn.Open();

                    // Thực thi câu lệnh SQL và kiểm tra kết quả
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception e)
            {
                // Log lỗi (tuỳ thuộc vào framework logging bạn sử dụng)
                Console.WriteLine($"Lỗi: {e.Message}");
            }
            finally
            {
                // Đảm bảo kết nối được đóng
                if (_conn.State == ConnectionState.Open)
                    _conn.Close();
            }

            return false;
        }
    }
}
