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
    public class ChiTietPhieuNhapDAL : DatabaseConnect
    {
        SqlConnection _conn = DatabaseConnect._conn;
        public DataTable getCTPN(String maPN, String tenSP, String mauSac, String kichCo, String giaNhap, bool checkedDown)
        {
            try
            {
                if(_conn.State != ConnectionState.Open) _conn.Open();

                String compare = checkedDown ? "<=" : ">=";

                String sql = @"SELECT sp.tenSP, sp.mau , kc.kichCo , cpn.soLuong, cpn.giaNhap 
                                FROM CT_PhieuNhap cpn 
                                INNER JOIN sanPham sp ON cpn.maSP = sp.maSP 
                                INNER JOIN kichCo kc ON cpn.maKichCo = kc.maKichCo 
                                WHERE cpn.tinhTrang = 1 
                                AND sp.tenSP LIKE @tenSP 
                                AND sp.mau LIKE @mauSac 
                                AND (@kichCo = '' OR kc.kichCo = @kichCo) 
                                AND cpn.giaNhap " + compare + @" @giaNhap 
                                AND cpn.maPN = @maPN";

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("STT");
                dataTable.Columns.Add("Sản phẩm");
                dataTable.Columns.Add("Màu sắc");
                dataTable.Columns.Add("Kích cỡ");
                dataTable.Columns.Add("Số lượng");
                dataTable.Columns.Add("Giá nhập");

                using(SqlCommand sqlCommand = new SqlCommand(sql, _conn))
                {
                    sqlCommand.Parameters.AddWithValue("@tenSP", "%" + tenSP + "%");
                    sqlCommand.Parameters.AddWithValue("@mauSac", "%" + mauSac + "%");
                    sqlCommand.Parameters.AddWithValue("@kichCo", kichCo);
                    sqlCommand.Parameters.AddWithValue("@giaNhap", giaNhap);
                    sqlCommand.Parameters.AddWithValue("@maPN", maPN);

                    using(SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        int stt = 1;

                        while (reader.Read())
                        {
                            DataRow row = dataTable.NewRow();
                            row["STT"] = stt;
                            row["Sản phẩm"] = reader.GetString(0);
                            row["Màu sắc"] = reader.GetString(1);
                            row["Kích cỡ"] = reader.GetInt32(2);
                            row["Số lượng"] = reader.GetInt32(3);
                            row["Giá nhập"] = reader.GetDouble(4);

                            dataTable.Rows.Add(row);
                            stt += 1;
                        }
                    }
                }

                return dataTable;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Lỗi lấy danh sách chi tiết phiếu nhập: " + ex.Message);
                return null;
            }
            finally
            {
                if(_conn.State == ConnectionState.Open) _conn.Close();
            }
        }

        public void ThemChiTietPhieuNhap(List<ChiTietPhieuNhapDTO> ctpns, int maPN)
        {
            try
            {
                if(_conn.State != ConnectionState.Open) _conn.Open();

                foreach (var chiTiet in ctpns)
                {
                    String sql = "INSERT INTO CT_PhieuNhap (maPN, maSP, makichCo, soLuong, giaNhap, thanhTien, tinhTrang) " +
                        "VALUES (@maPN, @maSP, @makichCo, @soLuong, @giaNhap, @thanhTien, @tinhTrang)";
                    
                    using (SqlCommand sqlCommand = new SqlCommand(sql, _conn))
                    {
                        sqlCommand.Parameters.AddWithValue("@maPN", maPN);
                        sqlCommand.Parameters.AddWithValue("@maSP", chiTiet.maSP);
                        sqlCommand.Parameters.AddWithValue("@makichCo", chiTiet.makichCo);
                        sqlCommand.Parameters.AddWithValue("@soLuong", chiTiet.soLuong);
                        sqlCommand.Parameters.AddWithValue("@giaNhap", chiTiet.giaNhap);
                        sqlCommand.Parameters.AddWithValue("@thanhTien", chiTiet.thanhTien);
                        sqlCommand.Parameters.AddWithValue("@tinhTrang", chiTiet.tinhTrang);

                        sqlCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Lỗi thêm chi tiết phiếu nhập: " + ex.Message); 
            }
            finally
            {
                if(_conn.State == ConnectionState.Open) _conn.Close();
            }
                
        }
    }
}
