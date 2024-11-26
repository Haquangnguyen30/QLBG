using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SanPhamBUS
    {
        SanPhamDAL spDAL = new SanPhamDAL();

        public int suaGiaNhapSP(String maSP, String giaNhap)
        {
           return spDAL.suaGiaNhapSP(maSP, giaNhap);
        }

        public bool isMaSPExist(String maSP)
        {
            return spDAL.isMaSPExist(maSP);
        }
    }
}
