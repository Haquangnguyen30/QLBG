using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace GUI.NhapHang
{
    public partial class HoaDonNhapHangGUI : Form
    {
        private PhieuNhapBUS pnBus = new PhieuNhapBUS();
        private DataGridView dgvDSSPCN;
        private String tenNV;
        private String maNV;
        private String tenNCC;
        private String maNCC;
        private String tongTien;
        private DateTime ngayNhap = DateTime.Now.Date;
        public HoaDonNhapHangGUI(String tenNV, String maNV, String tenNCC, String maNCC, DataGridView dgvDSSPCN, string tongTien)
        {
            InitializeComponent();
            this.dgvDSSPCN = dgvDSSPCN;
            this.tenNV = tenNV;
            this.maNV = maNV;
            this.tenNCC = tenNCC;
            this.maNCC = maNCC;
            this.tongTien = tongTien;

            lblNhanVien.Text = tenNV;
            lblNCC.Text = tenNCC;
            lblNgayNhap.Text = ngayNhap.ToString("yyyy-MM-dd");
            contentDgvSP(dgvDSSPCN);
            lblTongTien.Text = tongTien + " VNĐ";
        }

        private void contentDgvSP(DataGridView dgvSource)
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

            if(result == DialogResult.Yes)
            {
                PhieuNhapDTO pn = new PhieuNhapDTO();
                pn.maPN = pnBus.getMaxMaPN() + 1;
                pn.maNV = maNV;
                pn.maNCC = int.Parse(maNCC);
                pn.ngayLap = ngayNhap;
                pn.tongTien = float.Parse(tongTien);
                pn.tinhTrang = true;

                List<ChiTietPhieuNhapDTO> ctpns = new List<ChiTietPhieuNhapDTO>();
                foreach (DataGridViewRow row in dgvSP.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        ChiTietPhieuNhapDTO ctpn = new ChiTietPhieuNhapDTO();
                        ctpn.maSP = row.Cells["MaSP"].Value.ToString();
                        ctpn.makichCo = checkSize(row.Cells["KichCo"].Value.ToString());
                        ctpn.soLuong = int.Parse(row.Cells["SoLuong"].Value.ToString());
                        ctpn.giaNhap = float.Parse(row.Cells["GiaNhap"].Value.ToString());
                        ctpn.thanhTien = float.Parse(row.Cells["ThanhTien"].Value.ToString());
                        ctpn.tinhTrang = true;

                        ctpns.Add(ctpn);
                    }
                }

                pnBus.themPN(pn, ctpns);
                
                MessageBox.Show("Nhập hàng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                createPdf(pn.maPN.ToString());
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
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

        private void createPdf(String fileName)
        {
            // Lấy đường dẫn gốc của ứng dụng khi chạy
            string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Tạo đường dẫn tới thư mục Resources (đường dẫn tương đối từ project)
            string resourcePath = Path.Combine(projectDirectory, @"..\..\..\GUI\Resources\Import_Invoice");

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
            Paragraph title = new Paragraph("HÓA ĐƠN NHẬP HÀNG", titleFont);
            title.Alignment = Element.ALIGN_CENTER;
            doc.Add(title);

            // Thêm mã phiếu nhập với gạch chân, căn giữa
            string maPhieuNhapText = "Mã " + fileName;
            Paragraph maPhieuNhap = new Paragraph(maPhieuNhapText, underlineFont);
            maPhieuNhap.Alignment = Element.ALIGN_CENTER;
            doc.Add(maPhieuNhap);

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
            AddAlignedInfoLine(doc, "Nhà cung cấp:", lblNCC.Text, largeFont);
            AddAlignedInfoLine(doc, "Ngày nhập:....", lblNgayNhap.Text, largeFont);

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

                    if (dgvSP.Columns[i].HeaderText == "Giá nhập" || dgvSP.Columns[i].HeaderText == "Thành tiền")
                    {
                        if (decimal.TryParse(cellText, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out decimal number))
                        {
                            // Định dạng lại số lớn
                            cellText = number.ToString("N0", System.Globalization.CultureInfo.InvariantCulture);
                        }
                    }

                    PdfPCell pdfCell = new PdfPCell(new Phrase(cellText, regularFont));
                    pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
                    productTable.AddCell(pdfCell);
                }
            }


            doc.Add(productTable);

            Paragraph totalAmount = new Paragraph("Tổng tiền: " + lblTongTien.Text, largeFont);
            totalAmount.Alignment = Element.ALIGN_RIGHT;
            doc.Add(totalAmount);

            doc.Add(new Paragraph("\n\n\n"));

            // Phần ký tên với khoảng cách tăng giữa hai cột
            PdfPTable signTable = new PdfPTable(2);
            signTable.WidthPercentage = 100;
            signTable.SetWidths(new float[] { 1, 1 });

            PdfPCell cellLeft = new PdfPCell(new Phrase("Người nhập hàng", largeFont));
            cellLeft.HorizontalAlignment = Element.ALIGN_CENTER;
            cellLeft.Border = Rectangle.NO_BORDER;
            cellLeft.PaddingRight = 30; // Thêm khoảng cách bên phải để tách xa phần bên trái

            PdfPCell cellRight = new PdfPCell(new Phrase("Người giao hàng", largeFont));
            cellRight.HorizontalAlignment = Element.ALIGN_CENTER;
            cellRight.Border = Rectangle.NO_BORDER;
            cellRight.PaddingLeft = 30; // Thêm khoảng cách bên trái để tách xa phần bên phải

            signTable.AddCell(cellLeft);
            signTable.AddCell(cellRight);

            doc.Add(signTable);

            doc.Close();

            MessageBox.Show("Đã lưu hóa đơn");
        }

        private void HoaDonNhapHangGUI_Load(object sender, EventArgs e)
        {

        }
    }
}
