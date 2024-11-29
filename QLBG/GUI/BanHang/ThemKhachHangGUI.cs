using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI.BanHang
{
    public partial class ThemKhachHangGUI : Form
    {
        KhachHangBUS khBus = new KhachHangBUS();
        ComboBox box;
        public ThemKhachHangGUI(ComboBox box)
        {
            InitializeComponent();
            this.box = box;
        }
        private void ThemKhachHangGUI_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            KhachHangDTO kh = new KhachHangDTO();
            kh.maKH = khBus.getMaxMaKH() + 1;
            kh.tenKH = txtTenKH.Text;
            kh.sdt = txtSdt.Text;
            khBus.themKhachHang(kh);
            box.DataSource = khBus.getList();
            MessageBox.Show("Thêm khách hàng thành công!");
            box.SelectedValue = kh.maKH;
            this.Close();
        }
    }
}
