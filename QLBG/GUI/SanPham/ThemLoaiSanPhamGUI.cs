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
    public partial class ThemLoaiSanPhamGUI : Form
    {
        private string maLoai;
        DataGridView grid_LoaiSanPham;
        LoaiSanPhamDTO loai;
        LoaiSanPhamBUS lspBUS = new LoaiSanPhamBUS();
        public ThemLoaiSanPhamGUI(string maLoai, DataGridView grid_LoaiSanPham)
        {
            InitializeComponent();
            this.maLoai = maLoai;
            this.grid_LoaiSanPham = grid_LoaiSanPham;
        }

        private void ThemLoaiSanPhamGUI_Load(object sender, EventArgs e)
        {
            txtMaLoai.Text = maLoai;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtTenLoai.Text))
            {
                MessageBox.Show("Chưa nhập tên hoặc tên không hợp lệ!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                loai = new LoaiSanPhamDTO();
                loai.maLoai = Convert.ToInt32(txtMaLoai.Text.Trim());
                loai.tenLoai = txtTenLoai.Text.Trim();
                loai.tinhTrang = 1;
                if (lspBUS.addLoaiSanPham(loai))
                {
                    MessageBox.Show("Thêm thành công");
                    grid_LoaiSanPham.DataSource = lspBUS.getDSLoaiSanPham();
                    this.Close();   
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
