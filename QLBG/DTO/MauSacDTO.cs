using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MauSacDTO
    {
        public int maMau { get; set; }
        public string tenMau { get; set; }
        public bool tinhtrang { get; set; }
        public MauSacDTO()
        {
        }

        public MauSacDTO(int maMau, string tenMau, bool tinhtrang)
        {
            this.maMau = maMau;
            this.tenMau = tenMau;
            this.tinhtrang = tinhtrang;
        }
    }
}
