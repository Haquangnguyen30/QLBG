using BLL;
using BUS;
using DTO;
using GUI.NhaCungCap;
using GUI.NhapHang;
using NPOI.SS.Formula.Functions;
using OfficeOpenXml;
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

namespace GUI.UserControls
{
    public partial class UC_NhapHang : UserControl
    {
        private PhieuNhapBUS pnBUS = new PhieuNhapBUS();
        private ChiTietPhieuNhapBUS ctpnBUS = new ChiTietPhieuNhapBUS();
        private SanPhamBUS spBUS = new SanPhamBUS();
        private NhaCungCapBUS nccBUS = new NhaCungCapBUS();
        private NhanVienBUS nvBUS = new NhanVienBUS();
        public UC_NhapHang()
        {
            InitializeComponent();

        }
        private void UC_NhapHang_Load(object sender, EventArgs e)
        {
            contentDgvSanPham("");
            cbxNCC.DataSource = nccBUS.getDSTenNCC();
            cbxNCC.DisplayMember = "Tên NCC";
            cbxNCC.ValueMember = "Mã NCC";

            cbxNhanVien.DataSource = nvBUS.getDSTenNV();
            cbxNhanVien.DisplayMember = "Tên NV";
            cbxNhanVien.ValueMember = "Mã NV";

            addSPCNColumns();
        }
       
        private void contentDgvSanPham(String searchStr)
        {
            dgvSanPham.DataSource = pnBUS.getDSSP(searchStr);
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.ClearSelection();
        }
        private void dgvSanPham_RowEnter(object sender, DataGridViewCellEventArgs e)
        {            
            if(dgvSanPham.SelectedRows.Count > 0)
            {
                int rowIndex = e.RowIndex;

                txtTenSP.Text = dgvSanPham.Rows[rowIndex].Cells["Tên SP"].Value?.ToString();
                txtMauSac.Text = dgvSanPham.Rows[rowIndex].Cells["Màu sắc"].Value?.ToString();

                String giaNhap = dgvSanPham.Rows[rowIndex].Cells["Giá nhập"].Value?.ToString();
                if (giaNhap == "None") 
                {
                    txtGiaNhap.Enabled = true;
                    txtGiaNhap.Text = null;
                    txtGiaNhap.PlaceholderText = "Nhập giá nhập hàng.";
                } else
                {
                    txtGiaNhap.Enabled = false;
                    txtGiaNhap.Text = giaNhap;
                }
                    
            }
        }

        private void btnLichSuNH_Click(object sender, EventArgs e)
        {
            PhieuNhapGUI newForm = new PhieuNhapGUI();
            newForm.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text.Length > 0)
            {
                txtSearch.IconRight = Properties.Resources.X_circle;
            } 
            else
            {
                txtSearch.IconRight = null;
            }
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            var mousePosition = txtSearch.PointToClient(Cursor.Position);

