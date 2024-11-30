using BLL;
using DocumentFormat.OpenXml.Spreadsheet;
using DTO;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI.UserControls
{
    public partial class UC_ThongKe : UserControl
    {
        private ThongKeBUS thongKeBUS = new ThongKeBUS();

        public UC_ThongKe()
        {
            InitializeComponent();
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ThongKeTheo12Thang();
        }

        private void ThongKeTheo12Thang()
        {
            try
            {
                DateTime fromDate = new DateTime(2024, 1, 1);
                DateTime toDate = new DateTime(2024, 12, 31);

                string fromDateString = fromDate.ToString("yyyy-MM-dd");
                string toDateString = toDate.ToString("yyyy-MM-dd");

                List<ThongKeThangDTO> thongKehdthang = thongKeBUS.getThongKeHoaDonTheoThang(fromDateString, toDateString);
                List<ThongKeThangDTO> thongKepnthang = thongKeBUS.getThongKePhieuNhapTheoThang(fromDateString, toDateString);
                List<ThongKeSanPhamDTO> thongKeSanPham = thongKeBUS.GetTop5SanPhamBanChay(fromDateString, toDateString);
                


                ConfigureChart12Thang(thongKehdthang, thongKepnthang);
                Show5SanPham(thongKeSanPham);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Show5SanPham(List<ThongKeSanPhamDTO> thongKeSanPham)
        {
            try
            {
                Panel[] sanPhamPanels = { top1, top2, top3, top4, top5 };
                Label[] tenSanPham = { tenSP1, tenSP2, tenSP3, tenSP4, tenSP5 };
                Label[] soLuongDaBan = { soLuongBanRa1, soLuongBanRa2, soLuongBanRa3, soLuongBanRa4, soLuongBanRa5 };
                PictureBox[] hinhAnh = { pictureBox1,pictureBox2, pictureBox3, pictureBox4, pictureBox5 };

                for (int i = 0; i < 5; i++)
                {
                    sanPhamPanels[i].Visible = false;
                    tenSanPham[i].Visible = false;
                    soLuongDaBan[i].Visible = false;
                    hinhAnh[i].Visible = false;
                }
                if (thongKeSanPham != null && thongKeSanPham.Count > 0)
                {
                    int maxProductsToShow = Math.Min(thongKeSanPham.Count, 5);
                        for (int i = 0; i < maxProductsToShow; i++)
                    {
                        ThongKeSanPhamDTO product = thongKeSanPham[i];
                        sanPhamPanels[i].Visible = true;
                        tenSanPham[i].Visible = true;
                        soLuongDaBan[i].Visible = true;
                        hinhAnh[i].Visible = true;

                        //hinhAnh[i].ImageLocation = product.hinhAnh;
                        hinhAnh[i].SizeMode = PictureBoxSizeMode.Zoom;

                        tenSanPham[i].Text = product.tenSP;
                        soLuongDaBan[i].Text = "Số lượng đã bán: " + product.soLuongDaBan.ToString();

                        string imageFileName = product.hinhAnh;
                        string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
                        string imagePath = Path.Combine(projectDirectory, @"..\..\..\GUI\Resources\ImgSanPham", imageFileName);
                        try
                        {
                            hinhAnh[i].Image = new Bitmap(imagePath);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error loading image: {ex.Message}");
                            hinhAnh[i].Image = null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hiển thị sản phẩm: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ThongKeTheo7Ngay(DateTime? homnay)
        {
            try
            {
                DateTime fromDate ;
                DateTime toDate ;
                if (homnay == null)
                {
                    fromDate = chonNgay.Value.Date;
                    toDate = fromDate.AddDays(7);
                }
                else
                {
                    fromDate = homnay.Value.Date;
                    toDate = fromDate.AddDays(7);
                }
                 

                string fromDateString = fromDate.ToString("yyyy-MM-dd");
                string toDateString = toDate.ToString("yyyy-MM-dd");

                List<ThongKeNgayDTO> thongKehdngay = thongKeBUS.GetThongKeHoaDonTheoNgay(fromDateString, toDateString);
                List<ThongKeNgayDTO> thongKepnngay = thongKeBUS.GetThongKePhieuNhapTheoNgay(fromDateString, toDateString);
                List<ThongKeSanPhamDTO> thongKeSanPham = thongKeBUS.GetTop5SanPhamBanChay(fromDateString, toDateString);
                
                ConfigureChart7Ngay(thongKehdngay, thongKepnngay, fromDate);
                Show5SanPham(thongKeSanPham);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UC_ThongKe_Load(object sender, EventArgs e)
        {
            ThongKeTheo12Thang();
        }
        private void ConfigureChart12Thang(List<ThongKeThangDTO> thongKeHDThang, List<ThongKeThangDTO> thongKePNThang)
        {
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();

            ChartArea chartArea = new ChartArea("Default");
            chart1.ChartAreas.Add(chartArea);

            Series series1 = new Series("Tổng tiền bán hàng")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true,
                Color = System.Drawing.Color.FromArgb(80, 17, 132)
            };

            Series series2 = new Series("Tổng tiền nhập hàng")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true,
                Color = System.Drawing.Color.Cyan
            };

            chart1.Series.Add(series1);
            chart1.Series.Add(series2);

            AddChartData12Thang(series1, series2, thongKeHDThang, thongKePNThang);
           
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chart1.ChartAreas[0].AxisX.IsMarginVisible = false; 
        }
        private void ConfigureChart7Ngay(List<ThongKeNgayDTO> thongKeHDNgay, List<ThongKeNgayDTO> thongKePNNgay, DateTime fromDate)
        {
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();

            ChartArea chartArea = new ChartArea("Default");
            chart1.ChartAreas.Add(chartArea);

            Series series1 = new Series("Tổng tiền bán hàng")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true,
                Color = System.Drawing.Color.FromArgb(80, 17, 132)
            };

            Series series2 = new Series("Tổng tiền nhập hàng")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true,
                Color = System.Drawing.Color.Cyan
            };

            chart1.Series.Add(series1);
            chart1.Series.Add(series2);

            AddChartData7ngay(series1, series2, thongKeHDNgay, thongKePNNgay, fromDate);

            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chart1.ChartAreas[0].AxisX.IsMarginVisible = false;
        }
        private void AddChartData12Thang(Series series1, Series series2, List<ThongKeThangDTO> thongKeHDThang, List<ThongKeThangDTO> thongKePNThang)
        {
            try
            {
                string[] categories = { "Tháng 1", "Tháng 2", "Tháng 3", "Tháng 4", "Tháng 5", "Tháng 6",
                                "Tháng 7", "Tháng 8", "Tháng 9", "Tháng 10", "Tháng 11", "Tháng 12" };

                double[] values1 = new double[12]; 
                double[] values2 = new double[12];

                double tongBanHang = 0;
                double tongNhapHang = 0;
                double tongDoanhThu = 0;

                foreach (var tk in thongKeHDThang)
                {
                    int month = tk.thang - 1 ; 
                    values1[month] = (double)tk.tongTien;
                    tongBanHang += tk.tongTien;
                }

                foreach (var tk in thongKePNThang)
                {
                    int month = tk.thang - 1 ;
                    values2[month] = (double)tk.tongTien;
                    tongNhapHang += tk.tongTien;
                }

                for (int i = 0; i < categories.Length; i++)
                {
                    series1.Points.AddXY(categories[i], values1[i]);
                    series2.Points.AddXY(categories[i], values2[i]);
                }

                tongDoanhThu = tongBanHang - tongNhapHang;

                string formattedTongBanHang = tongBanHang.ToString("#,0", CultureInfo.InvariantCulture);
                string formattedTongNhapHang = tongNhapHang.ToString("#,0", CultureInfo.InvariantCulture);
                string formattedTongDoanhThu = tongDoanhThu.ToString("#,0", CultureInfo.InvariantCulture);

                labelTongBanHang.Text = formattedTongBanHang + " VNĐ";
                labelTongNhapHang.Text = formattedTongNhapHang + " VNĐ";
                labelTongDoanhThu.Text = formattedTongDoanhThu + " VNĐ";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AddChartData7ngay(Series series1, Series series2, List<ThongKeNgayDTO> thongKeHDNgay, List<ThongKeNgayDTO> thongKePNNgay, DateTime fromDate)
        {
            try
            {
                List<string> categories = new List<string>();
                for (int i = 0; i < 7; i++)
                {
                    categories.Add(fromDate.AddDays(i).ToString("yyyy-MM-dd"));
                }

                double[] values1 = new double[7];
                double[] values2 = new double[7];

                double tongBanHang = 0;
                double tongNhapHang = 0;
                double tongDoanhThu = 0;

                foreach (var tk in thongKeHDNgay)
                {
                    int dayIndex = categories.IndexOf(tk.ngayLap.ToString("yyyy-MM-dd"));
                    if (dayIndex != -1)
                    {
                        values1[dayIndex] = (double)tk.tongTien;
                        tongBanHang += tk.tongTien;
                    }
                }

                foreach (var tk in thongKePNNgay)
                {
                    int dayIndex = categories.IndexOf(tk.ngayLap.ToString("yyyy-MM-dd"));
                    if (dayIndex != -1)
                    {
                        values2[dayIndex] = (double)tk.tongTien;
                        tongNhapHang += tk.tongTien;
                    }
                }

                for (int i = 0; i < categories.Count; i++)
                {
                    series1.Points.AddXY(categories[i], values1[i]);
                    series2.Points.AddXY(categories[i], values2[i]);
                }
                tongDoanhThu = tongBanHang - tongNhapHang;

                string formattedTongBanHang = tongBanHang.ToString("#,0", CultureInfo.InvariantCulture);
                string formattedTongNhapHang = tongNhapHang.ToString("#,0", CultureInfo.InvariantCulture);
                string formattedTongDoanhThu = tongDoanhThu.ToString("#,0", CultureInfo.InvariantCulture);

                labelTongBanHang.Text = formattedTongBanHang + " VNĐ";
                labelTongNhapHang.Text = formattedTongNhapHang + " VNĐ";
                labelTongDoanhThu.Text = formattedTongDoanhThu + " VNĐ";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            ThongKeTheo7Ngay(null);
        }

        private void btn7ngay_Click(object sender, EventArgs e)
        {
            DateTime homnay = DateTime.Now;
            ThongKeTheo7Ngay(homnay);
        }
    }
}
