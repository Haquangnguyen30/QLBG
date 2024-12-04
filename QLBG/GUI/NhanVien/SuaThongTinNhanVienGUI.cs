using BUS;
using DTO;
using Guna.UI2.WinForms;
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

namespace GUI.NhanVien
{
    public partial class SuaThongTinNhanVienGUI : Form
    {
        NhanVienDTO nvDto;
        NhanVienBUS nvBus = new NhanVienBUS();
        TaiKhoanDTO tkDto;
        //TaiKhoanBUS tkBus = new TaiKhoanBUS();
        DataGridView tblNv;
        bool kichHoatSua = false;
        public SuaThongTinNhanVienGUI(NhanVienDTO nvDto, DataGridView tblNv)
        {
            InitializeComponent();
            this.nvDto = nvDto;
            //this.tkDto = tkDto;
            this.tblNv = tblNv;
            showThongTin();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            tbSdt.Enabled = true;
            kichHoatSua = true;
            tbTenNv.Enabled = true;
            dateNgaySinh.Enabled = true;
            rtbDiaChi.Enabled = true;
            rbNam.Enabled = true;
            rbNu.Enabled = true;
            guna2TextBox1.Enabled = true;



        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (kichHoatSua)
            {
                suaThongTinNhanVien();
            }
            else
                this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      

        public void showThongTin()
        {
            tbMaNv.Enabled = false;
            tbTenNv.Enabled = false;
            tbSdt.Enabled = false;
            dateNgaySinh.Enabled = false;
            rbNam.Enabled = false;
            rbNu.Enabled = false;
            rtbDiaChi.Enabled = false;
            guna2TextBox1.Enabled = false;


            tbMaNv.Text = nvDto.maNV;
            tbTenNv.Text = nvDto.tenNV;
            tbSdt.Text = nvDto.sdt.Trim();
            rtbDiaChi.Text = nvDto.diaChi;
            //    rbNam.Checked = true;

            if (nvDto.gioiTinh.Equals("Nam"))
            {
                rbNam.Checked = true;
            }
            else
            {
                rbNu.Checked = true;
            }
            dateNgaySinh.Text = nvDto.ngaySinh;
            guna2TextBox1.Text= nvDto.email;

        }


        public void suaThongTinNhanVien()
        {
            if (checkNgaySinhVaSdt() && CheckEmai(guna2TextBox1.Text))
            {
                if (tbTenNv.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập tên nhân viên!");
                }
                else
                if (rtbDiaChi.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đia chỉ nhân viên!");
                }
                else

                if (!rbNam.Checked && !rbNu.Checked)
                {
                    MessageBox.Show("Vui lòng chọn giới tính cho nhân viên!");
                }
                else
                    
                //if (tbSdt.Text != "" && CheckPhoneNumber(tbSdt.Text.Trim()) && checkDate(dateNgaySinh.Value))
                {
                    
                    string gt = "";
                    if (rbNu.Checked)
                    {
                        gt = "Nữ";
                    }
                    else
                    {
                        gt = "Nam";
                    }
                    this.nvDto.tenNV = tbTenNv.Text;
                    //this.nvDto.ngaySinhNv = xuLyNgaySinh();
                    this.nvDto.ngaySinh = dateNgaySinh.Value.ToShortDateString();
                    this.nvDto.sdt = tbSdt.Text.Trim();
                    this.nvDto.chucVu = this.nvDto.chucVu;
                    this.nvDto.diaChi = rtbDiaChi.Text;
                    this.nvDto.gioiTinh=gt;
                    this.nvDto.email= guna2TextBox1.Text;
                    //updatePhanQuyen(nvDto.chucVu);
                    if (nvBus.suaNhanVien(nvDto)/* &&tkBus.suaTk(tkDto)*/)
                    {
                        tblNv.DataSource = nvBus.getNhanVien();
                        MessageBox.Show("Sửa thành công!");
                        this.Dispose();
                    }
                    else
                        MessageBox.Show("Sửa thất bại!");
                }
            }

            else if (tbSdt.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin vào!");
            }
        }

        public bool checkNgaySinhVaSdt()
        {
            if (CheckPhoneNumber(tbSdt.Text.Trim()) && checkDate(dateNgaySinh.Value))
            {
                return true;
            }
           
            return false;
        }

        public bool CheckEmai(string emai)
        {
            // Kiểm tra nếu email trống
            if (string.IsNullOrWhiteSpace(emai))
            {
                MessageBox.Show("Email không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Định nghĩa regex kiểm tra email hợp lệ
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(emai, emailPattern))
            {
                MessageBox.Show("Email không hợp lệ! Vui lòng nhập đúng định dạng email.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            foreach (NhanVienDTO nv in nvBus.getList())
            {
                if (emai.Equals(nv.email.Trim()) )
                {
                    if (!tbMaNv.Text.Equals(nv.maNV))
                    {
                        MessageBox.Show("email thoại bị trùng");
                        return false;
                    }
                    else
                        return true;
                }
            }

            // Email hợp lệ
            return true;
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

            // Kiểm tra trùng lặp với danh sách nhân viên
            foreach (NhanVienDTO nv in nvBus.getList())
            {
                if (phoneNumber.Equals(nv.sdt.Trim()) && nv.tinhTrang == true)
                {
                    if (!tbMaNv.Text.Equals(nv.maNV))
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
                MessageBox.Show("Số điện thoại không đúng định dạng");
                return false;
            }
            return true;
        }



        public bool checkDate(DateTime ngayTrongMaskedTextBox)
        {



            DateTime ngayHienTai = DateTime.Now;
            DateTime ngay18Tuoi = ngayHienTai.AddYears(-18); // Tính ngày 18 tuổi trước ngày hiện tại

            if (ngayHienTai > ngayTrongMaskedTextBox)
            {
                if (ngayTrongMaskedTextBox <= ngay18Tuoi)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Ngày sinh nhỏ hơn 18 tuổi!");
                    return false;
                }

                //    Console.WriteLine("Ngày hiện tại lớn hơn ngày trong chuỗi.");
            }
            else if (ngayHienTai <= ngayTrongMaskedTextBox)
            {
                MessageBox.Show("Không được lớn hơn ngày hiện tại!");
                //      MessageBox.Show("ngày sinh lớn hơn ngày hiện tại " + ngayTrongMaskedTextBox.ToString());
                return false;
            }


            return false;
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SuaThongTinNhanVienGUI_Load(object sender, EventArgs e)
        {

        }
    }
}
