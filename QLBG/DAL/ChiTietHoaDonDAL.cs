using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

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
            var cmd = new SqlCommand("SELECT HD.maHD, CTHD.maSP, SP.tenSP,SP.mau, CTHD.giaBan, CTHD.soLuong, CTHD.thanhTien FROM hoaDon HD JOIN CT_HoaDon CTHD ON HD.maHD = CTHD.maHD JOIN sanPham SP ON CTHD.maSP = SP.maSP WHERE HD.maHD = @maHD", _conn);

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
                    string sql = "INSERT INTO CT_HoaDon (maHD, maSP, giaBan, soLuong, thanhTien, maSPDoi, tinhTrangDoi, maKichCo) " +
                                 "VALUES (@maHD, @maSP, @giaBan, @soLuong, @thanhTien, @maSPDoi, @tinhTrangDoi, @maKichCo)";

                    List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@maHD", maHD),
                new SqlParameter("@maSP", chiTiet.maSP),
                new SqlParameter("@giaBan", chiTiet.giaBan),
                new SqlParameter("@soLuong", chiTiet.soLuong),
                new SqlParameter("@thanhTien", chiTiet.thanhTien),
                new SqlParameter("@maSPDoi",chiTiet.maSP),
                new SqlParameter("@tinhTrangDoi", true),
                new SqlParameter("@maKichCo", chiTiet.maKC),
            };

                    DatabaseConnect.updateData(sql, parameters);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi thêm chi tiết hóa đơn: " + ex.Message);
            }
        }

    }
}
