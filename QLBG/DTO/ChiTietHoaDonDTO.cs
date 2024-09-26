using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHoaDonDTO
    {
        public int maHD { get; set; }
        public string maSP { get; set; }
        public float giaBan { get; set; }
        public int soLuong { get; set; }
        public int maKM { get; set; }
        public int donViGiam { get; set; }
        public float thanhTien { get; set; }
        
        public List<SanPhamDTO> DanhSachSanPham { get; set; }
        public ChiTietHoaDonDTO(int maHD, string maSP, int giaBan, int soLuong, int maKM,int donViGiam, float thanhTien)
        {
            this.maHD = maHD;
            this.maSP = maSP;
            this.giaBan = giaBan;
            this.soLuong = soLuong;
            this.maKM = maKM;
            this.donViGiam = donViGiam;
            this.thanhTien = thanhTien;
        }
        public ChiTietHoaDonDTO() { }
    }
}
