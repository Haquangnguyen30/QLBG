using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using System.Windows.Forms;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace DAL
{
    public class NhanVienDAL:DatabaseConnect
    {

        public List<String> getDSNV()
        {
            List<String> list = new List<String>();
            String sSql = "select maNV from NhanVien where chucVu like '%Nhân viên%' order by maNV";
            _conn.Open();
            if (_conn.State == ConnectionState.Closed)
            {
                //MessageBox.Show("Không thể kết nối DATABASE");
                return null;
            }
            SqlCommand sqlCommand = new SqlCommand(sSql, _conn);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                list.Add(reader.GetString(0));
            }
            reader.Close();
            _conn.Close();
            return list;
        }

        public List<NhanVienDTO> getList()
        {
            try
            {
                _conn.Open();
                string sql = "select * from nhanVien";
                List<NhanVienDTO> list = new List<NhanVienDTO>();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    NhanVienDTO nv = new NhanVienDTO();
                    nv.maNV = reader["maNV"].ToString();
                    nv.tenNV = reader["tenNV"].ToString();
                    nv.gioiTinh = reader["gioiTinh"].ToString();
                    nv.sdt = reader["sdt"].ToString();
                    nv.diaChi = reader["DIACHI"].ToString();
                    nv.chucVu = reader["chucVu"].ToString();
                    nv.ngaySinh = reader["ngaySinh"].ToString();
                    nv.tinhTrang = reader.GetBoolean(reader.GetOrdinal("tinhTrang"));
                    list.Add(nv);
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

        public DataTable getNhanVien()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT maNV, tenNV, gioiTinh, sdt, diaChi, chucVu, ngaySinh FROM nhanVien WHERE tinhTrang = 1", _conn);
            DataTable dtThanhvien = new DataTable();

            da.Fill(dtThanhvien);
            return dtThanhvien;
        }

        public DataTable getFindThanhVien(string key)
        {
            DataTable dtThanhvien = new DataTable();
            using (SqlConnection connection = new SqlConnection(_conn.ConnectionString))
            {
                connection.Open();
                string sqlQuery = "SELECT  maNV, tenNV, gioiTinh, sdt, diaChi, chucVu, ngaySinh FROM nhanVien WHERE tinhTrang = 1 AND (maNV LIKE @key OR tenNV LIKE @key OR sdt LIKE @key OR chucVu LIKE @key OR ngaySinh LIKE @key )";
                SqlDataAdapter da;
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@key", "%" + key + "%");
                    da = new SqlDataAdapter(command);

                }
                da.Fill(dtThanhvien);
            }

            return dtThanhvien;
        }

        public bool themNhanVien(NhanVienDTO tv)
        {
            try
            {
                // Ket noi
                _conn.Open();

              
                string SQL =
                string.Format("INSERT INTO nhanVien( maNV, tenNV, gioiTinh, sdt, diaChi, chucVu, ngaySinh, tinhTrang) VALUES ('{0}', N'{1}', '{2}', '{3}', N'{4}', N'{5}', '{6}', '{7}')"
                , tv.maNV, tv.tenNV, tv.gioiTinh, tv.sdt, tv.diaChi, tv.chucVu, tv.ngaySinh, tv.tinhTrang);

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

        public bool suaNhanVien(NhanVienDTO nv)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string to update the "tinhTrang" column to 'False' for the specified "maNV"
                string SQL = string.Format("UPDATE nhanVien SET tenNV = @tenNV, gioiTinh = @gioiTinh, sdt = @sdt, diaChi = @diaChi, chucVu =@chucVu, ngaySinh = @ngaySinh  WHERE maNV = @maNV");

                // Create a SqlCommand object
                using (SqlCommand cmd = new SqlCommand(SQL, _conn))
                {
                    // Use parameters to safely pass values into the SQL statement
                    cmd.Parameters.AddWithValue("@maNV", nv.maNV);
                    cmd.Parameters.AddWithValue("@tenNV", nv.tenNV);
                    cmd.Parameters.AddWithValue("@gioiTinh", nv.gioiTinh);
                    cmd.Parameters.AddWithValue("@sdt", nv.sdt);
                    cmd.Parameters.AddWithValue("@diaChi", nv.diaChi);
                    cmd.Parameters.AddWithValue("@chucVu", nv.chucVu);
                    cmd.Parameters.AddWithValue("@ngaySinh", nv.ngaySinh);
                   
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

        public bool xoaNhanVien(string maNV)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string to update the "tinhTrang" column to 'False' for the specified "maNV"
                string SQL = string.Format("UPDATE nhanVien SET tinhTrang = 'False' WHERE maNV = @maNV");

                // Create a SqlCommand object
                using (SqlCommand cmd = new SqlCommand(SQL, _conn))
                {
                    // Use parameters to safely pass values into the SQL statement
                    cmd.Parameters.AddWithValue("@maNV", maNV);

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

        public bool capNhapChucVu(string maNV,string chucVu)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string to update the "tinhTrang" column to 'False' for the specified "maNV"
                string SQL = string.Format("UPDATE nhanVien SET chucVu =@chucVu WHERE maNV = @maNV");

                // Create a SqlCommand object
                using (SqlCommand cmd = new SqlCommand(SQL, _conn))
                {
                    // Use parameters to safely pass values into the SQL statement
                    cmd.Parameters.AddWithValue("@maNV", maNV);                   
                    cmd.Parameters.AddWithValue("@chucVu", chucVu);


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

        public int ThemDS()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel files (*.xlsx; *.xls)|*.xlsx; *.xls";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //try
                //{
                    string fileName = openFileDialog.FileName;
                    FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read);

                    XSSFWorkbook workbook = new XSSFWorkbook(file);
                    XSSFSheet sheet = (XSSFSheet)workbook.GetSheetAt(0);
                    _conn.Open();


                    string sql = "MERGE INTO nhanVien AS target "
                               + "USING (VALUES (@maNV, @tenNV, @gioiTinh ,@sdt, @diaChi, @chucVu, @ngaySinh, @tinhTrang)) AS source (maNV, tenNV, gioiTinh, sdt, diaChi, chucVu,  ngaySinh, tinhTrang) "
                               + "ON (target.maNV = source.maNV) "
                               + "WHEN MATCHED THEN "
                               + "    UPDATE SET target.tenNV = source.tenNV, "
                               + "               target.gioiTinh = source.gioiTinh, "
                               + "               target.sdt = source.sdt, "
                               + "               target.diaChi = source.diaChi, "
                               + "               target.chucVu = source.chucVu, "
                               + "               target.ngaySinh = source.ngaySinh, "
                               + "               target.tinhTrang = source.tinhTrang "
                               + "WHEN NOT MATCHED THEN "
                               + "    INSERT (maNV, tenNV, gioiTinh, sdt, diaChi, chucVu, ngaySinh, tinhTrang) "
                               + "    VALUES (source.maNV, source.tenNV, source.gioiTinh, source.sdt, source.diaChi, source.chucVu, source.ngaySinh, source.tinhTrang);";

                    SqlCommand command = new SqlCommand(sql, _conn);

                    for (int i = sheet.FirstRowNum + 1; i <= sheet.LastRowNum; i++)
                    {
                        IRow row = sheet.GetRow(i);
                        if (row == null)
                        {
                            continue;
                        }

                        command.Parameters.AddWithValue("@maNV", row.GetCell(1).StringCellValue);
                        command.Parameters.AddWithValue("@tenNV", row.GetCell(2).StringCellValue);
                        command.Parameters.AddWithValue("@gioiTinh", row.GetCell(3).StringCellValue);
                        command.Parameters.AddWithValue("@sdt", row.GetCell(4).StringCellValue);
                        command.Parameters.AddWithValue("@diaChi", row.GetCell(5).StringCellValue);
                        command.Parameters.AddWithValue("@chucVu", row.GetCell(6).StringCellValue);
                        DateTime ngaySinh = DateTime.Parse(row.GetCell(7).StringCellValue);
                        command.Parameters.AddWithValue("@ngaySinh", ngaySinh);
                        command.Parameters.AddWithValue("@tinhTrang", true);

                        command.ExecuteNonQuery();
                        command.Parameters.Clear();
                    }

                    // Đóng tất cả tài nguyên
                    command.Dispose();
                    _conn.Close();
                    workbook.Close();
                    file.Close();

                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show("Thêm thất bại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
            }

            return 0;
        }

        public SqlDataReader getDSTenNV()
        {
            try
            {
                String sSql = "SELECT nv.maNV, nv.tenNV FROM nhanVien nv WHERE nv.tinhTrang = 1";
                SqlDataReader reader = DatabaseConnect.queryData(sSql);

                return reader;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi lấy danh sách tên nhân viên: " + ex.ToString());
                return null;
            }
        }


    }
}
