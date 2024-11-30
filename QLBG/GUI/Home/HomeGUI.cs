using DTO;
using GUI.DangNhap;
using GUI.UserControls;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace GUI.Home
{
    public partial class HomeGUI : Form
    {
        PhanQuyenDTO pq = new PhanQuyenDTO();
        NhanVienDTO currentNV = new NhanVienDTO();
        public HomeGUI()
        {
            InitializeComponent();
            this.currentNV = UserSession.Instance.currentNV;
            this.pq = UserSession.Instance.currentPQ;
        }
        private void HomeGUI_Load(object sender, EventArgs e)
        {
            btnBanHang.Visible = pq.qlyBH;
            btnNhapHang.Visible = pq.qlyNH;
            btnSanPham.Visible = pq.qlySP;
            btnKhachHang.Visible = pq.qlyKH;
            btnNhanVien.Visible = pq.qlyNV;
            btnKhuyenMai.Visible = pq.qlyKM;
            btnThongKe.Visible = pq.xemThongKe;
            btnPhanQuyen.Visible = pq.qlyTK;

            RearrangeButtons();
        }

        private void RearrangeButtons()
        {
            int spacing = 15;
            int currentY = 167;

            var buttons = new List<Guna2Button> 
            {
                btnBanHang,
                btnNhapHang,
                btnSanPham,
                btnKhachHang,
                btnNhanVien,
                btnKhuyenMai,
                btnThongKe,
                btnPhanQuyen,
                btnDangXuat
            };
            var activeButtons = new List<Guna2Button>();
            foreach(var button in buttons)
            {
                
                if (button.Visible)
                {
                    activeButtons.Add(button);
                    button.Location = new Point(button.Location.X, currentY);
                    currentY +=  button.Height + spacing;
                    
                }
            }
            showUserControlByButton(activeButtons.First());
            activeButtons.First().Checked = true;
            logoutButtonLocation();
        }

        private void logoutButtonLocation()
        {
            int bottomSpacing = 20;
            btnDangXuat.Location = new Point(0, this.ClientSize.Height - btnDangXuat.Height - bottomSpacing);
        }
        private void moveImgSlide(object sender)
        {
            Guna2Button btn = (Guna2Button) sender;
            imgSlide.Location = new Point(btn.Location.X + 123, btn.Location.Y - 48);
            
            showUserControlByButton(btn);
            imgSlide.SendToBack();
        }

        private void showUserControlByButton(Guna2Button btn)
        {
            switch (btn.Name)
            {
                case "btnBanHang":
                    ShowUserControl(uC_BanHang1);
                    break;
                case "btnNhapHang":
                    ShowUserControl(uC_NhapHang1);
                    break;
                case "btnKhachHang":
                    ShowUserControl(uC_KhachHang1);
                    break;
                case "btnNhanVien":
                    ShowUserControl(uC_NhanVien1);
                    break;
                case "btnSanPham":
                    ShowUserControl(uC_SanPham1);
                    break;
                case "btnThongKe":
                    ShowUserControl(uC_ThongKe1);
                    break;
                case "btnKhuyenMai":
                    ShowUserControl(uC_KhuyenMai1);
                    break;
                case "btnPhanQuyen":
                    ShowUserControl(uC_PhanQuyen1);
                    break;
                default:
                    break;
            }
        }

        private void guna2CustomRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e){
            
        }
        private void guna2Button1_CheckedChanged(object sender, EventArgs e)
        {
            moveImgSlide(sender);
        }
        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ShowUserControl(System.Windows.Forms.UserControl control)
        {
            uC_BanHang1.Visible = false;
            uC_NhapHang1.Visible = false;
            uC_KhachHang1.Visible = false;
            uC_NhanVien1.Visible = false;
            uC_SanPham1.Visible = false;
            uC_ThongKe1.Visible = false;
            uC_KhuyenMai1.Visible = false;
            uC_PhanQuyen1.Visible = false;

            control.Visible = true;
        }
        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {
        }
        private void guna2Button4_Click(object sender, EventArgs e)
        {
        }
        private void guna2Button5_Click(object sender, EventArgs e)
        {
        }
        private void guna2Button6_Click(object sender, EventArgs e)
        {
        }
        private void guna2Button7_Click(object sender, EventArgs e)
        {
        }
        private void guna2Button8_Click(object sender, EventArgs e)
        {
        }
        private void uC_BanHang1_Load(object sender, EventArgs e)
        {

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DangNhapGUI dangNhap = new DangNhapGUI();
            dangNhap.Show();
            this.Close();
        }

        private void HomeGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            DangNhapGUI dangNhap = new DangNhapGUI();
            dangNhap.Show();
            this.Hide();
        }
    }
}
