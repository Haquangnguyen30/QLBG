using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.SanPham
{
    public partial class SuaLoaiSanPhamGUI : Form
    {
        LoaiSanPhamDTO loai;
        DataGridView grid_LoaiSanPham;
        LoaiSanPhamBUS lspBUS = new LoaiSanPhamBUS();
        public SuaLoaiSanPhamGUI(LoaiSanPhamDTO loai, DataGridView grid_LoaiSanPham)
        {
            InitializeComponent();
            this.loai = loai;
            this.grid_LoaiSanPham = grid_LoaiSanPham;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SuaLoaiSanPhamGUI_Load(object sender, EventArgs e)
        {
            txtMaLoai.Text = loai.maLoai.ToString();
            txtTenLoai.Text = loai.tenLoai;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtTenLoai.Text))
            {
                MessageBox.Show("Thay đổi không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                loai = new LoaiSanPhamDTO();
                loai.maLoai = Convert.ToInt32(txtMaLoai.Text.Trim());
                loai.tenLoai = txtTenLoai.Text.Trim();
                if (lspBUS.updateLoaiSanPham(loai))
                {
                    MessageBox.Show("Cập nhật thành công");
                    grid_LoaiSanPham.DataSource = lspBUS.getDSLoaiSanPham();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
            }
            
        }
    }
}
