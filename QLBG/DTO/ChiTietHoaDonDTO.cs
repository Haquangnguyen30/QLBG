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
        public float thanhTien { get; set; }
        public int maKC { get; set; }
        public string maSPDoi { get; set; }
        public DateTime? ngayDoi { get; set; }
        public bool tinhTrangDoi    { get; set; }
        
        public List<SanPhamDTO> DanhSachSanPham { get; set; }

        public ChiTietHoaDonDTO(int maHD, string maSP, float giaBan, int soLuong, float thanhTien, int maKC, string maSPDoi, DateTime? ngayDoi, bool tinhTrangDoi, List<SanPhamDTO> danhSachSanPham)
        {
            this.maHD = maHD;
            this.maSP = maSP;
            this.giaBan = giaBan;
            this.soLuong = soLuong;
            this.thanhTien = thanhTien;
            this.maKC = maKC;
            this.maSPDoi = maSPDoi;
            this.ngayDoi = ngayDoi;
            this.tinhTrangDoi = tinhTrangDoi;
            DanhSachSanPham = danhSachSanPham;
        }

        public ChiTietHoaDonDTO() { }
    }
}
