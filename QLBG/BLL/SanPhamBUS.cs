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
    public class SanPhamBUS
    {
        SanPhamDAL spDAL = new SanPhamDAL();

        public int suaGiaNhapSP(String maSP, String giaNhap)
        {
           return spDAL.suaGiaNhapSP(maSP, giaNhap);
        }

        //PhuocDo
        public DataTable getDSSanPham()
        {
            return spDAL.getDSSanPham();
        }
        public DataTable getMaSP()
        {
            return spDAL.getMaSP(); 
        }
      
        public bool addSanPham(SanPhamDTO sanPham)
        {
            return spDAL.addSanPham(sanPham);
        }
        public bool updateSanPham(SanPhamDTO sanPham)
        {
            return spDAL.updateSanPham(sanPham);
        }
        public bool deleteSanPham(SanPhamDTO sanPham) 
        {
            return spDAL.deleteSanPham(sanPham);
        }
        public DataTable searchSanPham(string strSearch)
        {
            return spDAL.searchSanPham(strSearch);
        }

        public bool isMaSPExist(String maSP)
        {
            return spDAL.isMaSPExist(maSP);
        }
    }
}
