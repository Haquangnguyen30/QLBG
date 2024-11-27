using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhuyenMaiDTO
    {
        public int maKM {  get; set; }
        public string tenKM { get; set; }
        public int giaTriGiam { get; set; }
        public DateTime ngayBatDau { get; set; }
        public DateTime ngayKetThuc {  get; set; }
        public bool tinhTrang { get; set; }
        public KhuyenMaiDTO() { }

        public KhuyenMaiDTO(int maKM, string tenKM, int giaTriGiam, DateTime ngayBatDau, DateTime ngayKetThuc, bool tinhTrang)
        {
            this.maKM = maKM;
            this.tenKM = tenKM;
            this.ngayBatDau = ngayBatDau;
            this.ngayKetThuc = ngayKetThuc;
            this.giaTriGiam = giaTriGiam;
            this.tinhTrang = tinhTrang;
            this.tinhTrang= tinhTrang;
        }
    }
}
