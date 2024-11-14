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
        public DataTable getDSPN(String fromDate, String toDate, String nv, String ncc, String tongTien, bool checkDown)
        {
            try
            {   
                String compare = checkDown ? "<=" : ">=";

                String sSql = "SELECT pn.maPN, nv.tenNV, n.tenNCC, pn.ngayLap, pn.tongTien FROM phieuNhap pn " +
                                "INNER JOIN nhanVien nv ON pn.maNV = nv.maNV " +
                                "INNER JOIN ncc n ON pn.maNCC = n.maNCC " +
                                "WHERE pn.tinhTrang = 1 " +
                                $"AND nv.tenNV LIKE '%{nv}%' " +
                                $"AND n.tenNCC LIKE '%{ncc}%' " +
                                $"AND pn.tongTien {compare} '{tongTien}' " +
                                $"AND pn.ngayLap BETWEEN '{fromDate}' AND '{toDate}'";

                SqlDataReader reader = DatabaseConnect.queryData(sSql);

                DataTable dataTable = new DataTable();

                dataTable.Columns.Add("Mã PN");
                dataTable.Columns.Add("Nhân viên");
                dataTable.Columns.Add("Nhà cung cấp");
                dataTable.Columns.Add("Ngày lập");
                dataTable.Columns.Add("Tổng tiền");

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

                reader.Close();
                return dataTable;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }


        public int ThemPhieuNhap(PhieuNhapDTO phieuNhap)
        {
            try
            {
                String insertString = "INSERT INTO phieuNhap (maPN, maNV, maNCC, ngayLap, tongTien, tinhTrang) " +
                    "OUTPUT INSERTED.maPN VALUES (@maPN, @maNV, @maNCC, @ngayLap, @tongTien, @tinhTrang)";

                List<SqlParameter> parameters = new List<SqlParameter>();

                parameters.Add(new SqlParameter("@maPN", phieuNhap.maPN));
                parameters.Add(new SqlParameter("@maNV", phieuNhap.maNV));
                parameters.Add(new SqlParameter("@maNCC", phieuNhap.maNCC));
                parameters.Add(new SqlParameter("@ngayLap", phieuNhap.ngayLap));
                parameters.Add(new SqlParameter("@tongTien", phieuNhap.tongTien));
                parameters.Add(new SqlParameter("@tinhTrang", phieuNhap.tinhTrang));

                return DatabaseConnect.queryScalar(insertString, parameters); //Trả về maPN vừa tạo

            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi thêm phiếu nhập: " + ex.ToString());
                return 0;
            }
        }

        public int getMaxMaPN()
        {
            try
            {
                String queryString = "SELECT MAX(maPN) FROM phieuNhap";

                return DatabaseConnect.queryScalar(queryString, null);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy mã phiếu nhập lớn nhất: " + ex.Message);
                return -1;
            }
        }
    }
}
