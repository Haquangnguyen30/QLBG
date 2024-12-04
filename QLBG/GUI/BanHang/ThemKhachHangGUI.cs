using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

            // Kiểm tra số điện thoại
            if (!CheckPhoneNumber(kh.sdt))
            {
                txtSdt.Text = "";
                return; // Dừng việc thêm nếu số điện thoại không hợp lệ
            }

            // Thêm khách hàng mới
            khBus.themKhachHang(kh);
            box.DataSource = khBus.getList();
            MessageBox.Show("Thêm khách hàng thành công!");

            // Đặt giá trị được chọn trong ComboBox là khách hàng vừa thêm
            box.SelectedValue = kh.maKH;

            // Đóng form sau khi hoàn thành
            this.Close();
        }

        public bool CheckPhoneNumber(string phoneNumber)
        {
            string phonePattern = @"^0\d{9}$";

            if (string.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("Số điện thoại không được để trống");
                return false;
            }

            if (!Regex.IsMatch(phoneNumber, phonePattern))
            {
                MessageBox.Show("Số điện thoại không đúng định dạng");
                return false;
            }

            foreach (KhachHangDTO kh in khBus.getList())
            {
                if (phoneNumber.Equals(kh.sdt.Trim()))
                {
                    MessageBox.Show("Số điện thoại bị trùng");
                    return false;
                }
            }

            return true;
        }

    }
}
