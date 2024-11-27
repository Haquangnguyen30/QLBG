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
    public class LoaiSanPhamBUS
    {
        LoaiSanPhamDAL lspDAL = new LoaiSanPhamDAL();
        public DataTable getDSLoaiSanPham()
        {
            return lspDAL.getDSLoaiSanPham();
        }
        
        public DataTable getMaLSP()
        {
            return lspDAL.getMaLSP();
        }
        public bool addLoaiSanPham(LoaiSanPhamDTO loai)
        {
            return lspDAL.addLoaiSanPham(loai);
        }
        public bool updateLoaiSanPham(LoaiSanPhamDTO loai)
        {
            return lspDAL.updateLoaiSanPham(loai);
        }
        public bool deleteLoaiSanPham(LoaiSanPhamDTO loai)
        {
            return lspDAL.deleteLoaiSanPham(loai);
        }
    }
}
