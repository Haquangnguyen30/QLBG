using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhanVienBUS
    {
        NhanVienDAL dalNhanVien = new NhanVienDAL();

        public List<String> getDSNV()
        {
            return dalNhanVien.getDSNV();
        }

        public List<NhanVienDTO> getList()
        {
            return dalNhanVien.getList();
        }
        public DataTable getNhanVien()
        {
            return dalNhanVien.getNhanVien();
        }

        public DataTable getFindThanhVien(string key)
        {
            return dalNhanVien.getFindThanhVien(key);
        }

        public bool themNhanVien(NhanVienDTO tv)
        {
            return dalNhanVien.themNhanVien(tv);
        }

        public bool suaNhanVien(NhanVienDTO tv)
        {
            return dalNhanVien.suaNhanVien(tv);
        }
        public bool capNhapChucVu(string manv,string chucvu)
        {
            return dalNhanVien.capNhapChucVu(manv,chucvu);
        }
        public bool xoaNhanVien(string maNV)
        {
            return dalNhanVien.xoaNhanVien(maNV);
        }

        public int ThemDS()
        {
            return dalNhanVien.ThemDS();
        }

        public DataTable getDSTenNV()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Mã NV", typeof(string));
            dataTable.Columns.Add("Tên NV", typeof(string));

            SqlDataReader reader = dalNhanVien.getDSTenNV();

            while (reader.Read())
            {
                DataRow row = dataTable.NewRow();
                row["Mã NV"] = reader.GetString(0);
                row["Tên NV"] = reader.GetString(1);

                dataTable.Rows.Add(row);
            }

            reader.Close();
            return dataTable;
        }
        // Đăng Nhập
        public NhanVienDTO getNhanVien(string maNV) 
        {
            return dalNhanVien.getNhanVien(maNV);
        }

    }
}
