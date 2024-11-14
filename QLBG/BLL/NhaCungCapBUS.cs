using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhaCungCapBUS
    {
        NhaCungCapDAL nccDAL = new NhaCungCapDAL();

        public DataTable getDSNCC(String searchString, bool radioTenNCC, bool radioSDT, bool radioDiaChi)
        {
            return nccDAL.getDSNCC(searchString, radioTenNCC, radioSDT, radioDiaChi); 
        }

        public DataTable getDSTenNCC()
        {
            return nccDAL.getDSTenNCC();
        }

        public int themNCC(NhaCungCapDTO ncc)
        {
            return nccDAL.themNCC(ncc);
        }
        
        public int getMaxIDNCC()
        {
            return nccDAL.getMaxIDNCC();
        }
        public int suaNCC(NhaCungCapDTO ncc)
        {
            return nccDAL.suaNCC(ncc);
        }

        public int xoaNCC(int maNCC)
        {
            return nccDAL.xoaNCC(maNCC);
        }
    }
}
