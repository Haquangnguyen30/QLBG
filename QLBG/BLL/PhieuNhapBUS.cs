using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PhieuNhapBUS
    {
        private PhieuNhapDAL pnDAL = new PhieuNhapDAL();
        private ChiTietPhieuNhapDAL ctpnDAL = new ChiTietPhieuNhapDAL();
        private SanPhamDAL spDAL = new SanPhamDAL();

        public DataTable getDSPN(String fromDate, String toDate, String nv, String ncc, String tongTien, bool checkDown)
        {
            return pnDAL.getDSPN(fromDate, toDate, nv, ncc, tongTien, checkDown);
        }
        
        public DataTable getDSSP(String searchStr)
        {
            return spDAL.getDSSP(searchStr);
        }

        public void themPN(PhieuNhapDTO pn, List<ChiTietPhieuNhapDTO> ctpns)
        {
            int maPN = pnDAL.ThemPhieuNhap(pn);
            ctpnDAL.ThemChiTietPhieuNhap(ctpns, maPN);
            foreach(var chiTiet in ctpns)
            {
                int slTonKho = spDAL.getSoLuongKichCo(chiTiet.maSP, chiTiet.makichCo);
                int newSL = slTonKho + chiTiet.soLuong;
                if (slTonKho > 0)
                {
                    spDAL.suaSoLuongKichCo(chiTiet.maSP, chiTiet.makichCo, newSL);
                } else if(slTonKho == 0)
                {
                    spDAL.themSoLuongKichCo(chiTiet.maSP, chiTiet.makichCo, newSL);
                }
            }
        }

        public int getMaxMaPN()
        {
            return pnDAL.getMaxMaPN();
        }

    }
}
