using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PhanQuyenBUS
    {
        PhanQuyenDAL pqDAL = new PhanQuyenDAL();
        public PhanQuyenDTO getPhanQuyen(int id)
        {
            return pqDAL.getPhanQuyen(id); 
        }
    }
    
}
