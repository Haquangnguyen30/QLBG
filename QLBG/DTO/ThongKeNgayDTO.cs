using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThongKeNgayDTO
    {
        public ThongKeNgayDTO( DateTime ngayLap, double tongTien)
        {
            this.ngayLap = ngayLap;
            this.tongTien = tongTien;
        }
        public ThongKeNgayDTO(){ }
        public DateTime ngayLap { get; set; }
        public Double tongTien { get; set; }
        
    }
}
