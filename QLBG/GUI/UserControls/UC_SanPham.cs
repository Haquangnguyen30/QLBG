using BLL;
using DocumentFormat.OpenXml.Spreadsheet;
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
using GUI.SanPham;
using NPOI.POIFS.NIO;
using NPOI.SS.Formula.Functions;
using DTO;

namespace GUI.UserControls
{
    public partial class UC_SanPham : UserControl
    {
        SanPhamBUS spBUS = new SanPhamBUS();
        LoaiSanPhamBUS lspBUS = new LoaiSanPhamBUS();
        KichCoBUS kcBUS = new KichCoBUS();
        SanPham_KichCoBUS spkcBUS = new SanPham_KichCoBUS();
        private DataTable tbKichCo;
        private DataTable tbLoaiSanPham;
        public UC_SanPham()
        {
            InitializeComponent();
        }
        private void UC_SanPham_Load(object sender, EventArgs e)
        {
            //SanPham
            grid_SanPham.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SanPham.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(80, 17, 132);

            grid_SanPham.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SanPham.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SanPham.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SanPham.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SanPham.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SanPham.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SanPham.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // cột img
            grid_SanPham.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SanPham.DataSource = this.spBUS.getDSSanPham();
            textSanPham(0);

            //ChiTietSoLuong
            grid_ChiTietSoLuong.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ChiTietSoLuong.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ChiTietSoLuong.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ChiTietSoLuong.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(80, 17, 132);
            
            //KichCo
            grid_KichCo.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_KichCo.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_KichCo.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_KichCo.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(80, 17, 132);
            tbKichCo = this.kcBUS.getDSKichCo();
            grid_KichCo.DataSource = tbKichCo;
            textKichCo(0);
           
            //LoaiSanPham
            grid_LoaiSanPham.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_LoaiSanPham.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_LoaiSanPham.Columns[1].DefaultCellStyle.Alignment= DataGridViewContentAlignment.MiddleCenter;
            grid_LoaiSanPham.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(80, 17, 132);
            tbLoaiSanPham = this.lspBUS.getDSLoaiSanPham();
            grid_LoaiSanPham.DataSource = tbLoaiSanPham;
            textLoaiSanPham(0);

        }
        public void textSanPham(int id) 
        {
            DataGridViewRow row = grid_SanPham.Rows[id];
            txtMaSanPham.Text = row.Cells[0].Value.ToString();
            txtTenSanPham.Text = row.Cells[1].Value.ToString();
            txtGiaBan.Text = row.Cells[2].Value.ToString();
            txtSoLuong.Text = row.Cells[3].Value.ToString();
            txtGiaNhap.Text = row.Cells[5].Value.ToString();
            txtMau.Text = row.Cells[6].Value.ToString(); 
            txtMaLoai.Text = row.Cells[7].Value.ToString();
            DataTable tbSoLuong = this.spkcBUS.getChiTietSoLuong(row.Cells[0].Value.ToString());
            grid_ChiTietSoLuong.DataSource = tbSoLuong;
        }
        public void textKichCo(int id)
        {
            DataGridViewRow row = grid_KichCo.Rows[id];
            txtMaKichCo.Text = row.Cells[0].Value.ToString();
            txtKichCo.Text = row.Cells[1].Value.ToString();
        }
        public void textLoaiSanPham(int id)
        {
            DataGridViewRow row = grid_LoaiSanPham.Rows[id];
            txtMaLoaiSanPham.Text = row.Cells[0].Value.ToString();
            txtTenLoaiSanPham.Text = row.Cells[1].Value.ToString();
        }
        private void grid_SanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textSanPham(e.RowIndex);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemSanPhamGUI newForm = new ThemSanPhamGUI();
            newForm.ShowDialog();
        }
        private void grid_KichCo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                textKichCo(e.RowIndex);
            }
        }
        private void grid_LoaiSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textLoaiSanPham(e.RowIndex);
            }
        }

        private void btnThemLoai_Click(object sender, EventArgs e)
        {
            int maxLoaiSanPham = 0;
            foreach(DataRow row in tbLoaiSanPham.Rows)
            {
                int temp = Convert.ToInt32(row["maLoai"]);
                if(temp > maxLoaiSanPham)
                {
                    maxLoaiSanPham = temp;
                }
            }
            int newLoaiSanPham = maxLoaiSanPham + 1;
            ThemLoaiSanPhamGUI newForm = new ThemLoaiSanPhamGUI(newLoaiSanPham.ToString(), grid_LoaiSanPham);
            newForm.ShowDialog();
        }

        private void btnSuaLoai_Click(object sender, EventArgs e)
        {   
            LoaiSanPhamDTO loai = new LoaiSanPhamDTO();
            loai.maLoai = Convert.ToInt32(txtMaLoaiSanPham.Text);
            loai.tenLoai = txtTenLoaiSanPham.Text;
            SuaLoaiSanPhamGUI newForm = new SuaLoaiSanPhamGUI(loai, grid_LoaiSanPham);
            newForm.ShowDialog();
        }

        private void btnThemKichCo_Click(object sender, EventArgs e)
        {
            int maxMaKichCo = 0;
            foreach (DataRow row in tbKichCo.Rows)
            {
                int temp = Convert.ToInt32(row["maKichCo"]);
                if (temp > maxMaKichCo)
                {
                    maxMaKichCo = temp;
                }
            }
            int newMaKichCo = maxMaKichCo+ 1;
            ThemKichCoGUI newForm = new ThemKichCoGUI(newMaKichCo.ToString());
            newForm.ShowDialog();
        }

        private void btnSuaKichCo_Click(object sender, EventArgs e)
        {
            SuaKichCoGUI newForm = new SuaKichCoGUI();
            newForm.ShowDialog();
        }

        private void btnSuaSanPham_Click(object sender, EventArgs e)
        {
            SuaSanPhamGUI newForm = new SuaSanPhamGUI();
            newForm.ShowDialog();
        }

        private void btnReloadSanPham_Click(object sender, EventArgs e)
        {
            grid_SanPham.DataSource = null;
            grid_SanPham.DataSource = this.spBUS.getDSSanPham();
            textSanPham(0);
        }

        private void btnXoaLoaiSanPham_Click(object sender, EventArgs e)
        {
            string maLSP = txtMaLoaiSanPham.Text;
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa loại sản phẩm có mã = " +maLSP +" không?", "Xóa sản phẩm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) { 
                LoaiSanPhamDTO loai = new LoaiSanPhamDTO();
                loai.maLoai = Convert.ToInt32(txtMaLoaiSanPham.Text.Trim());
                loai.tenLoai = txtTenLoaiSanPham.Text;
                loai.tinhTrang = 0;
                if (lspBUS.deleteLoaiSanPham(loai))
                {
                    MessageBox.Show("Xóa loại sản phẩm thành công");
                    tbLoaiSanPham = lspBUS.getDSLoaiSanPham();
                    grid_LoaiSanPham.DataSource = tbLoaiSanPham;
                }
                else
                {
                    MessageBox.Show("Xóa loại sản phẩm thất bại");
                }
            }
            else{
                return;
            }
        }

        private void btnReloadLoaiSanPham_Click(object sender, EventArgs e)
        {
            grid_LoaiSanPham.DataSource = null;
            grid_LoaiSanPham.DataSource = this.lspBUS.getDSLoaiSanPham();
            textLoaiSanPham(0);
        }
    }
}
