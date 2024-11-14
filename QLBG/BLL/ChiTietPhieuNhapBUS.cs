using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ChiTietPhieuNhapBUS
    {
        private ChiTietPhieuNhapDAL ctpnDAL = new ChiTietPhieuNhapDAL();

        public DataTable getCTPN(String maPN, String tenSP, String mauSac, String kichCo, String giaNhap, bool checkedDown)
        {
            return ctpnDAL.getCTPN(maPN, tenSP, mauSac, kichCo, giaNhap, checkedDown);
        }
    }
}
