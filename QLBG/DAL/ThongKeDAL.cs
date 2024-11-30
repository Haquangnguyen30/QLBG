using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class ThongKeDAL : DatabaseConnect
    {
        public List<ThongKeNgayDTO> getDSThongKeHoaDonTheoNgay(String fromDate, String toDate)
        {
            try
            {
                _conn.Open();
                String sSql = "SELECT CAST(hd.ngayLap AS DATE) AS Ngay, SUM(hd.tongTien) AS TongTien " +
                                $"FROM hoaDon hd " +
                                $"WHERE hd.ngayLap BETWEEN '{fromDate}' AND '{toDate}' " +
                                "GROUP BY CAST(hd.ngayLap AS DATE) " + 
                                "ORDER BY Ngay";  
                
                SqlDataReader reader = DatabaseConnect.queryData(sSql);

                List<ThongKeNgayDTO> tkhdList = new List<ThongKeNgayDTO>();

                while (reader.Read())
                {
                    ThongKeNgayDTO tkhd = new ThongKeNgayDTO();
                    tkhd.ngayLap = reader.GetDateTime(0).Date;  
                    tkhd.tongTien = reader.GetDouble(1);  
                    tkhdList.Add(tkhd);
                }

                DateTime fromDateTime = DateTime.ParseExact(fromDate, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                DateTime toDateTime = DateTime.ParseExact(toDate, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                
                List<DateTime> allDays = Enumerable.Range(0, (toDateTime - fromDateTime).Days + 1)
                                                    .Select(d => fromDateTime.AddDays(d))
                                                    .ToList();
                foreach (var day in allDays)
                {
                    if (!tkhdList.Any(t => t.ngayLap == day.Date))
                    {
                        tkhdList.Add(new ThongKeNgayDTO
                        {
                            ngayLap = day,
                            tongTien = 0 
                        });
                    }
                }
                return tkhdList.OrderBy(tk => tk.ngayLap).ToList();
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


        public List<ThongKeNgayDTO> getDSThongKePhieuNhapTheoNgay(String fromDate, String toDate)
        {
            try
            {
                _conn.Open();
                string query = "SELECT CAST(pn.ngayLap AS DATE) AS Ngay, SUM(pn.tongTien) AS TongTien " +
                               "FROM phieuNhap pn " +
                               $"WHERE pn.ngayLap BETWEEN '{fromDate}' AND '{toDate}' " +
                               "GROUP BY CAST(pn.ngayLap AS DATE) " +
                               "ORDER BY Ngay"; 
                SqlDataReader reader = DatabaseConnect.queryData(query);

                List<ThongKeNgayDTO> tkpnList = new List<ThongKeNgayDTO>();

                while (reader.Read())
                {
                    ThongKeNgayDTO tkpn = new ThongKeNgayDTO();
                    tkpn.ngayLap = reader.GetDateTime(0).Date; 
                    tkpn.tongTien = reader.GetDouble(1) ;
                    tkpnList.Add(tkpn);
                }

                DateTime fromDateTime = DateTime.ParseExact(fromDate, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                DateTime toDateTime = DateTime.ParseExact(toDate, "yyyy-MM-dd", CultureInfo.InvariantCulture);

                List<DateTime> allDays = Enumerable.Range(0, (toDateTime - fromDateTime).Days + 1)
                                                    .Select(d => fromDateTime.AddDays(d))
                                                    .ToList();

                foreach (var day in allDays)
                {
                    if (!tkpnList.Any(t => t.ngayLap == day.Date))
                    {
                        tkpnList.Add(new ThongKeNgayDTO
                        {
                            ngayLap = day,
                            tongTien = 0 
                        });
                    }
                }

                return tkpnList.OrderBy(tk => tk.ngayLap).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy danh sách thống kê phiếu nhập: " + ex.Message);
                return null;
            }
            finally
            {
                _conn.Close();
            }
        }

        public List<ThongKeThangDTO> getThongKeHoaDonTheoThang(String fromDate, String toDate)
        {
            try
            {
                _conn.Open();
                string sSql = "SELECT MONTH(hd.ngayLap) AS Thang, SUM(hd.tongTien) AS TongTien " +
                              "FROM hoaDon hd " +
                              $"WHERE hd.ngayLap BETWEEN '{fromDate}' AND '{toDate}' " +
                              "GROUP BY MONTH(hd.ngayLap) " +
                              "ORDER BY Thang";
               
                SqlCommand command = new SqlCommand(sSql, _conn);
                command.Parameters.AddWithValue("@fromDate", fromDate);
                command.Parameters.AddWithValue("@toDate", toDate);

                SqlDataReader reader = command.ExecuteReader();
                List<ThongKeThangDTO> thongKeTheoThang = new List<ThongKeThangDTO>();

                while (reader.Read())
                {
                    thongKeTheoThang.Add(new ThongKeThangDTO
                    {
                        thang = reader.GetInt32(0),       
                        tongTien = reader.GetDouble(1) 
                    });
                }

                reader.Close();

                for (int i = 1; i <= 12; i++)
                {
                    if (!thongKeTheoThang.Any(tk => tk.thang == i))
                    {
                        thongKeTheoThang.Add(new ThongKeThangDTO
                        {
                            thang = i,
                            tongTien = 0
                        });
                    }
                }
                return thongKeTheoThang.OrderBy(tk => tk.thang).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thống kê hóa đơn theo tháng: " + ex.Message);
                return new List<ThongKeThangDTO>(); 
            }
            finally
            {
                
                _conn.Close(); 
                
            }
        }

        public List<ThongKeThangDTO> getThongKePhieuNhapTheoThang(String fromDate, String toDate)
        {
            try
            {
                _conn.Open();
                String sSql = "SELECT MONTH(pn.ngayLap) AS Thang, SUM(pn.tongTien) AS TongTien " +
                              "FROM phieuNhap pn " +
                              $"WHERE pn.ngayLap BETWEEN '{fromDate}' AND '{toDate}' " +
                              "GROUP BY MONTH(pn.ngayLap) " +
                              "ORDER BY Thang";

                SqlCommand command = new SqlCommand(sSql, _conn);
                command.Parameters.AddWithValue("@fromDate", fromDate);
                command.Parameters.AddWithValue("@toDate", toDate);

                SqlDataReader reader = command.ExecuteReader();
                List<ThongKeThangDTO> thongKeTheoThang = new List<ThongKeThangDTO>();

                while (reader.Read())
                {
                    thongKeTheoThang.Add(new ThongKeThangDTO
                    {
                        thang = reader.GetInt32(0),      
                        tongTien = reader.GetDouble(1)  
                    });
                }

                reader.Close();

                for (int i = 1; i <= 12; i++)
                {
                    if (!thongKeTheoThang.Any(tk => tk.thang == i))
                    {
                        thongKeTheoThang.Add(new ThongKeThangDTO
                        {
                            thang = i,
                            tongTien = 0
                        });
                    }
                }

                return thongKeTheoThang.OrderBy(tk => tk.thang).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thống kê phiếu nhập theo tháng: " + ex.Message);
                return new List<ThongKeThangDTO>();
            }
            finally
            {
                _conn.Close();
            }
        }

        public List<ThongKeSanPhamDTO> GetTop5SanPhamBanChay(String fromDate, String toDate)
        {
            try
            {
                _conn.Open();
                String sSql = "SELECT TOP 5 " +
                              "sp.tenSP, " +
                              "SUM(cthd.soLuong) AS tongSoLuongBan, " +
                              "sp.img " +
                              "FROM QLBG.dbo.CT_HoaDon cthd " +
                              "JOIN QLBG.dbo.hoaDon hd ON cthd.maHD = hd.maHD " +
                              "JOIN QLBG.dbo.sanPham sp ON cthd.maSP = sp.maSP " +
                              $"WHERE hd.ngayLap BETWEEN '{fromDate}' AND '{toDate}' " +
                              "GROUP BY sp.tenSP, sp.giaBan, sp.img " +
                              "ORDER BY tongSoLuongBan DESC;";
                SqlCommand cmd = new SqlCommand(sSql, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                List<ThongKeSanPhamDTO> resultList = new List<ThongKeSanPhamDTO>();
                while (reader.Read())
                {
                    ThongKeSanPhamDTO dto = new ThongKeSanPhamDTO
                    {
                        tenSP = reader.GetString(0),
                        soLuongDaBan = reader.GetInt32(1),
                        hinhAnh = ""
                    };
                    resultList.Add(dto);
                }
                return resultList;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lấy danh sách sản phẩm bán chạy từ {fromDate} đến {toDate}: {ex.Message}");
                return null;
            }
            finally
            {
                _conn.Close();
            }
        }

    }

}

