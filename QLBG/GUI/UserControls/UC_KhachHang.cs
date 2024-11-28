using BLL;
using DocumentFormat.OpenXml.Office2010.CustomUI;
using DTO;
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

namespace GUI.UserControls
{
    public partial class UC_KhachHang : UserControl
    {
        KhachHangDTO khDto;
        KhachHangBUS khBus = new KhachHangBUS();
        public UC_KhachHang()
        {
            InitializeComponent();
        }

        private void UC_KhachHang_Load(object sender, EventArgs e)
        {
            tblKh.DataSource = this.khBus.getKhachHang();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string key = textBox1.Text;

            tblKh.DataSource = khBus.getFindKhachHang(key);
        }

        private void tblKh_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        public bool CheckPhoneNumber(string phoneNumber)
        {
            // Biểu thức chính quy kiểm tra số điện thoại với định dạng cụ thể (10 số và bắt đầu bằng số 0)
            string phonePattern = @"^0\d{9}$";

            // Kiểm tra đầu vào là null hoặc rỗng
            if (string.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("Số điện thoại không được để trống");
                return false;
            }

            // Kiểm tra độ dài của số điện thoại
            if (phoneNumber.Length != 10 || !phoneNumber.StartsWith("0"))
            {
                MessageBox.Show("Số điện thoại không hợp lệ");
                return false;
            }

            // kiểm tra trùng sdt
            foreach (KhachHangDTO kh in khBus.getList())
            {
                if (phoneNumber.Equals(kh.sdt.Trim()))
                {
                    if (tbTenKh.Text.Equals(kh.maKH + ""))
                    {
                        MessageBox.Show("Số điện thoại bị trùng");
                        return false;
                    }
                    else
                        return true;
                }

            }

            // Kiểm tra sự trùng khớp của số điện thoại với biểu thức chính quy
            if (!Regex.IsMatch(phoneNumber, phonePattern))
            {
                MessageBox.Show("Số điện thoại không đúng định dạng 1!");
                return false;
            }
            lbSdt.Text = "";
            return true;
        }

        private void tblKh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                tblKh.CurrentRow.Selected = true;

                DataGridViewRow row = tblKh.Rows[e.RowIndex];
                tbMaKh.Text = row.Cells["cotMaKh"].Value.ToString();
                tbTenKh.Text = row.Cells["cotTenKh"].Value.ToString();
                tbSdt.Text = row.Cells["cotSdt"].Value.ToString();

            }
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            tbTenKh.Enabled = true;
            tbSdt.Enabled = true;
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            if (!tbSdt.Text.Equals("") && !tbTenKh.Text.Equals(""))
            {

                if (CheckPhoneNumber(tbSdt.Text.Trim()))
                {
                    KhachHangDTO khachHangDTO = new KhachHangDTO();
                    khachHangDTO.maKH = int.Parse(tbMaKh.Text.Trim());
                    khachHangDTO.tenKH = tbTenKh.Text;
                    khachHangDTO.sdt = tbSdt.Text;
                    if (khBus.suakhachHang(khachHangDTO))
                    {
                        tblKh.DataSource = khBus.getKhachHang();
                        tbTenKh.Enabled = false;
                        tbSdt.Enabled = false;
                        MessageBox.Show("Sửa thành công!");
                    }
                    else
                        MessageBox.Show("Sửa thất bại!");
                }

            }
            else if (tbSdt.Text.Equals(""))
            {
                MessageBox.Show("Số điện thoại không được để trống!");
            }
            else if (tbTenKh.Text.Equals(""))
            {
                MessageBox.Show("Tên khách hàng không được để trống!");
            }
            else
            {
                MessageBox.Show("Số điện thoại không được để trống!");
                MessageBox.Show("Tên khách hàng không được để trống!");
            }
        }
    }
}
