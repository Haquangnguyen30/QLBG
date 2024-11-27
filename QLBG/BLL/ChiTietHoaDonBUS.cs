using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class ChiTietHoaDonBUS
    {
        ChiTietHoaDonDAL cthdDAL = new ChiTietHoaDonDAL();
        public DataTable GetChiTietHoaDon(int maHD)
        {
            return cthdDAL.GetChiTietHoaDon(maHD);
        }
    }
}
