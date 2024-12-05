using BLL;
using DTO;
using OfficeOpenXml.Drawing.Slicer.Style;
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

namespace GUI.SanPham
{
    public partial class ThemSanPhamGUI : Form
    {
        private string maSP;
        DataGridView grid_SanPham = new DataGridView();
        SanPhamBUS spBUS = new SanPhamBUS();
        LoaiSanPhamBUS lspBUS = new LoaiSanPhamBUS();
        private string tempImagePath = null;
        public ThemSanPhamGUI(string maSp, DataGridView grid_SanPham)
        {
            InitializeComponent();
            this.maSP = maSp;
            this.grid_SanPham = grid_SanPham;
        }
        public ThemSanPhamGUI(string maSp)
        {
            InitializeComponent();
            this.maSP = maSp;
        }
        private void ThemSanPhamGUI_Load(object sender, EventArgs e)
        {
            txtMaSanPham.Text = maSP;

            cbMaLoai.DataSource = lspBUS.getDSLoaiSanPham();

            cbMaLoai.DisplayMember = "tenLoai";
            cbMaLoai.ValueMember = "maLoai";
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
                sanPham.maLoai = int.Parse(cbMaLoai.SelectedValue.ToString());
                sanPham.tinhTrang = true;
                sanPham.img = txtMaSanPham.Text;
                sanPham.soLuong = 0;
                if (spBUS.addSanPham(sanPham))
                {
                    if (tempImagePath != null)
                    {
                        try
                        {
                            string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
                            string destPath = Path.Combine(projectDirectory, @"..\..\..\GUI\Resources\ImgSanPham", txtMaSanPham.Text);

                            Directory.CreateDirectory(Path.Combine(projectDirectory, @"..\..\..\GUI\Resources\ImgSanPham"));
                            File.Copy(tempImagePath, destPath, true);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi lưu ảnh: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
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
        
        private void ptbHinhAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Multiselect = false,
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
            };
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                tempImagePath = openFileDialog.FileName;
                try
                {
                    ptbHinhAnh.Image = new Bitmap(tempImagePath);
                    ptbHinhAnh.SizeMode = PictureBoxSizeMode.Zoom;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
