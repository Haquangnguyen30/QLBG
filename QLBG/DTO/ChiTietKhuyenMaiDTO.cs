using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietKhuyenMaiDTO
    {
        public int maKM {  get; set; }
        public string maSP {  get; set; }
        public int donViGiam { get; set; }
        public int giaTriGiam {  get; set; }
        public ChiTietKhuyenMaiDTO() { }

        public ChiTietKhuyenMaiDTO(int maKM, string maSP, int donViGiam, int giaTriGiam)
        {
            this.maKM = maKM;
            this.maSP = maSP;
            this.donViGiam = donViGiam;
            this.giaTriGiam = giaTriGiam;
        }
    }
}
