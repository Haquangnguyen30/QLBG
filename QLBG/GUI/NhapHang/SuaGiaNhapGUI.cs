using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.NhapHang
{
    public partial class SuaGiaNhapGUI : Form
    {
        private int rowIndex;
        private DataGridView dgvSanPham;
        private string tenSP;
        private string mauSac;
        private string giaNhap;
        public SuaGiaNhapGUI(int rowIndex, DataGridView dgvSanPham)
        {
            InitializeComponent();
            tenSP = dgvSanPham.Rows[rowIndex].Cells["Tên SP"].Value.ToString();
            mauSac = dgvSanPham.Rows[rowIndex].Cells["Màu sắc"].Value.ToString();
            giaNhap = dgvSanPham.Rows[rowIndex].Cells["Giá nhập"].Value.ToString();
            if (giaNhap == "None")
            {
                txtGiaNhap.Text = null;
                txtGiaNhap.PlaceholderText = "Nhập giá nhập hàng.";
            }
            else
            {
                txtGiaNhap.Text = giaNhap;
            }

            this.rowIndex = rowIndex;
            this.dgvSanPham = dgvSanPham;

            txtTenSP.Text = tenSP;
            txtMauSac.Text = mauSac;
        }
    }
}
