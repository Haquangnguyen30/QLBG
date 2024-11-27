using DocumentFormat.OpenXml.Bibliography;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoaiSanPhamDAL:DatabaseConnect
    {
        public DataTable getDSLoaiSanPham()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM loaiSP WHERE tinhTrang = 1",_conn);
            da.Fill(dt);
            return dt;
        }
        public DataTable getMaLSP()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT maLoai FROM loaiSP", _conn);
            da.Fill(dt);
            return dt;
        }
        public bool addLoaiSanPham(LoaiSanPhamDTO loai)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO loaiSP(maLoai, tenLoai, tinhTrang) " +
                                    "VALUES(@maLoai, @tenLoai, @tinhTrang)", _conn);
                cmd.Parameters.AddWithValue("@maLoai", loai.maLoai);
                cmd.Parameters.AddWithValue("@tenLoai", loai.tenLoai);
                cmd.Parameters.AddWithValue("@tinhTrang", loai.tinhTrang);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }

            finally
            {
                _conn.Close();
            }
            return false;
        }
        public bool updateLoaiSanPham(LoaiSanPhamDTO loai)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE loaiSP " +
                                                "SET tenLoai =  @tenLoai " +
                                                "WHERE maLoai = @maLoai ;", _conn);
                cmd.Parameters.AddWithValue("@tenLoai", loai.tenLoai);
                cmd.Parameters.AddWithValue("@maLoai", loai.maLoai);
                if(cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }  
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
            finally 
            {
                _conn.Close();
            }
            return false;
        }
        public bool deleteLoaiSanPham(LoaiSanPhamDTO loai)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE loaiSP " +
                                                "SET tinhTrang =  @tinhTrang " +
                                                "WHERE maLoai = @maLoai ;", _conn);
                cmd.Parameters.AddWithValue("@tinhTrang", loai.tinhTrang);
                cmd.Parameters.AddWithValue("@maLoai", loai.maLoai);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
    }
}
