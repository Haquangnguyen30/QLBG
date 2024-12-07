using BLL;
using DTO;
using GUI.NhapHang;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NPOI.POIFS.Crypt.CryptoFunctions;

namespace GUI.BanHang
{
    public partial class DoiHangGUI : Form
    {
        private SanPham_KichCoBUS spkcBUS = new SanPham_KichCoBUS();
        private ChiTietHoaDonBUS cthdBUS = new ChiTietHoaDonBUS();
        private HoaDonBUS hdBUS = new HoaDonBUS();  
        private DataGridView dgvCTHD;
        private String maHD;
        private String tenSP;
        private String tenNV;
        private String tenKH;
        public DoiHangGUI(DataGridView dgvCTHD, string maHD, String tenNV, String tenKH)
        {
            InitializeComponent();
            this.dgvCTHD = dgvCTHD;
            this.maHD = maHD;
            this.tenNV = tenNV;
            this.tenKH = tenKH;
        }
        private void DoiHangGUI_Load(object sender, EventArgs e)
        {
            lblMaHD.Text = "Mã HĐ: " + maHD;
            btnXacNhanDoi.Enabled = false;
            btnXoa.Enabled = false;
            contentDgvCTHDDH(dgvCTHD);
            addToDgvCTDHColumns();
        }

        private void contentDgvCTHDDH(DataGridView dgvSource)
        {
            if (dgvCTHDDH.Columns.Count == 0)
            {
                foreach (DataGridViewColumn col in dgvSource.Columns)
                {
                    dgvCTHDDH.Columns.Add((DataGridViewColumn)col.Clone());
                }
            }

            dgvCTHDDH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            foreach (DataGridViewRow row in dgvSource.Rows)
            {
                // Kiểm tra xem dòng có phải là dòng mới (NewRow) không, vì dòng này không chứa dữ liệu thực sự
                if (!row.IsNewRow)
                {
                    int rowIndex = dgvCTHDDH.Rows.Add(); // Thêm dòng mới trong dgvDestination
                    for (int i = 0; i < row.Cells.Count; i++) // Duyệt từng ô (cell) trong dòng
                    {
                        dgvCTHDDH.Rows[rowIndex].Cells[i].Value = row.Cells[i].Value; // Sao chép giá trị
                    }
                }
            }
        }

