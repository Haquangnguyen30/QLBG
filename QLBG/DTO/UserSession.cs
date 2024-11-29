using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UserSession
    {
        private static UserSession instance;
        public NhanVienDTO currentNV { get; private set; }
        public PhanQuyenDTO currentPQ { get; private set; }

        private UserSession() { }

        public static UserSession Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserSession();
                }
                return instance;
            }
        }

        public void Login(NhanVienDTO nv, PhanQuyenDTO pq)
        {
            currentNV = nv;
            currentPQ = pq;
        }
    }
}
