using BLL;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UserControls
{
    public partial class UC_SanPham : UserControl
    {
        SanPhamBUS spBUS = new SanPhamBUS();
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
            grid_SanPham.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SanPham.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SanPham.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SanPham.DataSource = this.spBUS.getDSSanPham();
            _default();

        }
        public void _default() 
        {
            DataGridViewRow row = grid_SanPham.Rows[0];
            txtMaSanPham.Text = row.Cells[0].Value.ToString();
            txtTenSanPham.Text = row.Cells[1].Value.ToString();
            txtGiaBan.Text = row.Cells[2].Value.ToString();
            txtSoLuong.Text = row.Cells[3].Value.ToString();
            txtGiaNhap.Text = row.Cells[5].Value.ToString();
            txtMaLoai.Text = row.Cells[6].Value.ToString();
            txtMaKichCo.Text = row.Cells[7].Value.ToString();
            txtMaMau.Text = row.Cells[8].Value.ToString();
        }

        private void grid_SanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = grid_SanPham.Rows[e.RowIndex];

                // Đổ dữ liệu vào các TextBox
                txtMaSanPham.Text = row.Cells[0].Value.ToString();
                txtTenSanPham.Text = row.Cells[1].Value.ToString();
                txtGiaBan.Text = row.Cells[2].Value.ToString(); 
                txtSoLuong.Text = row.Cells[3].Value.ToString();
                txtGiaNhap.Text = row.Cells[5].Value.ToString();
                txtMaLoai.Text = row.Cells[6].Value.ToString();
                txtMaKichCo.Text = row.Cells[7].Value.ToString();
                txtMaMau.Text = row.Cells[8].Value.ToString();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            grid_SanPham.DataSource = null;
            grid_SanPham.DataSource = this.spBUS.getDSSanPham();
            _default();
        }
    }
}
