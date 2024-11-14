using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;

namespace GUI.NhapHang
{
    public partial class PhieuNhapGUI : Form
    {      
        private PhieuNhapBUS pnBUS = new PhieuNhapBUS();
        private ChiTietPhieuNhapBUS ctpnBUS = new ChiTietPhieuNhapBUS();
        private bool isInitialized = false;
        private String minDate = "1972-09-01";
        private String maxDate = DateTime.Today.ToString("yyyy-MM-dd");
        public PhieuNhapGUI()
        {
            InitializeComponent();
        }
        private void PhieuNhapGUI1_Load(object sender, EventArgs e)
        {
            contentDgvPN(minDate, maxDate, "", "", "0", false);

            isInitialized = true;
            dgvPN.ClearSelection();

            dtpFromDate.MaxDate = DateTime.Today;
            dtpToDate.MaxDate = DateTime.Today;
            dtpToDate.Value = DateTime.Today;
        }
        private void dgvPN_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (isInitialized)
            {
                if (dgvPN.SelectedRows.Count > 0)
                {
                    int rowIndex = e.RowIndex;

                    txtNhanVien.Text = dgvPN.Rows[rowIndex].Cells["Nhân viên"].Value?.ToString();
                    txtNCC.Text = dgvPN.Rows[rowIndex].Cells["Nhà cung cấp"].Value?.ToString();
                    txtNgayLap.Text = dgvPN.Rows[rowIndex].Cells["Ngày lập"].Value?.ToString();
                    txtTongTien.Text = dgvPN.Rows[rowIndex].Cells["Tổng tiền"].Value?.ToString();


                    String maPN = dgvPN.Rows[rowIndex].Cells["Mã PN"].Value?.ToString();
                    contentDgvCTPN(maPN, "", "", "", "0", false);
                }
                else
                {
                    dgvCTPN.DataSource = null;
                }
            }

        }
        private void clearPNInfo()
        {
            ckbNhanVien.Checked = false;
            ckbNCC.Checked = false;
            radioGiamDanPN.Checked = false;
            radioTangDanPN.Checked = false;
            txtNhanVien.Text = "";
            txtNCC.Text = "";
            txtNgayLap.Text = "";
            txtTongTien.Text = "";
            dtpFromDate.Value = dtpFromDate.MinDate;
            dtpToDate.Value = DateTime.Today;
        }
        private void btnLamMoiPN_Click(object sender, EventArgs e)
        {
            clearPNInfo();
            clearCTPNInfo();
            contentDgvPN(minDate, maxDate, "", "", "0", false);
        }
        private void btnTimKiemPN_Click(object sender, EventArgs e)
        {
            String fromDate = dtpFromDate.Value.ToString("yyyy-MM-dd");
            String toDate = dtpToDate.Value.ToString("yyyy-MM-dd");
            String nv = ckbNhanVien.Checked ? txtNhanVien.Text : "";
            String ncc = ckbNCC.Checked ? txtNCC.Text : "";

            bool radioChecked = (radioTangDanPN.Checked || radioGiamDanPN.Checked) ? true : false;
            String tongTien = radioChecked ? txtTongTien.Text : "0";

            bool checkedDown = radioGiamDanPN.Checked ? true : false;

            contentDgvPN(fromDate, toDate, nv, ncc, tongTien, checkedDown);
        }
        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (dtpFromDate.Value > dtpToDate.Value)
            {
                MessageBox.Show("Ngày bắt đầu không thể lớn hơn ngày kết thúc!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String fromDate = dtpFromDate.Value.ToString("yyyy-MM-dd");
                String toDate = dtpToDate.Value.ToString("yyyy-MM-dd");
                String nv = ckbNhanVien.Checked ? txtNhanVien.Text : "";
                String ncc = ckbNCC.Checked ? txtNCC.Text : "";

                bool radioChecked = (radioTangDanPN.Checked || radioGiamDanPN.Checked) ? true : false;
                String tongTien = radioChecked ? txtTongTien.Text : "0";

                bool checkedDown = radioGiamDanPN.Checked ? true : false;

                contentDgvPN(fromDate, toDate, nv, ncc, tongTien, checkedDown);
            }

        }
        private void contentDgvPN(String fromDate, String toDate, String nv, String ncc, String tongTien, bool checkedDown)
        {
            dgvPN.DataSource = pnBUS.getDSPN(fromDate, toDate, nv, ncc, tongTien, checkedDown);
            dgvPN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPN.ClearSelection();
        }

