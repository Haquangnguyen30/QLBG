using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonDTO
    {
        public int maHD { get; set; }
        public string maNV { get; set; }
        public int maKH { get; set; }
        public DateTime ngayLap { get; set; }
        public float tongTien { get; set; }
        public float tienKhachDua { get; set; }
        public float tienThua { get; set; }
        public bool tinhTrang { get; set; }



        public HoaDonDTO()
        {

        }

        public HoaDonDTO(int maHD, string maNV, int maKH, DateTime ngayLap, float tongTien, float tienKhachDua, float tienThua, bool tinhTrang)
        {
            this.maHD = maHD;
            this.maNV = maNV;
            this.maKH = maKH;
            this.ngayLap = ngayLap;
            this.tongTien = tongTien;
            this.tienKhachDua = tienKhachDua;
            this.tienThua = tienThua;
            this.tinhTrang = tinhTrang;
        }
    }
}
