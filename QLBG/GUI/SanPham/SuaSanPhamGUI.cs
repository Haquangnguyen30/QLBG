using BLL;
using DTO;
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
    public partial class SuaSanPhamGUI : Form
    {
        SanPhamDTO sanPham;
        DataGridView grid_SanPham;
        LoaiSanPhamBUS lspBUS = new LoaiSanPhamBUS();
        SanPhamBUS spBUS = new SanPhamBUS();
        public SuaSanPhamGUI(SanPhamDTO sanPham, DataGridView grid_SanPham)
        {
            InitializeComponent();
            this.sanPham = sanPham;
            this.grid_SanPham = grid_SanPham;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SuaSanPhamGUI_Load(object sender, EventArgs e)
        {
            DataTable lsp = lspBUS.getDSLoaiSanPham();
            string[] arr = new string[lsp.Rows.Count];
            for (int i = 0; i < lsp.Rows.Count; i++)
            {
                arr[i] = lsp.Rows[i]["maLoai"].ToString();
            }
            cbMaLoai.Items.Clear();
            cbMaLoai.Items.AddRange(arr);
            

            txtMaSanPham.Text = sanPham.maSP;
            txtTenSanPham.Text = sanPham.tenSP;
            txtGiaBan.Text = sanPham.giaBan.ToString();
            txtGiaNhap.Text = sanPham.giaNhap.ToString();
            txtMau.Text = sanPham.mau.ToString();
            cbMaLoai.SelectedItem = sanPham.maLoai.ToString();
            string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string imagePath = Path.Combine(projectDirectory, @"..\..\..\GUI\Resources\ImgSanPham", sanPham.img);
            try
            {
                ptbHinhAnh.Image = new Bitmap(imagePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading image: {ex.Message}");
                ptbHinhAnh.Image = null;
            }
            ptbHinhAnh.SizeMode = PictureBoxSizeMode.Zoom;
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
            if (float.TryParse(gia, out float giaValue))
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
        private string tempImagePath = null;
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!checkNull())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!checkGia(txtGiaBan.Text) || !checkGia(txtGiaNhap.Text))
            {
                MessageBox.Show("Giá bán hoặc giá nhập không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (float.Parse(txtGiaBan.Text) <= float.Parse(txtGiaNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập giá bán lớn hơn giá nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                sanPham = new SanPhamDTO();
                sanPham.maSP = txtMaSanPham.Text.Trim();
                sanPham.tenSP = txtTenSanPham.Text.Trim();
                sanPham.giaBan = float.Parse(txtGiaBan.Text);
                sanPham.giaNhap = float.Parse(txtGiaNhap.Text);
                sanPham.mau = txtMau.Text.Trim();
                sanPham.maLoai = int.Parse(cbMaLoai.SelectedItem.ToString());
                sanPham.img = txtMaSanPham.Text;

                if (spBUS.updateSanPham(sanPham))
                {
                    if (tempImagePath != null)
                    {
                        try
                        {
                            string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
                            string destPath = Path.Combine(projectDirectory, @"..\..\..\GUI\Resources\ImgSanPham", txtMaSanPham.Text);
                            Directory.CreateDirectory(Path.Combine(projectDirectory, @"..\..\..\GUI\Resources\ImgSanPham"));
                          

                            if (File.Exists(destPath)) 
                            { 
                            
                                File.Delete(destPath);  
                            }

                            File.Copy(tempImagePath, destPath, true);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi lưu ảnh: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    MessageBox.Show("Cập nhật thành công");
                    grid_SanPham.DataSource = spBUS.getDSSanPham();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại");
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
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                tempImagePath = openFileDialog.FileName;
                try
                {
                    if (ptbHinhAnh.Image != null)
                    {
                        ptbHinhAnh.Image.Dispose();
                    }

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
