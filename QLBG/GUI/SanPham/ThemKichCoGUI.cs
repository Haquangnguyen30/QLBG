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
    public partial class ThemKichCoGUI : Form
    {
        private string maKichCo;
        DataGridView grid_KichCo;
        KichCoDTO kichco;
        KichCoBUS kcBUS;
        public ThemKichCoGUI(string data, DataGridView grid_KichCo)
        {
            InitializeComponent();
            this.maKichCo = data;
            this.grid_KichCo = grid_KichCo;
        }

        private void ThemKichCoGUI_Load(object sender, EventArgs e)
        {
            txtMaKichCo.Text = maKichCo;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKichCo.Text))
            {
                MessageBox.Show("Chưa nhập kích cỡ hoặc kích cỡ không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                kichco = new KichCoDTO();
                kichco.maKichCo = Convert.ToInt32(txtMaKichCo.Text.Trim());
                kichco.kichCo = txtKichCo.Text.Trim();
                kichco.tinhTrang = true;

                kcBUS = new KichCoBUS();



            }
        }
    }
}
