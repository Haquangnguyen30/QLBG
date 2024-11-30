using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TaiKhoanBUS
    {
        TaiKhoanDAL tkDAL = new TaiKhoanDAL();
        public TaiKhoanDTO getTaiKhoan(string tenDangNhap, string matKhau)
        {
            return tkDAL.getTaiKhoan(tenDangNhap, matKhau);
        }
        public bool updateMatKhau(string maNV, string matKhau)
        {
            return tkDAL.updateMatKhau(maNV, matKhau);
        }
    }
    
}
