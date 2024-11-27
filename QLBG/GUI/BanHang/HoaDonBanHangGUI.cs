using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DocumentFormat.OpenXml.Drawing.Charts;
using DTO;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace GUI.BanHang
{
    public partial class HoaDonBanHangGUI : Form
    {
        private HoaDonBUS hdBus = new HoaDonBUS();
        private DataGridView dgvGioHang;
        private String tenKH;
        private String tenNV = "NV001";
        private float tongTien;
        private DateTime ngayLap = DateTime.Now.Date;
        public HoaDonBanHangGUI(String tenKH, DataGridView dgvGioHang, float tongTien)
        {
            InitializeComponent();
            this.dgvGioHang = dgvGioHang;
            this.tenKH = tenKH;
            this.tongTien = tongTien;

            lblTenKH.Text = tenKH;
            lblNhanVien.Text = tenNV;
            lblNgayBan.Text = ngayLap.ToString("yyyy-MM-dd");
            contentDGV(dgvGioHang);
            txtTongTien.Text = tongTien+"";
        }
        private void contentDGV(DataGridView dgvSource)
        {
            if (dgvSP.Columns.Count == 0)
            {
                foreach (DataGridViewColumn col in dgvSource.Columns)
                {
                    dgvSP.Columns.Add((DataGridViewColumn)col.Clone());
                }
            }

            dgvSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            foreach (DataGridViewRow row in dgvSource.Rows)
            {
                // Kiểm tra xem dòng có phải là dòng mới (NewRow) không, vì dòng này không chứa dữ liệu thực sự
                if (!row.IsNewRow)
                {
                    int rowIndex = dgvSP.Rows.Add(); // Thêm dòng mới trong dgvDestination
                    for (int i = 0; i < row.Cells.Count; i++) // Duyệt từng ô (cell) trong dòng
                    {
                        dgvSP.Rows[rowIndex].Cells[i].Value = row.Cells[i].Value; // Sao chép giá trị
                    }
                }
            }
        }
        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn in hóa đơn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                HoaDonDTO hd = new HoaDonDTO();
                //hd.maHD = hdBus.GetMaHoaDonMoiNhat() + 1;
                hd.maNV = "NV001";
                hd.maKH = 1;
                hd.maKM = 1;
                hd.tienGiam = 0;
                hd.ngayLap = ngayLap;
                hd.tongTien = tongTien;
                hd.tienKhachDua = float.Parse(txtTienKhachDua.Text);
                hd.tienThua = float.Parse(txtTienThua.Text);
                hd.tinhTrang = true;

                List<ChiTietHoaDonDTO> cthds = new List<ChiTietHoaDonDTO>();
                foreach (DataGridViewRow row in dgvSP.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        ChiTietHoaDonDTO cthd = new ChiTietHoaDonDTO();
                        cthd.maSP = row.Cells["maSP"].Value.ToString();
                        cthd.giaBan = float.Parse(row.Cells["giaBan"].Value.ToString());
                        cthd.soLuong = int.Parse(row.Cells["soLuong"].Value.ToString());
                        cthd.thanhTien = float.Parse(row.Cells["thanhTien"].Value.ToString());
                        cthd.maKC = int.Parse(row.Cells["maKichCo"].Value.ToString());
                        cthds.Add(cthd);
                    }
                }

                int MaHD=hdBus.themHD(hd, cthds);

                MessageBox.Show("Bán hàng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                createPdf(MaHD.ToString());
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        private void createPdf(String fileName)
        {
            // Lấy đường dẫn gốc của ứng dụng khi chạy
            string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Tạo đường dẫn tới thư mục Resources (đường dẫn tương đối từ project)
            string resourcePath = Path.Combine(projectDirectory, @"..\..\..\GUI\Resources\Import_HDinvoice");

            // Tạo đường dẫn đầy đủ cho file PDF
            String pdfPath = Path.Combine(resourcePath, fileName + ".pdf");

            // Khởi tạo document với kích thước A4 và margin
            Document doc = new Document(PageSize.A4, 50, 50, 25, 25);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(pdfPath, FileMode.Create));
            doc.Open();

            // Cài đặt font tiếng Việt
            string fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "times.ttf");
            BaseFont bf = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            Font titleFont = new Font(bf, 16, iTextSharp.text.Font.BOLD);
            Font largeFont = new Font(bf, 14, iTextSharp.text.Font.NORMAL); // Font lớn hơn cho các thông tin
            Font regularFont = new Font(bf, 12, iTextSharp.text.Font.NORMAL);
            Font underlineFont = new Font(bf, 14, iTextSharp.text.Font.NORMAL | iTextSharp.text.Font.UNDERLINE);

            // Thêm tiêu đề hóa đơn
            Paragraph title = new Paragraph("HÓA ĐƠN BÁN HÀNG", titleFont);
            title.Alignment = Element.ALIGN_CENTER;
            doc.Add(title);

            // Thêm mã phiếu nhập với gạch chân, căn giữa
            string maHoaDonText = "Mã Hoá Đơn " + fileName;
            Paragraph maHoaDon = new Paragraph(maHoaDonText, underlineFont);
            maHoaDon.Alignment = Element.ALIGN_CENTER;
            doc.Add(maHoaDon);

            // Thêm khoảng cách giữa các phần
            doc.Add(new Paragraph("\n"));

            // Hàm hiển thị thông tin với tiêu đề bên trái, nội dung căn phải và dấu chấm ở giữa
            void AddAlignedInfoLine(Document document, string label, string value, Font font)
            {
                PdfPTable infoTable = new PdfPTable(1);
                infoTable.WidthPercentage = 100;

                string dotLine = new string('.', 50);

                Phrase line = new Phrase(label + dotLine + " " + value, font);

                PdfPCell cell = new PdfPCell(line);
                cell.Border = Rectangle.NO_BORDER;
                cell.HorizontalAlignment = Element.ALIGN_LEFT;

                infoTable.AddCell(cell);
                doc.Add(infoTable);
            }

            // Thêm thông tin hóa đơn
            AddAlignedInfoLine(doc, "Nhân viên:.....", lblNhanVien.Text, largeFont);
            AddAlignedInfoLine(doc, "Khách Hàng:", lblTenKH.Text, largeFont);
            AddAlignedInfoLine(doc, "Ngày lập:....", lblNgayBan.Text, largeFont);

            // Thêm khoảng cách trước bảng sản phẩm
            doc.Add(new Paragraph("\n"));

            // Bảng danh sách sản phẩm
            PdfPTable productTable = new PdfPTable(dgvSP.Columns.Count);
            productTable.WidthPercentage = 100;
            productTable.SpacingBefore = 20f;
            productTable.SpacingAfter = 20f;

            foreach (DataGridViewColumn column in dgvSP.Columns)
            {
                PdfPCell headerCell = new PdfPCell(new Phrase(column.HeaderText, regularFont));
                headerCell.HorizontalAlignment = Element.ALIGN_CENTER;
                headerCell.BackgroundColor = BaseColor.LIGHT_GRAY;
                productTable.AddCell(headerCell);
            }

            foreach (DataGridViewRow row in dgvSP.Rows)
            {
                if (row.IsNewRow) continue;
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    string cellText = row.Cells[i].Value?.ToString() ?? "";

                    if (dgvSP.Columns[i].HeaderText == "Giá bán" || dgvSP.Columns[i].HeaderText == "Thành tiền")
                    {
                        if (decimal.TryParse(cellText, out decimal number))
                        {
                            cellText = string.Format("{0:n0}", number);
                        }
                    }

                    PdfPCell pdfCell = new PdfPCell(new Phrase(cellText, regularFont));
                    pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
                    productTable.AddCell(pdfCell);
                }
            }

            doc.Add(productTable);

            Paragraph totalAmount = new Paragraph("Tổng tiền: " + txtTongTien.Text, largeFont);
            totalAmount.Alignment = Element.ALIGN_RIGHT;
            Paragraph customerAmount = new Paragraph("Tiền mặt: " + txtTienKhachDua.Text, largeFont);
            customerAmount.Alignment = Element.ALIGN_RIGHT;
            Paragraph restAmount = new Paragraph("Tiền thừa: " + txtTienThua.Text, largeFont);
            restAmount.Alignment = Element.ALIGN_RIGHT;
            doc.Add(totalAmount);
            doc.Add(customerAmount);
            doc.Add(restAmount);
            doc.Add(new Paragraph("\n\n\n"));

            // Phần ký tên với khoảng cách tăng giữa hai cột
            //PdfPTable signTable = new PdfPTable(2);
            //signTable.WidthPercentage = 100;
            //signTable.SetWidths(new float[] { 1, 1 });

            //PdfPCell cellLeft = new PdfPCell(new Phrase("Người nhập hàng", largeFont));
            //cellLeft.HorizontalAlignment = Element.ALIGN_CENTER;
            //cellLeft.Border = Rectangle.NO_BORDER;
            //cellLeft.PaddingRight = 30; // Thêm khoảng cách bên phải để tách xa phần bên trái

            //PdfPCell cellRight = new PdfPCell(new Phrase("Người giao hàng", largeFont));
            //cellRight.HorizontalAlignment = Element.ALIGN_CENTER;
            //cellRight.Border = Rectangle.NO_BORDER;
            //cellRight.PaddingLeft = 30; // Thêm khoảng cách bên trái để tách xa phần bên phải

            //signTable.AddCell(cellLeft);
            //signTable.AddCell(cellRight);

            //doc.Add(signTable);

            doc.Close();

            MessageBox.Show("Đã lưu hóa đơn");
        }
        private int checkSize(string size)
        {
            switch (size)
            {
                case "38":
                    return 1;
                case "39":
                    return 2;
                case "40":
                    return 3;
                case "41":
                    return 4;
                case "42":
                    return 5;
                default:
                    return 0;
            }
        }
        private void txtTienKhachDua_TextChanged(object sender, EventArgs e)
        {
            // Kiểm tra giá trị nhập vào của Tiền khách đưa
            if (float.TryParse(txtTienKhachDua.Text, out float tienKhachDua))
            {
                if (float.TryParse(txtTongTien.Text, out float tongTien))
                {
                    // Tính tiền thừa
                    float tienThua = tienKhachDua - tongTien;

                    // Nếu tiền thừa >= 0 thì hiển thị, ngược lại để trống
                    txtTienThua.Text = tienThua >= 0 ? tienThua.ToString("N0") : "";
                }
                else
                {
                    // Tổng tiền không hợp lệ
                    txtTienThua.Text = "";
                }
            }
            else
            {
                // Tiền khách đưa không hợp lệ
                txtTienThua.Text = "";
            }
        }

        private void HoaDonBanHangGUI_Load(object sender, EventArgs e)
        {

        }
    }
}
