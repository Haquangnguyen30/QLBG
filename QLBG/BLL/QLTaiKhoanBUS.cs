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
    public class QLTaiKhoanBUS
    {
        TaiKhoanDTO dto = new TaiKhoanDTO();
        QLTaiKhoanDAL dal = new QLTaiKhoanDAL();
        // thêm tài khoản
        public bool themTaiKhoan(TaiKhoanDTO dto)
        {
            if (!dal.kiemTraTenTrungLap(dto.tenDangNhap))
            {
                return dal.themTaiKhoan(dto);
            }
            return false;
        }

        // lấy mã nhân viên
        // lấy mã nhân viên
        public string LayMaNhanVien(string tenDangNhap, string matKhau)
        {
            return dal.LayMaNhanVien(tenDangNhap, matKhau);
        }
        // lấy tên đăng nhập theo mã nhân viên
        public string LayTenNhanVien(string tenDangNhap, string matKhau)
        {
            return dal.LayTenNhanVien(tenDangNhap, matKhau);
        }

        public TaiKhoanDTO getTk(string maNv)
        {
            return dal.getTk(maNv);
        }

        public bool xoaNhanVien(string maNv)
        {
            return dal.xoaNhanVien(maNv);
        }

        public List<bool> getDSQuyen(int maQuyen)
        {
            return dal.getDSQuyen(maQuyen);
        }
        public DataTable getTaiKhoan()
        {
            return dal.getTaiKhoan();
        }
        public DataTable getAllMaNhanVien()
        {
            return dal.getAllMaNhanVien();
        }
        public DataTable getAllMaQuyen()
        {
            return dal.getAllMaQuyen();
        }

        public bool suaTaiKhoan(TaiKhoanDTO dto)
        {
            return dal.suaTaiKhoan(dto);
        }

        public bool suaTk(TaiKhoanDTO tk)
        {
            return dal.suaTk(tk);
        }
    }
}
