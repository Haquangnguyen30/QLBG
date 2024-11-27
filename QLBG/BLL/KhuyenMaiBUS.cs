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
    public class KhuyenMaiBUS
    {
        KhuyenMaiDAL khuyenMaiDal = new KhuyenMaiDAL();
        public List<KhuyenMaiDTO> getList()
        {
            return khuyenMaiDal.getList();
        }
        public DataTable getKhuyenMai()
        {
            return khuyenMaiDal.getKhuyenMai();
        }
        public bool themKhuyenMai(KhuyenMaiDTO km)
        {
            return khuyenMaiDal.ThemKhuyenMai(km);
        }

        public bool suaKhuyenMai(KhuyenMaiDTO km)
        {
            return khuyenMaiDal.SuaKhuyenMai(km);
        }

        public bool xoaKhuyenMai(int maKM)
        {
            return khuyenMaiDal.XoaKhuyenMai(maKM);
        }
        public DataTable getKhuyenMaiHieuLuc()
        {
            return khuyenMaiDal.getKhuyenMaiHieuLuc();
        }
    }
}

