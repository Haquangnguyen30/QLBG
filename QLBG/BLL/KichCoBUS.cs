using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KichCoBUS
    {
        KichCoDAL kcDAL = new KichCoDAL();
        public DataTable getDSKichCo()
        {
            return kcDAL.getDSKichCo();
        }
    }
}