        private void dgvCTHDDH_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvCTHDDH.SelectedRows.Count > 0)
            {
                int rowIndex = e.RowIndex;

                txtMaSPGoc.Text = dgvCTHDDH.Rows[rowIndex].Cells[1].Value?.ToString();
                tenSP = dgvCTHDDH.Rows[rowIndex].Cells[2].Value?.ToString();
                txtSizeGoc.Text = dgvCTHDDH.Rows[rowIndex].Cells[4].Value?.ToString();
                txtGiaSPGoc.Text = dgvCTHDDH.Rows[rowIndex].Cells[5].Value?.ToString();

                int slDaDoi = getSLDoi(txtMaSPGoc.Text, txtSizeGoc.Text);

                txtSoLuongGoc.Text = (int.Parse(dgvCTHDDH.Rows[rowIndex].Cells[6].Value?.ToString()) - slDaDoi).ToString();

            }
        }
        
        private void addToDgvCTDHColumns()
        {
            dgvCTDH.Columns.Add("MaSP", "Mã sản phẩm");
            dgvCTDH.Columns.Add("TenSP", "Tên sản phẩm");
            dgvCTDH.Columns.Add("KCGoc", "Kích cỡ gốc");
            dgvCTDH.Columns.Add("KCDoi", "Kích cỡ đổi");
            dgvCTDH.Columns.Add("GiaBan", "Giá bán");
            dgvCTDH.Columns.Add("SoLuongDoi", "Số lượng đổi");

            dgvCTDH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        }

        private void btnDoiSize_Click(object sender, EventArgs e)
        {
            if(cbxSizeDoi.Text == txtSizeGoc.Text)
            {
                MessageBox.Show("Hãy lựa chọn kích cỡ khác!!!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if(txtSoLuongDoi.Text.Length == 0 || txtSoLuongDoi.Text == "0")
            {
                MessageBox.Show("Chưa nhập số lượng muốn đổi của khách!!!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (int.Parse(txtSoLuongDoi.Text) > int.Parse(txtSoLuongGoc.Text))
            {
                MessageBox.Show("Không thể đổi nhiều hơn số lượng bạn đã mua!!!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            String maSP = txtMaSPGoc.Text;
            String kichCoDoi = cbxSizeDoi.Text;
            int slTonKho = spkcBUS.checkTonKhoSP(maSP, getMaKichCo(kichCoDoi));
            int slDoi = int.Parse(txtSoLuongDoi.Text);
            if (slDoi > slTonKho)
            {
                MessageBox.Show($"Không thể đổi vì size {kichCoDoi} của sản phẩm này còn {slTonKho} đôi!!!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            String kichCoGoc = txtSizeGoc.Text;
            String giaBan = txtGiaSPGoc.Text;
            if (!IsSizeExist(maSP, kichCoGoc, kichCoDoi))
            {
                dgvCTDH.Rows.Add(maSP, tenSP, kichCoGoc, kichCoDoi, giaBan, slDoi);
                int slDaDoi = getSLDoi(txtMaSPGoc.Text, txtSizeGoc.Text);
                txtSoLuongGoc.Text = (int.Parse(txtSoLuongGoc.Text) - slDoi).ToString();
                if (dgvCTDH.Rows.Count > 0) btnXacNhanDoi.Enabled = true;
            }
            else
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool IsSizeExist(string maSP, string sizeGoc, string sizeDoi)
        {
            foreach (DataGridViewRow row in dgvCTDH.Rows)
            {
                if (row.Cells["MaSP"].Value.ToString() == maSP 
                    && row.Cells["KCGoc"].Value.ToString() == sizeGoc
                    && row.Cells["KCDoi"].Value.ToString() == sizeDoi)
                {
                    return true;
                }
            }
            return false;
        }

        private int getSLDoi(string maSPGoc, string sizeGoc)
        {
            int countSLDoi = 0;
            foreach (DataGridViewRow row in dgvCTDH.Rows)
            {
                if (row.Cells["MaSP"].Value.ToString() == maSPGoc && row.Cells["KCGoc"].Value.ToString() == sizeGoc)
                {
                    countSLDoi += int.Parse(row.Cells["SoLuongDoi"].Value.ToString());
                }
            }
            return countSLDoi;
        }



        public int getMaKichCo(string size)
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
                    return 0; // Giá trị mặc định khi không khớp
            }
        }

        private void txtSoLuongDoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự không hợp lệ
            }
        }

        private void dgvCTDH_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            btnXoa.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int slDoi = int.Parse(dgvCTDH.SelectedRows[0].Cells["SoLuongDoi"].Value.ToString());
            dgvCTDH.Rows.Remove(dgvCTDH.SelectedRows[0]);

            txtSoLuongGoc.Text = (int.Parse(txtSoLuongGoc.Text) + slDoi).ToString();
            if (dgvCTDH.Rows.Count == 0) btnXacNhanDoi.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnXacNhanDoi_Click(object sender, EventArgs e)
        {
            checkAndUpdateCTHDExits();
            cthdBUS.ThemChiTietHoaDon(getNewCTHD(), int.Parse(maHD));
            updateSLTonKho();
            DialogResult result = MessageBox.Show("Đổi hàng thành công. \nNhấn OK để xuất hóa đơn.", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                createExchangePdf(maHD);
            }
            hdBUS.updateTinhTrangHoaDon(maHD);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void checkAndUpdateCTHDExits()
        {
            foreach (DataGridViewRow row in dgvCTHDDH.Rows)
            {
                int countSL = 0;
                int sumSL = 0;
                foreach(DataGridViewRow rowDH in dgvCTDH.Rows)
                {
                    if (rowDH.Cells["MaSP"].Value.ToString() == row.Cells[1].Value.ToString()
                        && rowDH.Cells["KCGoc"].Value.ToString() == row.Cells[4].Value.ToString())
                    {
                        countSL += int.Parse(rowDH.Cells["SoLuongDoi"].Value.ToString());
                    }
                    else if (rowDH.Cells["MaSP"].Value.ToString() == row.Cells[1].Value.ToString()
                        && rowDH.Cells["KCDoi"].Value.ToString() == row.Cells[4].Value.ToString())
                    {
                        sumSL += int.Parse(rowDH.Cells["SoLuongDoi"].Value.ToString());
                    }
                }
                if(countSL != 0)
                {
                    int slGiuLai = int.Parse(row.Cells[6].Value.ToString()) - countSL;
                    String maSP = row.Cells[1].Value.ToString();
                    int maKC = getMaKichCo(row.Cells[4].Value.ToString());
                    float thanhTien = float.Parse(row.Cells[5].Value.ToString()) * slGiuLai;
                    if (slGiuLai > 0)
                    {
                        cthdBUS.updateSoLuongSauDoi(int.Parse(maHD), maSP, maKC, slGiuLai, thanhTien);
                    }
                    else if(slGiuLai == 0)
                    {
                        cthdBUS.deleteSoLuongSauDoi(int.Parse(maHD), maSP, maKC);
                    }
                }

                if(sumSL != 0)
                {
                    int slThem = int.Parse(row.Cells[6].Value.ToString()) + sumSL;
                    String maSP = row.Cells[1].Value.ToString();
                    int maKC = getMaKichCo(row.Cells[4].Value.ToString());
                    float thanhTien = float.Parse(row.Cells[5].Value.ToString()) * slThem;
                    cthdBUS.updateSoLuongSauDoi(int.Parse(maHD), maSP, maKC, slThem, thanhTien);
                }
            }
        }

        private List<ChiTietHoaDonDTO> getNewCTHD()
        {
            List<ChiTietHoaDonDTO> cthds = new List<ChiTietHoaDonDTO>();
            foreach(DataGridViewRow row in dgvCTDH.Rows)
            {
                float giaBan = float.Parse(row.Cells["GiaBan"].Value.ToString());
                int sl = int.Parse(row.Cells["SoLuongDoi"].Value.ToString());
                
                ChiTietHoaDonDTO cthd = new ChiTietHoaDonDTO();
                cthd.maSP = row.Cells["MaSP"].Value.ToString();
                cthd.maKC = getMaKichCo(row.Cells["KCDoi"].Value.ToString());
                cthd.giaBan = giaBan;
                cthd.soLuong = sl;
                cthd.thanhTien = giaBan * sl;
                cthd.tinhTrang = true;

                cthds.Add(cthd);
                
            }
            return cthds;
        }

        private void updateSLTonKho()
        {
            foreach(DataGridViewRow row in dgvCTDH.Rows)
            {
                String maSP = row.Cells["MaSP"].Value.ToString();
                int maKCGoc = getMaKichCo(row.Cells["KCGoc"].Value.ToString());
                int maKCDoi = getMaKichCo(row.Cells["KCDoi"].Value.ToString());
                int slDoi = int.Parse(row.Cells["SoLuongDoi"].Value.ToString());

                int slKCGoc = spkcBUS.getSoLuongKichCo(maSP, maKCGoc);
                int slKCDoi = spkcBUS.getSoLuongKichCo(maSP, maKCDoi);

                spkcBUS.suaSoLuongKichCo(maSP, maKCGoc, spkcBUS.getSoLuongKichCo(maSP, maKCGoc) + slDoi);
                spkcBUS.suaSoLuongKichCo(maSP, maKCDoi, spkcBUS.getSoLuongKichCo(maSP, maKCDoi) - slDoi);
            }
        }

        private void createExchangePdf(string fileName)
        {
            // Lấy đường dẫn gốc của ứng dụng khi chạy
            string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Tạo đường dẫn tới thư mục Resources (đường dẫn tương đối từ project)
            string resourcePath = Path.Combine(projectDirectory, @"..\..\..\GUI\Resources\Exchange_HDinvoice");

            // Tạo đường dẫn đầy đủ cho file PDF
            String pdfPath = Path.Combine(resourcePath, fileName + ".pdf");

            // Khởi tạo document với kích thước A4 và margin
            Document doc = new Document(PageSize.A4, 50, 50, 25, 25);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(pdfPath, FileMode.Create));
            doc.Open();

            // Cài đặt font tiếng Việt
            string fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "times.ttf");
            BaseFont bf = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            iTextSharp.text.Font titleFont = new iTextSharp.text.Font(bf, 16, iTextSharp.text.Font.BOLD);
            iTextSharp.text.Font largeFont = new iTextSharp.text.Font(bf, 14, iTextSharp.text.Font.NORMAL);
            iTextSharp.text.Font regularFont = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.NORMAL);

            // Thêm tiêu đề hóa đơn
            Paragraph title = new Paragraph("HÓA ĐƠN ĐỔI HÀNG", titleFont);
            title.Alignment = Element.ALIGN_CENTER;
            doc.Add(title);

            // Thêm mã hóa đơn đổi với gạch chân, căn giữa
            string maHoaDonText = "Mã Hóa Đơn Đổi: " + fileName;
            Paragraph maHoaDon = new Paragraph(maHoaDonText, largeFont);
            maHoaDon.Alignment = Element.ALIGN_CENTER;
            doc.Add(maHoaDon);

            // Thêm khoảng cách giữa các phần
            doc.Add(new Paragraph("\n"));

            // Hàm hiển thị thông tin với tiêu đề bên trái, nội dung căn phải
            void AddAlignedInfoLine(Document document, string label, string value, iTextSharp.text.Font font)
            {
                PdfPTable infoTable = new PdfPTable(1);
                infoTable.WidthPercentage = 100;

                Phrase line = new Phrase($"{label}: {value}", font);

                PdfPCell cell = new PdfPCell(line);
                cell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cell.HorizontalAlignment = Element.ALIGN_LEFT;

                infoTable.AddCell(cell);
                doc.Add(infoTable);
            }

            // Thêm thông tin hóa đơn đổi hàng
            AddAlignedInfoLine(doc, "Nhân viên", tenNV, largeFont);
            AddAlignedInfoLine(doc, "Khách hàng", tenKH, largeFont);
            AddAlignedInfoLine(doc, "Ngày đổi", DateTime.Now.ToString("dd/MM/yyyy"), largeFont);

            // Thêm khoảng cách trước bảng sản phẩm
            doc.Add(new Paragraph("\n"));

            // Bảng danh sách sản phẩm đổi
            PdfPTable productTable = new PdfPTable(4); // 4 cột
            productTable.WidthPercentage = 100;
            productTable.SpacingBefore = 20f;
            productTable.SpacingAfter = 20f;

            // Thêm tiêu đề cột
            string[] headers = { "Tên sản phẩm", "Size gốc", "Size đổi", "Số lượng đổi" };
            foreach (string header in headers)
            {
                PdfPCell headerCell = new PdfPCell(new Phrase(header, regularFont));
                headerCell.HorizontalAlignment = Element.ALIGN_CENTER;
                headerCell.BackgroundColor = BaseColor.LIGHT_GRAY;
                productTable.AddCell(headerCell);
            }

            // Thêm từng dòng sản phẩm
            foreach (DataGridViewRow row in dgvCTDH.Rows)
            {
                if (row.IsNewRow) continue;

                // Lấy giá trị từ các cột cần thiết
                string tenSP = row.Cells["TenSP"].Value?.ToString() ?? ""; // Tên sản phẩm
                string sizeGoc = row.Cells["KCGoc"].Value?.ToString() ?? ""; // Size gốc
                string sizeDoi = row.Cells["KCDoi"].Value?.ToString() ?? ""; // Size đổi
                string soLuongDoi = row.Cells["SoLuongDoi"].Value?.ToString() ?? ""; // Số lượng đổi

                // Thêm từng giá trị vào bảng
                productTable.AddCell(new PdfPCell(new Phrase(tenSP, regularFont)) { HorizontalAlignment = Element.ALIGN_CENTER });
                productTable.AddCell(new PdfPCell(new Phrase(sizeGoc, regularFont)) { HorizontalAlignment = Element.ALIGN_CENTER });
                productTable.AddCell(new PdfPCell(new Phrase(sizeDoi, regularFont)) { HorizontalAlignment = Element.ALIGN_CENTER });
                productTable.AddCell(new PdfPCell(new Phrase(soLuongDoi, regularFont)) { HorizontalAlignment = Element.ALIGN_CENTER });
            }

            // Thêm bảng vào PDF
            doc.Add(productTable);

            // Thêm lời cảm ơn
            doc.Add(new Paragraph("\nCảm ơn quý khách hàng!", largeFont));
            doc.Close();

            MessageBox.Show("Đã lưu hóa đơn đổi hàng thành công!");
        }

    }
}
