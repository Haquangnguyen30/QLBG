using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Windows.Forms;
using static NPOI.POIFS.Crypt.CryptoFunctions;

namespace DAL
{
    public class ChiTietHoaDonDAL : DatabaseConnect
    {
        public DataTable getDSCTHD()
        {
            var cmd = new SqlCommand("SELECT * FROM CT_HoaDon", _conn);
            var da = new SqlDataAdapter(cmd);
            var dt = new DataTable();

            da.Fill(dt);
            return dt;
        }
        public DataTable GetChiTietHoaDon(int maHD)
        {
            var cmd = new SqlCommand("SELECT HD.maHD, CTHD.maSP, SP.tenSP, SP.mau, KC.kichCo, CTHD.giaBan, CTHD.soLuong, CTHD.thanhTien FROM hoaDon HD JOIN CT_HoaDon CTHD ON HD.maHD = CTHD.maHD JOIN sanPham SP ON CTHD.maSP = SP.maSP JOIN kichCo KC ON CTHD.maKichCo = KC.maKichCo WHERE HD.maHD = @maHD", _conn);

            cmd.Parameters.AddWithValue("@maHD", maHD);
            var da = new SqlDataAdapter(cmd);
            var dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        // thêm chi tiết hóa đơn
        public void ThemChiTietHoaDon(List<ChiTietHoaDonDTO> chiTietHoaDons, int maHD)
        {
            try
            {
                foreach (var chiTiet in chiTietHoaDons)
                {
                    string sql = "INSERT INTO CT_HoaDon (maHD, maSP, giaBan, soLuong, thanhTien, tinhTrang, maKichCo) " +
                                 "VALUES (@maHD, @maSP, @giaBan, @soLuong, @thanhTien, @tinhTrang, @maKichCo)";

                    List<SqlParameter> parameters = new List<SqlParameter>
                    {
                        new SqlParameter("@maHD", maHD),
                        new SqlParameter("@maSP", chiTiet.maSP),
                        new SqlParameter("@giaBan", chiTiet.giaBan),
                        new SqlParameter("@soLuong", chiTiet.soLuong),
                        new SqlParameter("@thanhTien", chiTiet.thanhTien),
                        new SqlParameter("@tinhTrang", true),
                        new SqlParameter("@maKichCo", chiTiet.maKC),
                    };

                    DatabaseConnect.updateData(sql, parameters);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm chi tiết hóa đơn: " + ex.Message);
            }
        }

        public void updateSoLuongSauDoi(int maHD, String maSP, int maKC, int slGiuLai, float thanhTien)
        {
            try
            {
                if (_conn.State != ConnectionState.Open) _conn.Open();

                String sql = "UPDATE CT_HoaDon SET soLuong = @slGiuLai, thanhTien = @thanhTien " +
                                        "WHERE maHD = @maHD AND maSP = @maSP AND maKichCo = @maKC";

                using (SqlCommand sqlCommand = new SqlCommand(sql, _conn))
                {
                    sqlCommand.Parameters.AddWithValue("@slGiuLai", slGiuLai);
                    sqlCommand.Parameters.AddWithValue("@thanhTien", thanhTien);
                    sqlCommand.Parameters.AddWithValue("@maHD", maHD);
                    sqlCommand.Parameters.AddWithValue("@maSP", maSP);
                    sqlCommand.Parameters.AddWithValue("@maKC", maKC);

                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật số lượng sau khi đổi: " + ex.Message);
            }
            finally
            {
                if (_conn.State == ConnectionState.Open) _conn.Close();
            }
        }

        public void deleteSoLuongSauDoi(int maHD, String maSP, int maKC)
        {
            try
            {
                if (_conn.State != ConnectionState.Open) _conn.Open();

                String sql = "DELETE FROM CT_HoaDon " +
                            "WHERE maHD = @maHD AND maSP = @maSP AND maKichCo = @maKC";

                using (SqlCommand sqlCommand = new SqlCommand(sql, _conn))
                {
                    sqlCommand.Parameters.AddWithValue("@maHD", maHD);
                    sqlCommand.Parameters.AddWithValue("@maSP", maSP);
                    sqlCommand.Parameters.AddWithValue("@maKC", maKC);

                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa số lượng sau khi đổi: " + ex.Message);
            }
            finally
            {
                if (_conn.State == ConnectionState.Open) _conn.Close();
            }
        }
    }
}
