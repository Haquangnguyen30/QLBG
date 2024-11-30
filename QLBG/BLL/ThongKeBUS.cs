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
    public class ThongKeBUS
    {
        HoaDonDTO hoaDonDTO = new HoaDonDTO();
        PhieuNhapDTO phieuNhapDTO = new PhieuNhapDTO();
        private ThongKeDAL thongkeDAL = new ThongKeDAL();
        public List<ThongKeNgayDTO> GetThongKeHoaDonTheoNgay(String fromDate, String toDate)
        {
            return thongkeDAL.getDSThongKeHoaDonTheoNgay(fromDate, toDate);
        }

        public List<ThongKeNgayDTO> GetThongKePhieuNhapTheoNgay(String fromDate, String toDate)
        {
            return thongkeDAL.getDSThongKePhieuNhapTheoNgay(fromDate, toDate);
        }
        public List<ThongKeThangDTO> getThongKeHoaDonTheoThang(String fromDate, String toDate)
        {
            return thongkeDAL.getThongKeHoaDonTheoThang(fromDate, toDate);
        }
        public List<ThongKeThangDTO> getThongKePhieuNhapTheoThang(String fromDate, String toDate)
        {
            return thongkeDAL.getThongKePhieuNhapTheoThang(fromDate, toDate);
        }
        public List<ThongKeSanPhamDTO> GetTop5SanPhamBanChay(String fromDate, String toDate)
        {
            return thongkeDAL.GetTop5SanPhamBanChay(fromDate, toDate);
        }
    }
}
