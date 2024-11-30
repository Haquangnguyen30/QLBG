using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.DangNhap
{
    public partial class MatKhauMoiGUI : Form
    {
        private string maNV;
        TaiKhoanBUS tkBUS = new TaiKhoanBUS();
        public MatKhauMoiGUI(string maNV)
        {
            InitializeComponent();
            this.maNV = maNV;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNhapLai.Text)) 
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu");
                return;
            }
            if (txtMatKhau.Text.Equals(txtNhapLai.Text))
            {
               if(tkBUS.updateMatKhau(maNV, txtMatKhau.Text.Trim()))
               {
                    MessageBox.Show("Cập nhật thành công");
                    DangNhapGUI newForm = new DangNhapGUI();
                    newForm.Show();
                    this.Close();
               }
                else
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
            }
            else
            {
                MessageBox.Show("Mật Khẩu không trùng khớp");
                txtNhapLai.Text = "";
            }
        }
    }
}
