﻿using BUS;
using DTO;
using GUI.UserControls;
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
    public partial class ThongTinNhanVienGUI : Form
    {
        DataGridView tblNv;
        NhanVienDTO nvDto;
        TaiKhoanDTO tkDto;
        NhanVienBUS nvBus = new NhanVienBUS();
        UC_NhanVien nvGui;
        public ThongTinNhanVienGUI(UC_NhanVien nvGui, DataGridView tblNv)
        {
            InitializeComponent();
            this.nvGui = nvGui;
            this.tblNv = tblNv;
            this.tbMaNv.Text = capNhatId2();
            this.tbMaNv.Enabled = false;
            this.tblNv = tblNv;
        }

        private void btnLuu_Click(object sender, EventArgs e)
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
                //if (tbTenNv.Text != "" && tbSdt.Text != "" && (rbNam.Checked || rbNu.Checked) && dateNgaySinh.Value.ToShortDateString() != "" && rtbDiaChi.Text != "")
                {

                    nvDto = new NhanVienDTO(capNhatId2(), tbTenNv.Text, XuLyGioiTinh(), tbSdt.Text.Trim(), rtbDiaChi.Text, "Tạm chưa có", dateNgaySinh.Value.ToShortDateString(), true, guna2TextBox1.Text);
                    int maSo = nvBus.getList().Count + 1;
                    string tenDn = "nhanvien" + maSo;
                    string mk = "nhanvien" + maSo;
                    if (nvBus.themNhanVien(nvDto))
                    {
                        /* if(taoTk(nvDto.chucVu, nvDto.maNv, tenDn, mk))
                         {*/
                        MessageBox.Show("thêm thành công");
                        tblNv.DataSource = nvBus.getNhanVien();
                        this.Dispose();
                        /*  }
                          else
                              MessageBox.Show("thêm thất bại");*/

                    }
                    else
                        MessageBox.Show(nvDto.maNV + " " + nvDto.tenNV + " " + nvDto.gioiTinh + " " + nvDto.sdt + " " + nvDto.diaChi + " " + nvDto.chucVu + " " + nvDto.ngaySinh);
                }
            }
            else
            {
                if (tbTenNv.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập tên nhân viên!");
                }
                if (rtbDiaChi.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đia chỉ nhân viên!");
                }

                if (!rbNam.Checked && !rbNu.Checked)
                {
                    MessageBox.Show("Vui lòng chọn giới tính cho nhân viên!");
                }

            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        public bool checkNgaySinhVaSdt()
        {
            if (CheckPhoneNumber(tbSdt.Text) && checkDate(dateNgaySinh.Value))
            {
                return true;
            }
            
            return false;
        }
        public String XuLyGioiTinh()
        {
            String gioiTinh = "Nam";
            if (rbNu.Checked)
            {
                gioiTinh = "Nữ";
            }
            return gioiTinh;

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
                    MessageBox.Show("Email bị trùng!");
                    return false;
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
                MessageBox.Show("Số điện thoại không được để trống!");
                return false;
            }

            // Kiểm tra độ dài của số điện thoại
            if (phoneNumber.Length != 10 || !phoneNumber.StartsWith("0"))
            {
                MessageBox.Show("Số điện thoại không hợp lệ!");
                return false;
            }

            // Kiểm tra trùng lặp với danh sách nhân viên
            foreach (NhanVienDTO nv in nvBus.getList())
            {
                if (phoneNumber.Equals(nv.sdt.Trim()) && nv.tinhTrang == true)
                {
                    MessageBox.Show("Số điện thoại bị trùng!");
                    return false;
                }
            }

            // Kiểm tra sự trùng khớp của số điện thoại với biểu thức chính quy
            if (!Regex.IsMatch(phoneNumber, phonePattern))
            {
                MessageBox.Show("Số điện thoại không đúng định dạng!");
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


        public string capNhatId2()
        {
            String maNv = "";
            int soMaNv = nvBus.getList().Count + 1;
            if (soMaNv >= 10)
            {
                maNv = "NV" + soMaNv;
            }
            else
                maNv = "NV0" + soMaNv;
            return maNv;
        }
    }
}
