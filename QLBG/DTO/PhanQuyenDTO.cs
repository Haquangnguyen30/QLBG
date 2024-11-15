using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhanQuyenDTO
    {
        public int maQuyen { get; set; }
        public string tenQuyen { get; set; }
        public bool qlyTK { get; set; }
        public bool qlyBH { get; set; }
        public bool qlySP { get; set; }
        public bool qlyNV { get; set; }
        public bool qlyKH { get; set; }
        public bool qlyKM { get; set; }
        public bool qlyNH { get; set; }
        public bool xemThongKe { get; set; }

        public PhanQuyenDTO() { }

        public PhanQuyenDTO(int maQuyen, string tenQuyen, bool qlyTK, bool qlyBH, bool qlySP, bool qlyNV, bool qlyKH, bool qlyKM, bool qlyNH, bool xemThongKe)
        {
            this.maQuyen = maQuyen;
            this.tenQuyen = tenQuyen;
            this.qlyTK = qlyTK;
            this.qlyBH = qlyBH;
            this.qlySP = qlySP;
            this.qlyNV = qlyNV;
            this.qlyKH = qlyKH;
            this.qlyKM = qlyKM;
            this.qlyNH = qlyNH;
            this.xemThongKe = xemThongKe;
        }
    }
}
