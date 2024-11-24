using BLL;
using DTO;
using OfficeOpenXml.Drawing.Slicer.Style;
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
    public partial class ThemSanPhamGUI : Form
    {
        private string maSP;
        DataGridView grid_SanPham;
        SanPhamBUS spBUS = new SanPhamBUS();
        LoaiSanPhamBUS lspBUS = new LoaiSanPhamBUS();
        public ThemSanPhamGUI(string maSp, DataGridView grid_SanPham)
        {
            InitializeComponent();
            this.maSP = maSp;
            this.grid_SanPham = grid_SanPham;
        }

        private void ThemSanPhamGUI_Load(object sender, EventArgs e)
        {
            txtMaSanPham.Text = maSP;

            DataTable lsp = lspBUS.getDSLoaiSanPham();
            string[] arr = new string[lsp.Rows.Count];
            for (int i = 0; i < lsp.Rows.Count; i++)
            {
                arr[i] = lsp.Rows[i]["maLoai"].ToString();
            }
            cbMaLoai.Items.Clear();
            cbMaLoai.Items.AddRange(arr);
            cbMaLoai.SelectedIndex = 0;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool checkNull()
        {
            if (String.IsNullOrWhiteSpace(txtTenSanPham.Text) || String.IsNullOrWhiteSpace(txtGiaBan.Text)
            || String.IsNullOrWhiteSpace(txtGiaNhap.Text) || String.IsNullOrWhiteSpace(txtMau.Text)) 
            {
                return false;
            }
            return true;
        }
        private bool checkGia(string gia)
        {
            if(float.TryParse(gia, out float giaValue))
            {
                if (giaValue < 100000)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!checkNull()) 
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(!checkGia(txtGiaBan.Text) || !checkGia(txtGiaNhap.Text)) 
            {
                MessageBox.Show("Giá bán hoặc giá nhập không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (float.Parse(txtGiaBan.Text) <= float.Parse(txtGiaNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập giá bán lớn hơn giá nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else{
                SanPhamDTO sanPham = new SanPhamDTO();
                sanPham.maSP = txtMaSanPham.Text;
                sanPham.tenSP = txtTenSanPham.Text;
                sanPham.giaBan = float.Parse(txtGiaBan.Text);
                sanPham.giaNhap = float.Parse(txtGiaNhap.Text);
                sanPham.mau = txtMau.Text;
                sanPham.maLoai = int.Parse(cbMaLoai.SelectedItem.ToString());
                sanPham.tinhTrang = true;
                sanPham.img = "";

                if (spBUS.addSanPham(sanPham))
                {
                    MessageBox.Show("Thêm thành công");
                    grid_SanPham.DataSource = this.spBUS.getDSSanPham();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
                
              
            }
        }
    }
}
