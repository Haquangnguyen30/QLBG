using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SanPham_KichCoBUS
    {
        SanPham_KichCoDAL spkcDAL = new SanPham_KichCoDAL();
        public DataTable getChiTietSoLuong(string maSP)
        {
            return spkcDAL.getChiTietSoLuong(maSP);
        }
    }
}
