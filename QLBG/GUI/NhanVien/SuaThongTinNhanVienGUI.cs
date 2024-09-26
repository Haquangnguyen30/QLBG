using BUS;
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


        }


        public void suaThongTinNhanVien()
        {
            if (checkNgaySinhVaSdt())
            {
                if (tbTenNv.Text == "")
                {
                    lbTenNv.Text = "Vui lòng nhập tên nhân viên!";
                }
                else
                    lbTenNv.Text = "";
                if (rtbDiaChi.Text == "")
                {
                    lbDiaChi.Text = "Vui lòng nhập đia chỉ nhân viên!";
                }
                else
                    lbDiaChi.Text = "";

                if (!rbNam.Checked && !rbNu.Checked)
                {
                    lbGioiTinh.Text = "Vui lòng chọn giới tính cho nhân viên!";
                }
                else
                    lbGioiTinh.Text = "";
                if (tbSdt.Text != "" && CheckPhoneNumber(tbSdt.Text.Trim()) && checkDate(dateNgaySinh.Value, lbNgaySinh))
                {
                    lbTenNv.Text = "";
                    lbSdt.Text = "";
                    lbNgaySinh.Text = "";
                    lbGioiTinh.Text = "";
                    lbChucVu.Text = "";
                    this.nvDto.tenNV = tbTenNv.Text;
                    //this.nvDto.ngaySinhNv = xuLyNgaySinh();
                    this.nvDto.ngaySinh = dateNgaySinh.Value.ToShortDateString();
                    this.nvDto.sdt = tbSdt.Text.Trim();
                    this.nvDto.chucVu = this.nvDto.chucVu;
                    this.nvDto.diaChi = rtbDiaChi.Text;
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
                lbSdt.Text = "Vui lòng nhập thông tin vào!";
            }
        }

        public bool checkNgaySinhVaSdt()
        {
            if (CheckPhoneNumber(tbSdt.Text.Trim()) && !checkDate(dateNgaySinh.Value, lbNgaySinh))
            {
                return true;
            }
            if (checkDate(dateNgaySinh.Value, lbNgaySinh) && !CheckPhoneNumber(tbSdt.Text.Trim()))
            {
                return true;
            }
            if (CheckPhoneNumber(tbSdt.Text.Trim()) && checkDate(dateNgaySinh.Value, lbNgaySinh))
            {
                return true;
            }
            if (checkDate(dateNgaySinh.Value, lbNgaySinh) && CheckPhoneNumber(tbSdt.Text.Trim()))
            {
                return true;
            }
            return false;
        }


        public bool CheckPhoneNumber(string phoneNumber)
        {
            // Biểu thức chính quy kiểm tra số điện thoại với định dạng cụ thể (10 số và bắt đầu bằng số 0)
            string phonePattern = @"^0\d{9}$";

            // Kiểm tra đầu vào là null hoặc rỗng
            if (string.IsNullOrEmpty(phoneNumber))
            {
                lbSdt.Text = "Số điện thoại không được để trống";
                return false;
            }

            // Kiểm tra độ dài của số điện thoại
            if (phoneNumber.Length != 10 || !phoneNumber.StartsWith("0"))
            {
                lbSdt.Text = "Số điện thoại không hợp lệ";
                return false;
            }

            // Kiểm tra trùng lặp với danh sách nhân viên
            foreach (NhanVienDTO nv in nvBus.getList())
            {
                if (phoneNumber.Equals(nv.sdt.Trim()) && nv.tinhTrang == true)
                {
                    if (!tbMaNv.Text.Equals(nv.maNV))
                    {
                        lbSdt.Text = "Số điện thoại bị trùng";
                        return false;
                    }
                    else
                        return true;
                }
            }

            // Kiểm tra sự trùng khớp của số điện thoại với biểu thức chính quy
            if (!Regex.IsMatch(phoneNumber, phonePattern))
            {
                lbSdt.Text = "Số điện thoại không đúng định dạng";
                return false;
            }
            lbSdt.Text = "";
            return true;
        }



        public bool checkDate(DateTime ngayTrongMaskedTextBox, Label lbngaySinh)
        {



            DateTime ngayHienTai = DateTime.Now;
            DateTime ngay18Tuoi = ngayHienTai.AddYears(-18); // Tính ngày 18 tuổi trước ngày hiện tại

            if (ngayHienTai > ngayTrongMaskedTextBox)
            {
                if (ngayTrongMaskedTextBox <= ngay18Tuoi)
                {
                    lbngaySinh.Text = "";
                    return true;
                }
                else
                {
                    lbngaySinh.Text = "Ngày sinh nhỏ hơn 18 tuổi!";
                    return false;
                }

                //    Console.WriteLine("Ngày hiện tại lớn hơn ngày trong chuỗi.");
            }
            else if (ngayHienTai <= ngayTrongMaskedTextBox)
            {
                lbngaySinh.Text = "Không được lớn hơn ngày hiện tại!";
                //      MessageBox.Show("ngày sinh lớn hơn ngày hiện tại " + ngayTrongMaskedTextBox.ToString());
                return false;
            }


            return false;
        }
        
    }
}
