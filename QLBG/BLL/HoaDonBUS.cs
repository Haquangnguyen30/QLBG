using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HoaDonBUS
    {
        HoaDonDTO dTO = new HoaDonDTO();
        HoaDonDAL dAL = new HoaDonDAL();
        ChiTietHoaDonBUS cthdBus = new ChiTietHoaDonBUS();
        ChiTietHoaDonDAL cthdDal = new ChiTietHoaDonDAL();
        private SanPhamDAL spDAL = new SanPhamDAL();
        public DataTable getDSHD()
        {
            return dAL.getDSHD();
        }
        //public bool TaoHoaDon(HoaDonDTO hoaDon)
        //{
        //    bool taoHoaDonThanhCong = dAL.TaoHoaDon(hoaDon);
        //    if (taoHoaDonThanhCong)
        //    {
        //        int maHoaDonMoiNhat = dAL.GetMaHoaDonMoiNhat();
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        // get hóa đơn mới nhất
        public int GetMaHoaDonMoiNhat()
        {
            return dAL.GetMaHoaDonMoiNhat();
        }
        // tìm kiếm hóa đơn theo khoảng ngày
        public DataTable TimKiemHoaDonTheoKhoangNgay(DateTime fromDate, DateTime toDate)
        {
            return dAL.TimKiemHoaDonTheoKhoangNgay(fromDate, toDate);
        }
        public DataTable TimKiemHoaDon(string key)
        {
            return dAL.TimKiemHoaDon(key);
        }
        public int themHD(HoaDonDTO hd, List<ChiTietHoaDonDTO> cthds)
        {
            int maHD = dAL.TaoHoaDon(hd);
            cthdDal.ThemChiTietHoaDon(cthds, maHD);
            foreach (var chiTiet in cthds)
            {
                int slTonKho = spDAL.getSoLuongKichCo(chiTiet.maSP, chiTiet.maKC);
                int newSL = slTonKho - chiTiet.soLuong;
                if (slTonKho > 0)
                {
                    spDAL.suaSoLuongKichCo(chiTiet.maSP, chiTiet.maKC, newSL);
                }
                else if (slTonKho == 0)
                {
                    spDAL.themSoLuongKichCo(chiTiet.maSP, chiTiet.maKC, newSL);
                }
            }
            return maHD;
        }
    }
}
