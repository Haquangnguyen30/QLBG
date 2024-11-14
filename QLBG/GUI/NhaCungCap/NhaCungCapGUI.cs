using BLL;
using DocumentFormat.OpenXml.Bibliography;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.NhaCungCap
{
    public partial class NhaCungCapGUI : Form
    {
        NhaCungCapBUS nccBUS = new NhaCungCapBUS();
        private bool isInitialized = false;
        public NhaCungCapGUI()
        {
            InitializeComponent();
        }

        private void NhaCungCapGUI_Load(object sender, EventArgs e)
        {
            dgvNCC.DataSource = nccBUS.getDSNCC("", true, false, false);
            dgvNCC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNCC.Columns["Mã NCC"].Visible = false;
            dgvNCC.DefaultCellStyle.ForeColor = Color.Black;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            isInitialized = true;
            dgvNCC.ClearSelection();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (checkInfo())
            {
                NhaCungCapDTO ncc = new NhaCungCapDTO();
                ncc.maNCC = nccBUS.getMaxIDNCC() + 1;
                ncc.tenNCC = txtTenNCC.Text;
                ncc.sdt = txtSDT.Text;
                ncc.diaChi = txtDiaChi.Text;
                ncc.tinhTrang = true;
             
                if(nccBUS.themNCC(ncc) > 0)
                {
                    MessageBox.Show("Thêm nhà cung cấp thành công.", "Thông báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearInfo();
                    dgvNCC.DataSource = nccBUS.getDSNCC("", true, false, false);
                    dgvNCC.ClearSelection();
                } 
                else
                {
                    MessageBox.Show("Thêm nhà cung cấp thất bại.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (checkInfo())
            {
                DataGridViewRow selectedRow = dgvNCC.SelectedRows[0];

                NhaCungCapDTO ncc = new NhaCungCapDTO();
                ncc.maNCC = Convert.ToInt32(selectedRow.Cells["Mã NCC"].Value);
                ncc.tenNCC = txtTenNCC.Text;
                ncc.sdt = txtSDT.Text;
                ncc.diaChi = txtDiaChi.Text;

                if (nccBUS.suaNCC(ncc) > 0)
                {
                    MessageBox.Show("Sửa nhà cung cấp thành công.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearInfo();
                    dgvNCC.DataSource = nccBUS.getDSNCC("", true, false, false);
                    dgvNCC.ClearSelection();
                }
                else
                {
                    MessageBox.Show("Sửa nhà cung cấp thất bại.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNCC.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvNCC.SelectedRows[0];

                int maNCC = Convert.ToInt32(selectedRow.Cells["Mã NCC"].Value);

                if (nccBUS.xoaNCC(maNCC) > 0)
                {
                    MessageBox.Show("Xóa nhà cung cấp thành công.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearInfo();
                    dgvNCC.DataSource = nccBUS.getDSNCC("", true, false, false);
                    dgvNCC.ClearSelection();
                    changeButton(true,false,false);
                }
                else
                {
                    MessageBox.Show("Xóa nhà cung cấp thất bại.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void clearInfo()
        {
            txtSearch.Text = "";
            txtTenNCC.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
        }

        private bool checkInfo()
        {
            if (string.IsNullOrEmpty(txtTenNCC.Text) || string.IsNullOrEmpty(txtSDT.Text) || string.IsNullOrEmpty(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!checkSDT(txtSDT.Text))
            {
                MessageBox.Show("Số điện thoại không hợp lệ!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSDT.Focus();
                return false;
            }
            return true;
        }

        private bool checkSDT(String sdt)
        {
            if (sdt.Length == 10 && sdt.StartsWith("0"))
            {
                foreach(Char c in sdt)
                {
                    if (!char.IsDigit(c))
                        return false;        
                }
                return true;
            }
            return false;
        }

        private void dgvNCC_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
           if(isInitialized)
            {
                if(dgvNCC.SelectedRows.Count > 0)
                {
                    changeButton(false, true, true);
                    int rowIndex = e.RowIndex;

                    txtTenNCC.Text = dgvNCC.Rows[rowIndex].Cells["Tên NCC"].Value?.ToString();
                    txtSDT.Text = dgvNCC.Rows[rowIndex].Cells["SDT"].Value?.ToString();
                    txtDiaChi.Text = dgvNCC.Rows[rowIndex].Cells["Địa chỉ"].Value?.ToString();
                }
            }
            
        }
        private void NhaCungCapGUI_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (!dgvNCC.Bounds.Contains(e.Location))
            {
                if(dgvNCC.SelectedRows.Count > 0)
                {
                    dgvNCC.ClearSelection();
                    clearInfo();
                    changeButton(true, false, false);
                }
            }
        }

        private void changeButton(bool them, bool sua, bool xoa)
        {
            btnThem.Enabled = them;
            btnSua.Enabled = sua;
            btnXoa.Enabled = xoa;
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
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                searchEvent();
            }
        }
        private void txtSearch_Click(object sender, EventArgs e)
        {
            var mousePosition = txtSearch.PointToClient(Cursor.Position);

            // Kiểm tra xem vị trí chuột có nằm trong khu vực icon bên phải không
            if (mousePosition.X >= txtSearch.Width - txtSearch.IconRightSize.Width) // 5 là khoảng cách điều chỉnh
            {
                // Thực hiện hành động khi nhấn vào icon bên phải
                txtSearch.Text = "";
                txtSearch.Focus();
            }
            else if (mousePosition.X <= txtSearch.IconLeftSize.Width)
            {
                searchEvent();
            }
        }

        private void searchEvent()
        {
            String searchString = txtSearch.Text;

            if (hasSpeacialCharacter(searchString))
            {
                bool isCheckedTenNCC = ckbTenNCC.Checked;
                bool isCheckedSDT = ckbSDT.Checked;
                bool isCheckedDC = ckbDiaChi.Checked;

                dgvNCC.DataSource = nccBUS.getDSNCC(searchString, isCheckedTenNCC, isCheckedSDT, isCheckedDC);
            }
            else
            {
                MessageBox.Show("Vui lòng không nhập kí tự đặc biệt!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool hasSpeacialCharacter(String str)
        {
            foreach(char c in str)
            {
                if (!char.IsLetterOrDigit(c) && c != ' ')
                    return false;
            }
            return true;
        }
    }
}
