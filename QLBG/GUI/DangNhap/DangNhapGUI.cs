using BLL;
using BUS;
using DTO;
using GUI.Home;
using NPOI.SS.Formula.Functions;
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
    public partial class DangNhapGUI : Form
    {
        TaiKhoanBUS tkBUS = new TaiKhoanBUS();
        NhanVienBUS nvBUS = new NhanVienBUS();
        PhanQuyenBUS pqBUS = new PhanQuyenBUS();
        public DangNhapGUI()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK) 
            {
                Application.Exit();
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string TenDangNhap = txtTenDangNhap.Text.Trim();
            string MatKhau = txtMatKhau.Text.Trim();
            if (string.IsNullOrWhiteSpace(TenDangNhap))
            {
                MessageBox.Show("Tên đăng nhập không được bỏ trống");
                return;
            }
            if (string.IsNullOrWhiteSpace(MatKhau)) 
            {
                MessageBox.Show("Mật khẩu không được bỏ trống");
                return;
            }
            TaiKhoanDTO tk = tkBUS.getTaiKhoan(TenDangNhap, MatKhau);
            if (tk != null)
            {
                NhanVienDTO nv = nvBUS.getNhanVien(tk.maNV);
                PhanQuyenDTO pq = pqBUS.getPhanQuyen(tk.maQuyen);

                if (checkAccess(pq))
                {
                    UserSession.Instance.Login(nv, pq);

                    HomeGUI home = new HomeGUI();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tài khoản không có quyền truy cập vào hệ thống!", "Lỗi truy cập",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTenDangNhap.Text = "";
                    txtMatKhau.Text = "";
                }

                
            }
            else 
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác");
                txtTenDangNhap.Text = "";
                txtMatKhau.Text = "";
            }
        }

        private bool checkAccess(PhanQuyenDTO pq)
        {
            if(pq.qlyTK || pq.qlyBH || pq.qlySP || pq.qlyNV || pq.qlyKH ||  pq.qlyKM || pq.qlyNH || pq.xemThongKe)
            {
                return true;
            }
            return false;
        }
    }
}