        private void dgvCTPN_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCTPN.SelectedRows.Count > 0)
            {
                int rowIndex = e.RowIndex;

                txtSanPham.Text = dgvCTPN.Rows[rowIndex].Cells["Sản phẩm"].Value?.ToString();
                txtMauSac.Text = dgvCTPN.Rows[rowIndex].Cells["Màu sắc"].Value?.ToString();
                txtKichCo.Text = dgvCTPN.Rows[rowIndex].Cells["Kích cỡ"].Value?.ToString();
                txtGiaNhap.Text = dgvCTPN.Rows[rowIndex].Cells["Giá nhập"].Value?.ToString();
            }
        }

        private void clearCTPNInfo()
        {
            txtSanPham.Text = "";
            txtMauSac.Text = "";
            txtKichCo.Text = "";
            txtGiaNhap.Text = "";
            ckbSanPham.Checked = false;
            ckbMauSac.Checked = false;
            ckbKichCo.Checked = false;
            radioGiaNhapTang.Checked = false;
            radioGiaNhapGiam.Checked = false;
        }
        private void btnLamMoiCTPN_Click(object sender, EventArgs e)
        {

            if (dgvPN.SelectedRows.Count > 0)
            {
                String maPN = dgvPN.SelectedRows[0].Cells["Mã PN"].Value?.ToString();

                contentDgvCTPN(maPN, "", "", "", "0", false);
            }
            clearCTPNInfo();
        }
        private void contentDgvCTPN(String maPN, String tenSP, String mauSac, String kichCo, String giaNhap, bool checkedDown)
        {
            dgvCTPN.DataSource = ctpnBUS.getCTPN(maPN, tenSP, mauSac, kichCo, giaNhap, checkedDown);
            dgvCTPN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCTPN.ClearSelection();
        }

        private void btnTimKiemCTPN_Click(object sender, EventArgs e)
        {
            if (dgvPN.SelectedRows.Count > 0)
            {
                String maPN = dgvPN.SelectedRows[0].Cells["Mã PN"].Value?.ToString();
                String tenSP = ckbSanPham.Checked ? txtSanPham.Text : "";
                String mauSac = ckbMauSac.Checked ? txtMauSac.Text : "";
                String kichCo = ckbKichCo.Checked ? txtKichCo.Text : "";
                String giaNhap = (radioGiaNhapTang.Checked || radioGiaNhapGiam.Checked) ? txtGiaNhap.Text : "";

                bool checkDown = radioGiaNhapGiam.Checked ? true : false;

                contentDgvCTPN(maPN, tenSP, mauSac, kichCo, giaNhap, checkDown);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export Excel";
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx";
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportExcel(saveFileDialog.FileName);
                    MessageBox.Show("Export thành công.");
                } catch (Exception ex)
                {
                    MessageBox.Show("Export không thành công:\n" + ex.Message);
                }
            }
        }

        private void ExportExcel(string path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);

            for(int i=0; i<dgvPN.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = dgvPN.Columns[i].HeaderText;
            }

            for(int i=0; i<dgvPN.Rows.Count; i++)
            {
                for(int j=0; j<dgvPN.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = dgvPN.Rows[i].Cells[j].Value;
                }
            }

            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;
        }

        private void guna2Panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvPN_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String fileName = dgvPN.SelectedRows[0].Cells["Mã PN"].Value.ToString();
            openPdf(fileName);
        }

        private void openPdf(String fileName)
        {
            // Lấy đường dẫn gốc của ứng dụng khi chạy
            string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Tạo đường dẫn tới thư mục Resources (đường dẫn tương đối từ project)
            string resourcePath = Path.Combine(projectDirectory, @"..\..\..\GUI\Resources\Import_Invoice");

            String pdfPath = Path.Combine(resourcePath, fileName + ".pdf");
            if (File.Exists(pdfPath))
            {
                try
                {
                    // Mở file PDF bằng ứng dụng mặc định
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                    {
                        FileName = pdfPath,
                        UseShellExecute = true // Dùng ứng dụng mặc định của hệ thống để mở
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error opening PDF: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("PDF file not found at: " + pdfPath);
            }
        }
    }
}
