using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class PhieuNhapDAL : DatabaseConnect
    {
        SqlConnection _conn = DatabaseConnect._conn;
        public DataTable getDSPN(String fromDate, String toDate, String nv, String ncc, String tongTien, bool checkDown)
        {
            try
            {   
                if(_conn.State != ConnectionState.Open) _conn.Open();

                String compare = checkDown ? "<=" : ">=";

                String sql = @"SELECT pn.maPN, nv.tenNV, n.tenNCC, pn.ngayLap, pn.tongTien FROM phieuNhap pn 
                                INNER JOIN nhanVien nv ON pn.maNV = nv.maNV 
                                INNER JOIN ncc n ON pn.maNCC = n.maNCC 
                                WHERE pn.tinhTrang = 1 
                                AND nv.tenNV LIKE @nv 
                                AND n.tenNCC LIKE @ncc
                                AND pn.tongTien " + compare + @" @tongTien
                                AND pn.ngayLap BETWEEN @fromDate AND @toDate";

                DataTable dataTable = new DataTable();

                dataTable.Columns.Add("Mã PN");
                dataTable.Columns.Add("Nhân viên");
                dataTable.Columns.Add("Nhà cung cấp");
                dataTable.Columns.Add("Ngày lập");
                dataTable.Columns.Add("Tổng tiền");

                using (SqlCommand sqlCommand = new SqlCommand(sql, _conn))
                {
                    sqlCommand.Parameters.AddWithValue("@nv", "%" + nv + "%");
                    sqlCommand.Parameters.AddWithValue("@ncc", "%" + ncc + "%");
                    sqlCommand.Parameters.AddWithValue("@tongTien", tongTien.Replace(",", ""));
                    sqlCommand.Parameters.AddWithValue("@fromDate", fromDate);
                    sqlCommand.Parameters.AddWithValue("@toDate", toDate);

                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DataRow row = dataTable.NewRow();
                            row["Mã PN"] = reader.GetInt32(0);
                            row["Nhân viên"] = reader.GetString(1);
                            row["Nhà cung cấp"] = reader.GetString(2);
                            row["Ngày lập"] = reader.GetDateTime(3).ToString("yyyy-MM-dd");
                            row["Tổng tiền"] = reader.GetDouble(4).ToString("N0");

                            dataTable.Rows.Add(row);
                        }
                    }
                }
                return dataTable;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Lỗi lấy danh sách phiếu nhập: " + ex.Message);
                return null;
            }
            finally
            {
                if(_conn.State == ConnectionState.Open) _conn.Close();
            }
        }


        public int ThemPhieuNhap(PhieuNhapDTO phieuNhap)
        {
            try
            {
                if(_conn.State == ConnectionState.Closed) _conn.Open();

                String sql = "INSERT INTO phieuNhap (maPN, maNV, maNCC, ngayLap, tongTien, tinhTrang) " +
                    "OUTPUT INSERTED.maPN VALUES (@maPN, @maNV, @maNCC, @ngayLap, @tongTien, @tinhTrang)";

                using(SqlCommand sqlCommand = new SqlCommand(sql, _conn))
                {
                    sqlCommand.Parameters.AddWithValue("@maPN", phieuNhap.maPN);
                    sqlCommand.Parameters.AddWithValue("@maNV", phieuNhap.maNV);
                    sqlCommand.Parameters.AddWithValue("@maNCC", phieuNhap.maNCC);
                    sqlCommand.Parameters.AddWithValue("@ngayLap", phieuNhap.ngayLap);
                    sqlCommand.Parameters.AddWithValue("@tongTien", phieuNhap.tongTien);
                    sqlCommand.Parameters.AddWithValue("@tinhTrang", phieuNhap.tinhTrang);

                    return (int)sqlCommand.ExecuteScalar();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi thêm phiếu nhập: " + ex.ToString());
                return 0;
            }
            finally
            {
                if(_conn.State == ConnectionState.Open) _conn.Close();
            }
        }

        public int getMaxMaPN()
        {
            try
            {
                if (_conn.State != ConnectionState.Open) _conn.Open ();

                String sql = "SELECT MAX(maPN) FROM phieuNhap";

                using(SqlCommand sqlCommand = new SqlCommand(sql, _conn))
                {
                    return (int) sqlCommand.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy mã phiếu nhập lớn nhất: " + ex.Message);
                return -1;
            }
            finally
            {
                if(_conn.State == ConnectionState.Open) _conn.Close ();
            }
        }
    }
}
