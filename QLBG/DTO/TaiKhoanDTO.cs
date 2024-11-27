using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoanDTO
    {
        public string maNV { get; set; }
        public int maQuyen { get; set; }
        public string tenDangNhap { get; set; }
        public string matKhau { get; set; }
        public bool tinhTrang { get; set; }
        public TaiKhoanDTO() { }

        public TaiKhoanDTO(string maNV, int maQuyen, string tenDangNhap, string matKhau, bool tinhTrang)
        {
            this.maNV = maNV;
            this.maQuyen = maQuyen;
            this.tenDangNhap = tenDangNhap;
            this.matKhau = matKhau;
            this.tinhTrang = tinhTrang;
        }
    }
}
