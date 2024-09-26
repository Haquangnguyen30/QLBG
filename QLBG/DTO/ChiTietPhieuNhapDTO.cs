using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietPhieuNhapDTO
    {
        public int maPN { get; set; }
        public string maSP { get; set; }
        public float giaNhap { get; set; }
        public int soLuong { get; set; }
        public float thanhTien { get; set; }
        public bool tinhTrang { get; set; }

        public ChiTietPhieuNhapDTO() { }

        public ChiTietPhieuNhapDTO(int maPN, string maSP, float giaNhap, int soLuong, float thanhTien, bool tinhTrang)
        {
            this.maPN = maPN;
            this.maSP = maSP;
            this.giaNhap = giaNhap;
            this.soLuong = soLuong;
            this.thanhTien= thanhTien;
            this.tinhTrang = tinhTrang;
        }
    }
}
