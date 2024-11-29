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
        public List<KhachHangDTO> TimKiemKhachHangTheoKey(string key)
        {
            DataTable dt = dalKhachHang.getFindKhachHang(key);
            List<KhachHangDTO> result = new List<KhachHangDTO>();

            foreach (DataRow row in dt.Rows)
            {
                KhachHangDTO kh = new KhachHangDTO
                {
                    maKH = Convert.ToInt32(row["maKH"]),
                    tenKH = row["tenKH"].ToString(),
                    sdt = row["sdt"].ToString()
                };
                result.Add(kh);
            }

            return result;
        }
        public int getMaxMaKH()
        {
            return dalKhachHang.getMaxMaKH();
        }
    }
}
