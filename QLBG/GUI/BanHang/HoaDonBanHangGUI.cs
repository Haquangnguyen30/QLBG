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
//using DocumentFormat.OpenXml.Drawing.Charts;
using DTO;
using iTextSharp.text.pdf;
using iTextSharp.text;
using GUI.UserControls;
using Irony.Parsing;

namespace GUI.BanHang
{
    public partial class HoaDonBanHangGUI : Form
    {
        private HoaDonBUS hdBus = new HoaDonBUS();
        private KhuyenMaiBUS kmBus = new KhuyenMaiBUS();
        private DataGridView dgvGioHang;
        private int maKH;
        private NhanVienDTO nvdto = UserSession.Instance.currentNV;
        private String tenKH;
        //private String tenNV = "NV001";
        private float TongTien;
        private float tienGiam = 0;
        private DateTime ngayLap = DateTime.Now.Date;
        public HoaDonBanHangGUI(int maKH,String tenKH, DataGridView dgvGioHang, float tongTien)
        {
            InitializeComponent();
            this.dgvGioHang = dgvGioHang;
            this.maKH = maKH;
            this.tenKH = tenKH;
            this.TongTien = tongTien;

            lblTenKH.Text = tenKH;
            lblNhanVien.Text = nvdto.tenNV;
            lblNgayBan.Text = ngayLap.ToString("yyyy-MM-dd");
            contentDGV(dgvGioHang);
            txtTongTien.Text = tongTien.ToString();
            TongTien = tongTien;
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
            if (!float.TryParse(txtTienThua.Text, out float tienthua))
                MessageBox.Show("Tiền khách đưa không hợp lệ");
            else
            if (result == DialogResult.Yes)
            {
                HoaDonDTO hd = new HoaDonDTO();
                //hd.maHD = hdBus.GetMaHoaDonMoiNhat() + 1;
                hd.maNV = nvdto.maNV;
                hd.maKH = maKH;
                hd.maKM = Convert.ToInt32(cbKhuyenMai.SelectedValue);
                hd.tienGiam = tienGiam;
                hd.ngayLap = ngayLap;
                hd.tongTien = TongTien;
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

            Paragraph totalAmount = new Paragraph("Tổng tiền: " + TongTien, largeFont);
            totalAmount.Alignment = Element.ALIGN_RIGHT;
            Paragraph decreaseAmount = new Paragraph("Tiền giảm giá: " + "- "+tienGiam, largeFont);
            decreaseAmount.Alignment = Element.ALIGN_RIGHT;
            Paragraph thenAmount = new Paragraph("Tiền phải trả: " + txtTongTien.Text, largeFont);
            thenAmount.Alignment = Element.ALIGN_RIGHT;
            Paragraph customerAmount = new Paragraph("Tiền mặt: " + txtTienKhachDua.Text, largeFont);
            customerAmount.Alignment = Element.ALIGN_RIGHT;
            Paragraph restAmount = new Paragraph("Tiền thừa: " + txtTienThua.Text, largeFont);
            restAmount.Alignment = Element.ALIGN_RIGHT;
            doc.Add(totalAmount);
            doc.Add(decreaseAmount);
            doc.Add(thenAmount);
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
        // Phương thức để cập nhật ComboBox
        private void CapNhatComboBox(DataTable danhSach)
        {
            // Xóa nguồn dữ liệu hiện tại của ComboBox
            cbKhuyenMai.DataSource = null;

            // Tạo một cột "Display" kết hợp tenKM và giaTriGiam
            DataColumn displayColumn = new DataColumn("Display", typeof(string));
            danhSach.Columns.Add(displayColumn);

            // Thêm lựa chọn "Không" vào đầu danh sách
            DataRow row = danhSach.NewRow();
            row["Display"] = "Không";
            row["maKM"] = 0;  // Mã khuyến mãi của "Không" là 0
            row["giaTriGiam"] = 0;
            danhSach.Rows.InsertAt(row, 0);

            // Điền thông tin cho cột "Display"
            foreach (DataRow dataRow in danhSach.Rows)
            {
                dataRow["Display"] = dataRow["tenKM"] + " - " + dataRow["giaTriGiam"].ToString() + "%";
            }

            // Cập nhật DataSource của ComboBox với DataTable đã được thêm cột "Display"
            cbKhuyenMai.DataSource = danhSach;
            cbKhuyenMai.DisplayMember = "Display"; // Hiển thị tên khuyến mãi và giá trị giảm
            cbKhuyenMai.ValueMember = "maKM";      // Lấy mã khuyến mãi

            // Thiết lập các thuộc tính của ComboBox
            cbKhuyenMai.DropDownStyle = ComboBoxStyle.DropDown;
            cbKhuyenMai.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbKhuyenMai.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbKhuyenMai.SelectedIndex = 0; // Mặc định chọn "Không"
        }

        // Phương thức để cập nhật tổng tiền
        private void CapNhatTongTien()
        {
            // Kiểm tra giá trị mã khuyến mãi từ ComboBox
            object selectedValue = cbKhuyenMai.SelectedValue;

            if (selectedValue != null && selectedValue.ToString() == "0") // Nếu là "Không" (mã khuyến mãi = 0)
            {
                // Nếu không có khuyến mãi, giữ nguyên giá trị txtTongTien
                txtTongTien.Text = txtTongTien.Text; // Giữ nguyên giá trị
                tienGiam = 0; // Không giảm giá
            }
            else
            {
                // Nếu có khuyến mãi, lấy giá trị giảm từ ComboBox
                DataRowView selectedRow = (DataRowView)cbKhuyenMai.SelectedItem;
                if (selectedRow != null)
                {
                    // Lấy giá trị giảm giá từ giaTriGiam trong ComboBox
                    decimal giaTriGiam = Convert.ToDecimal(selectedRow["giaTriGiam"]);

                    // Tính giá trị giảm giá và lưu vào biến toàn cục
                    decimal currentTotal = Convert.ToDecimal(txtTongTien.Text);  // Lấy giá trị tổng tiền hiện tại
                    tienGiam = (float)(currentTotal * giaTriGiam / 100);  // Lưu giá trị giảm giá vào biến toàn cục
                                                                          // Chuyển tienGiam từ float sang decimal để tính newTotal
                    decimal tienGiamDecimal = Convert.ToDecimal(tienGiam);

                    // Cập nhật txtTongTien theo công thức giảm giá
                    decimal newTotal = currentTotal - tienGiamDecimal;  // Áp dụng giảm giá từ tienGiamDecimal (kiểu decimal)
                    txtTongTien.Text = newTotal.ToString(); // Cập nhật lại txtTongTien
                }
            }
        }

        private void cbKhuyenMai_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatTongTien();
        }

        private void HoaDonBanHangGUI_Load(object sender, EventArgs e)
        {
            // Gọi phương thức để lấy danh sách khuyến mãi còn hiệu lực
            DataTable danhSachKhuyenMai = kmBus.getKhuyenMaiHieuLuc();

            // Cập nhật ComboBox với dữ liệu từ lớp DAO
            CapNhatComboBox(danhSachKhuyenMai);
        }
    }
}
