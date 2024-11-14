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
        public DataTable getCTPN(String maPN, String tenSP, String mauSac, String kichCo, String giaNhap, bool checkedDown)
        {
            try
            {
                String compare = checkedDown ? "<=" : ">=";

                String sSql = "SELECT sp.tenSP, sp.mau , kc.kichCo , cpn.soLuong, cpn.giaNhap " +
                                "FROM CT_PhieuNhap cpn " +
                                "INNER JOIN sanPham sp ON cpn.maSP = sp.maSP " +
                                "INNER JOIN kichCo kc ON cpn.maKichCo = kc.maKichCo " +
                                "WHERE cpn.tinhTrang = 1 " +
                                $"AND sp.tenSP LIKE '%{tenSP}%' " +
                                $"AND sp.mau LIKE '%{mauSac}%' " +
                                $"AND ('{kichCo}' = '' OR kc.kichCo = '{kichCo}') " +
                                $"AND cpn.giaNhap {compare} '{giaNhap}' " +
                                $"AND cpn.maPN = {maPN}";

                SqlDataReader reader = DatabaseConnect.queryData(sSql);

                DataTable dataTable = new DataTable();

                //dataTable.Columns.Add("Mã PN");
                dataTable.Columns.Add("STT");
                dataTable.Columns.Add("Sản phẩm");
                dataTable.Columns.Add("Màu sắc");
                dataTable.Columns.Add("Kích cỡ");
                dataTable.Columns.Add("Số lượng");
                dataTable.Columns.Add("Giá nhập");

                int stt = 1;

                while (reader.Read())
                {
                    DataRow row = dataTable.NewRow();
                    //row["Mã PN"] = reader.GetInt32(0);
                    row["STT"] = stt;
                    row["Sản phẩm"] = reader.GetString(0);
                    row["Màu sắc"] = reader.GetString(1);
                    row["Kích cỡ"] = reader.GetInt32(2);
                    row["Số lượng"] = reader.GetInt32(3);
                    row["Giá nhập"] = reader.GetDouble(4);

                    dataTable.Rows.Add(row);
                    stt += 1;
                }

                reader.Close();
                return dataTable;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public void ThemChiTietPhieuNhap(List<ChiTietPhieuNhapDTO> ctpns, int maPN)
        {
            try
            {
                foreach (var chiTiet in ctpns)
                {
                    String sql = "INSERT INTO CT_PhieuNhap (maPN, maSP, makichCo, soLuong, giaNhap, thanhTien, tinhTrang) " +
                        "VALUES (@maPN, @maSP, @makichCo, @soLuong, @giaNhap, @thanhTien, @tinhTrang)";

                    List<SqlParameter> parameters = new List<SqlParameter>();

                    parameters.Add(new SqlParameter("@maPN", maPN));
                    parameters.Add(new SqlParameter("@maSP", chiTiet.maSP));
                    parameters.Add(new SqlParameter("@makichCo", chiTiet.makichCo));
                    parameters.Add(new SqlParameter("@soLuong", chiTiet.soLuong));
                    parameters.Add(new SqlParameter("@giaNhap", chiTiet.giaNhap));
                    parameters.Add(new SqlParameter("@thanhTien", chiTiet.thanhTien));
                    parameters.Add(new SqlParameter("@tinhTrang", chiTiet.tinhTrang));

                    DatabaseConnect.updateData(sql, parameters);
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
                
        }
    }
}
