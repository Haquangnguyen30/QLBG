using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class sanPham_kichCoDTO
    {
        public string maSP {  get; set; }
        public int maKichCo { get; set; }
        public int soLuong {  get; set; }
        public bool tinhTrang {  get; set; }

        public sanPham_kichCoDTO() { }

        public sanPham_kichCoDTO(string maSP, int maKichCo, int soLuong, bool tinhTrang)
        {
            this.maSP = maSP;   
            this.maKichCo = maKichCo;
            this.soLuong = soLuong;
            this.tinhTrang = tinhTrang;
        } 

    }
}
