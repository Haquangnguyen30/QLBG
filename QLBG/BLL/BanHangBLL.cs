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
    public class BanHangBLL
    {
        BanHangDAL dal = new BanHangDAL();
        public List<SanPhamDTO> GetDSSP(int itemsPerPage, int startLine)
        {

            List<SanPhamDTO> productList = dal.GetDSSP(itemsPerPage, startLine);
            return productList;
        }
        public int GetSoLuongTheoSize(string maSP, int maKC)
        {
            return dal.GetSoLuongTheoSize(maSP, maKC);
        }
        public List<KichCoDTO> GetSizeTheoSP(string maSP)
        {
            List<KichCoDTO> listSize = dal.GetSizeTheoSP(maSP);
            return listSize;
        }
        public List<SanPhamDTO> TimKiemSanPham(string keyword, int itemsPerPage, int startLine)
        {
            return dal.TimKiemSanPham(keyword, itemsPerPage, startLine);
        }
        public int countAllSP()
        {
            return dal.countAllSP();
        }

        public int countFilteredSP(string keyword)
        {
            return dal.countFilteredSP(keyword);
        }
    }
}
