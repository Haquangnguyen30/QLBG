using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class ChiTietHoaDonBUS
    {
        ChiTietHoaDonDAL cthdDAL = new ChiTietHoaDonDAL();
        public DataTable GetChiTietHoaDon(int maHD)
        {
            return cthdDAL.GetChiTietHoaDon(maHD);
        }

        public void ThemChiTietHoaDon(List<ChiTietHoaDonDTO> chiTietHoaDons, int maHD)
        {
            cthdDAL.ThemChiTietHoaDon(chiTietHoaDons, maHD);
        }

        public void updateSoLuongSauDoi(int maHD, String maSP, int maKC, int slGiuLai, float thanhTien)
        {
            cthdDAL.updateSoLuongSauDoi(maHD, maSP, maKC, slGiuLai, thanhTien);
        }

        public void deleteSoLuongSauDoi(int maHD, String maSP, int maKC)
        {
            cthdDAL.deleteSoLuongSauDoi(maHD, maSP, maKC);
        }
    }
}
