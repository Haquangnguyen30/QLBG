using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPhamDTO
    {
        public string maSP { get; set; }
        public string tenSP { get; set; }
        public float giaBan { get; set; }
        public int soLuong { get; set; }
        public string img { get; set; }
        public float giaNhap { get; set; }
        public bool tinhTrang { get; set; }
        public int maLoai { get; set; }
        public string mau { get; set; }
        public SanPhamDTO() { }

        public SanPhamDTO(string maSP, string tenSP, float giaBan, int soLuong, string img, float giaNhap, bool tinhTrang, int maLoai, string mau)
        {
            this.maSP = maSP;
            this.tenSP = tenSP;
            this.giaBan = giaBan;
            this.soLuong = soLuong;
            this.img = img;
            this.giaNhap = giaNhap;
            this.tinhTrang = tinhTrang;
            this.maLoai = maLoai;
            this.mau= mau;
       
        }
    }
}
