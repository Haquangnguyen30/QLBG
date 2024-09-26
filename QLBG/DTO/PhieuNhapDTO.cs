using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuNhapDTO
    {
        public int maPN { get; set; }
        public string maNV { get; set; }
        public int maNCC { get; set; }
        public DateTime ngayLap { get; set; }
        public float tongTien { get; set; }
        public bool tinhTrang { get; set; }

        public PhieuNhapDTO()
        {

        }

        public PhieuNhapDTO(int maPN, string maNV, int maNCC, DateTime ngayLap, float tongTien, bool tinhTrang)
        {
            this.maPN = maPN;
            this.maNV = maNV;
            this.maNCC = maNCC;
            this.ngayLap = ngayLap;
            this.tongTien = tongTien;
            this.tinhTrang = tinhTrang;
        }
    }
}
