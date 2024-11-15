using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHangDTO
    {
        public int maKH { get; set; }
        public string tenKH { get; set; }
        public string sdt { get; set; }            

        public KhachHangDTO() { }

        public KhachHangDTO(int maKH, string tenKH, string sdt)
        {
            this.maKH = maKH;
            this.tenKH = tenKH;
            this.sdt = sdt;
        }
    }
}
