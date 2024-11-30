using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThongKeThangDTO
    {
        public int thang { get; set; }
        public Double tongTien { get; set; }
        public ThongKeThangDTO() { }

        public ThongKeThangDTO(int thang, double tongTien)
        {
            this.thang = thang;
            this.tongTien = tongTien;
        }
    }
}
