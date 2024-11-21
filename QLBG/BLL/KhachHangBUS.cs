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
    public class KhachHangBUS
    {
        KhachHangDAL dalKhachHang = new KhachHangDAL();

        public List<KhachHangDTO> getList()
        {
            return dalKhachHang.getList();
        }
        public DataTable getKhachHang()
        {
            return dalKhachHang.getKhachHang();
        }

        public DataTable getFindKhachHang(string key)
        {
            return dalKhachHang.getFindKhachHang(key);
        }

        public bool suakhachHang(KhachHangDTO tv)
        {
            return dalKhachHang.suakhachHang(tv);
        }

        public KhachHangDTO findSdt(string sdt)
        {
            return dalKhachHang.findSdt(sdt);
        }

        public bool themKhachHang(KhachHangDTO tv)
        {
            return dalKhachHang.themKhachHang(tv);
        }
    }
}
