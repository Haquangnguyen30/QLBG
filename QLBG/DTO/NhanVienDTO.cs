using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        public string maNV { get; set; }
        public string tenNV { get; set; }
        public string gioiTinh { get; set; }    
        public string sdt { get; set; }
        public string diaChi { get; set; }
        public string chucVu { get; set; }       
        public string ngaySinh { get; set; }
        public bool tinhTrang { get; set; }

        public NhanVienDTO() { }

        public NhanVienDTO(string maNV, string tenNV, string gioiTinh, string sdt, string diaChi, string chucVu, string ngaySinh, bool tinhTrang)
        {
            this.maNV = maNV;
            this.tenNV = tenNV;
            this.gioiTinh = gioiTinh;
            this.sdt = sdt;
            this.diaChi = diaChi;
            this.chucVu = chucVu;
            this.ngaySinh = ngaySinh;
            this.tinhTrang = tinhTrang;
        }
    }
}
