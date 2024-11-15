using DAL;
using System;
using System.Collections.Generic;
using System.Data;
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

        //PhuocDo
        public DataTable getDSSanPham()
        {
            return spDAL.getDSSanPham();
        }
    }
}
