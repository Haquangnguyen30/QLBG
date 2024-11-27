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
    public class PhanQuyenBUS
    {
        private PhanQuyenDAL pqDAL = new PhanQuyenDAL();

        public DataTable getDSQuyen()
        {
            return pqDAL.getDSQuyen();
        }

        public int suaQuyen(int maQuyen, String columnName, bool check)
        {
            return pqDAL.suaQuyen(maQuyen, columnName, check); 
        }
        public PhanQuyenDTO getPhanQuyen(int id)
        {
            return pqDAL.getPhanQuyen(id);
        }
    }
    
}