            if (mousePosition.X >= txtSearch.Width - txtSearch.IconRightSize.Width - 10)
            {
                txtSearch.Text = "";
                contentDgvSanPham(txtSearch.Text);
                txtSearch.Focus();
            }
            else if (mousePosition.X <= txtSearch.IconLeftSize.Width + 10)
            {
                contentDgvSanPham(txtSearch.Text);
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                contentDgvSanPham(txtSearch.Text);
            }
        }
        private void addSPCNColumns()
        {
            dgvDSSPCN.Columns.Add("MaSP", "Mã sản phẩm");
            dgvDSSPCN.Columns.Add("KichCo", "Kích cỡ");
            dgvDSSPCN.Columns.Add("SoLuong", "Số lượng");
            dgvDSSPCN.Columns.Add("GiaNhap", "Giá nhập");
            dgvDSSPCN.Columns.Add("ThanhTien", "Thành tiền");

            dgvDSSPCN.Columns["GiaNhap"].DefaultCellStyle.Format = "F0";
            dgvDSSPCN.Columns["ThanhTien"].DefaultCellStyle.Format = "F0";

            dgvDSSPCN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(dgvSanPham.SelectedRows.Count > 0)
            {   
                String maSP = dgvSanPham.SelectedRows[0].Cells["Mã SP"].Value?.ToString();
                String kichCo = cbxSize.SelectedItem.ToString();
                int soLuong = (int) txtSoLuong.Value;
                float giaNhap = 0;
                float thanhTien = 0;

                if (txtGiaNhap.Text == null || txtGiaNhap.Text == "")
                {
                    MessageBox.Show("Thiếu thông tin giá nhập!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                } 
                else if(txtGiaNhap.Enabled)
                {
                    spBUS.suaGiaNhapSP(maSP, txtGiaNhap.Text);
                    contentDgvSanPham("");
                }
                    
                giaNhap = float.Parse(txtGiaNhap.Text);
                thanhTien = giaNhap * soLuong;
                

                if (!IsSizeExist(maSP, kichCo))
                {
                    dgvDSSPCN.Rows.Add(maSP, kichCo, soLuong, giaNhap, thanhTien);
                    if (dgvDSSPCN.Rows.Count > 0) btnThanhToan.Enabled = true;
                    tinhTongTien();
                }
                else
                {
                    MessageBox.Show("Mã sản phẩm đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private bool IsSizeExist(string maSP, string size)
        {
            foreach (DataGridViewRow row in dgvDSSPCN.Rows)
            {
                if (row.Cells["MaSP"].Value.ToString() == maSP && row.Cells["KichCo"].Value != null && row.Cells["KichCo"].Value.ToString() == size)
                {
                    return true;
                }
            }
            return false;
        }

        private void dgvDSSPCN_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                XoaSuaSPCNGUI formSuaXoa = new XoaSuaSPCNGUI(e.RowIndex, dgvDSSPCN);
                formSuaXoa.Show();
            }
        }

        private void tinhTongTien()
        {
            float tongTien = 0;
            foreach (DataGridViewRow row in dgvDSSPCN.Rows)
            {
                tongTien += float.Parse(row.Cells["ThanhTien"].Value.ToString());
            }
            txtTongTien.Text = tongTien.ToString("N0");
        }

        private void dgvDSSPCN_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            tinhTongTien();
        }

        private void dgvDSSPCN_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dgvDSSPCN.Rows.Count == 0) btnThanhToan.Enabled = false;
            tinhTongTien();
        }
        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            NhaCungCapGUI newForm = new NhaCungCapGUI();
            newForm.ShowDialog();
            cbxNCC.DataSource = nccBUS.getDSTenNCC();
            cbxNCC.DisplayMember = "Tên NCC";
            cbxNCC.ValueMember = "Mã NCC";
        }

        private void cbxNhanVien_DropDown(object sender, EventArgs e)
        {
            cbxNhanVien.DataSource = nvBUS.getDSTenNV();
            cbxNhanVien.DisplayMember = "Tên NV";
            cbxNhanVien.ValueMember = "Mã NV";
        }

        private void btnReaload_Click(object sender, EventArgs e)
        {
            contentDgvSanPham("");
            clearInfo();
        }
        
        private void clearInfo()
        {
            txtSearch.Text = "";
            txtTenSP.Text = "";
            txtMauSac.Text = "";
            txtGiaNhap.Text = "";
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            String tenNV = cbxNhanVien.Text;
            String maNV = cbxNhanVien.SelectedValue.ToString();
            String tenNCC = cbxNCC.Text;
            String maNCC = cbxNCC.SelectedValue.ToString();
            String tongTien = txtTongTien.Text;
            HoaDonNhapHangGUI formHoaDon = new HoaDonNhapHangGUI(tenNV, maNV, tenNCC, maNCC, dgvDSSPCN, tongTien);
            DialogResult result = formHoaDon.ShowDialog();

            if (result == DialogResult.OK)
            {
                dgvDSSPCN.Rows.Clear();
                dgvSanPham.ClearSelection();
                clearInfo();
            }
            
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Import Excel";
            openFileDialog.Filter = "Excel (*.xlsx)|*.xlsx";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ImportExcel(openFileDialog.FileName);
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Import không thành công:\n" + ex.Message);
                }
            }                    
            if (dgvDSSPCN.Rows.Count > 0) btnThanhToan.Enabled = true;
            tinhTongTien();
        }

        private void ImportExcel(String path)
        {
            using (ExcelPackage excelPackage = new ExcelPackage(new FileInfo(path)))
            {
                ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets[0];

                for (int i = excelWorksheet.Dimension.Start.Row + 1; i <= excelWorksheet.Dimension.End.Row; i++)
                {
                    List<String> listRows = new List<String>();
                    for (int j = excelWorksheet.Dimension.Start.Column; j<=excelWorksheet.Dimension.End.Column; j++)
                    {
                        listRows.Add(excelWorksheet.Cells[i, j].Value.ToString());
                    }

                    if (!IsSizeExist(listRows[0], listRows[1]))
                    {
                        dgvDSSPCN.Rows.Add(listRows.ToArray());
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show($"Mã sản phẩm {listRows[0]} với size {listRows[1]} đã tồn tại!\nQuá trình import sẽ dừng lại.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                MessageBox.Show("Import thành công.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvDSSPCN.Rows.Clear();
        }
    }
}
