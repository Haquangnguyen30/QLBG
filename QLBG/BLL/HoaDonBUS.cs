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
        // get hóa đơn mới nhất
        public int GetMaHoaDonMoiNhat()
        {
            return dAL.GetMaHoaDonMoiNhat();
        }
        // tìm kiếm hóa đơn theo khoảng ngày

        public DataTable TimKiemHoaDon(string key)
        {
            return dAL.TimKiemHoaDon(key);
        }
        public int themHD(HoaDonDTO hd, List<ChiTietHoaDonDTO> cthds)
        {
            // Thêm hóa đơn vào bảng hoaDon và lấy mã hóa đơn mới
            int maHD = dAL.TaoHoaDon(hd);

            // Thêm chi tiết hóa đơn vào bảng CT_HoaDon
            cthdDal.ThemChiTietHoaDon(cthds, maHD);

            // Cập nhật tồn kho sau khi bán hàng
            foreach (var chiTiet in cthds)
            {
                int slTonKho = spDAL.getSoLuongKichCo(chiTiet.maSP, chiTiet.maKC);
                int newSL = slTonKho - chiTiet.soLuong;

                // Nếu có đủ hàng, cập nhật số lượng tồn kho
                if (slTonKho > 0)
                {
                    spDAL.suaSoLuongKichCo(chiTiet.maSP, chiTiet.maKC, newSL);
                }
                // Nếu không còn hàng, cần xử lý thêm logic phù hợp như thông báo hết hàng
                else if (slTonKho == 0)
                {
                    spDAL.themSoLuongKichCo(chiTiet.maSP, chiTiet.maKC, newSL);
                }
                // Trường hợp tồn kho âm (nếu có), cần cảnh báo hoặc xử lý lỗi
                else
                {
                    throw new Exception("Số lượng tồn kho không đủ để bán!");
                }
            }

            return maHD; // Trả về mã hóa đơn vừa thêm
        }

        public DataTable getHoaDonChuaDoi()
        {
            return dAL.getHoaDonChuaDoi();
        }

        public void updateTinhTrangHoaDon(String maHD)
        {
            dAL.updateTinhTrangHoaDon(maHD);
        }

        public int getMaKMByMaHD(int maHD)
        {
            return dAL.getMaKMByMaHD(maHD);
        }

    }
}
