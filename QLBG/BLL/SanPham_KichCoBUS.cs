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
        SanPhamDAL spDAL = new SanPhamDAL();
        public DataTable getChiTietSoLuong(string maSP)
        {
            return spkcDAL.getChiTietSoLuong(maSP);
        }

        public int checkTonKhoSP(string maSP, int maKC)
        {
            return spkcDAL.checkTonKhoSP(maSP, maKC);
        }

        public int getSoLuongKichCo(String maSP, int makichCo)
        {
            return spDAL.getSoLuongKichCo(maSP, makichCo);
        }
        public int suaSoLuongKichCo(String maSP, int maKichCo, int soLuong)
        {
            return spDAL.suaSoLuongKichCo(maSP, maKichCo, soLuong);
        }

    }
}