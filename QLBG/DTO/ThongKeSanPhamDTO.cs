using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThongKeSanPhamDTO
    {
        public ThongKeSanPhamDTO()
        {
        }

        public ThongKeSanPhamDTO(String tenSP, int soLuongDaBan, String hinhAnh)
        {
            this.tenSP = tenSP;
            this.soLuongDaBan = soLuongDaBan;
            this.hinhAnh = hinhAnh;
        }

        public String tenSP { get; set; }
        public int soLuongDaBan { get; set; }
        public String hinhAnh { get; set; }
    }
}
