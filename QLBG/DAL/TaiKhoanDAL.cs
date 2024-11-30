using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class TaiKhoanDAL: DatabaseConnect
    {
        public TaiKhoanDTO getTaiKhoan(string tenDangNhap, string matKhau)
        {
            try
            {
                _conn.Open();
                string query = "SELECT * FROM taiKhoan WHERE tenDangNhap= '" + tenDangNhap + "' AND matKhau= '" + matKhau+"' AND tinhTrang= 1";
                TaiKhoanDTO tk = new TaiKhoanDTO();
                SqlCommand cmd = new SqlCommand(query, _conn);
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read()) 
                {
                    tk.maNV = rd.GetString(0);
                    tk.maQuyen = rd.GetInt32(1);
                    tk.tenDangNhap = rd.GetString(2);
                    tk.matKhau = rd.GetString(3);
                    tk.tinhTrang = true;
                    return tk;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                _conn.Close();
            }
        }
        public bool updateMatKhau(string maNV, string matKhau)
        {
            try
            {
                _conn.Open();
                string query = $"UPDATE taiKhoan SET matKhau = '{matKhau}' WHERE maNV = '{maNV}' ";
                SqlCommand cmd = new SqlCommand(query , _conn);
                if (cmd.ExecuteNonQuery() > 0) 
                { 
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                _conn.Close();
            }
        }
    }
}
