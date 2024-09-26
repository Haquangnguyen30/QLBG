using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaCungCapDTO
    {
        public int maNCC { get; set; }
        public string tenNCC { get; set; }
        public string sdt { get; set; }
        public string diaChi { get; set; }
        public bool tinhTrang { get; set; }
        public NhaCungCapDTO() { }
        public NhaCungCapDTO(int maNCC, string tenNCC, string sdt, string diaChi, bool tinhTrang)
        {
            this.maNCC = maNCC;
            this.tenNCC = tenNCC;
            this.sdt = sdt;
            this.diaChi = diaChi;
            this.tinhTrang = tinhTrang;
        }
    }
}
