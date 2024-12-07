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
    public class SanPham_KichCoDAL: DatabaseConnect
    {
        public DataTable getChiTietSoLuong(string maSP)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT k.KichCo, sk.soLuong " +
                                                   "FROM sanPham_KichCo sk JOIN kichCo k ON sk.maKichCo = k.maKichCo " +
                                                   $"WHERE sk.maSP = '{maSP}';", _conn);
            da.Fill(dt);
            return dt;
        }

        public int checkTonKhoSP(string maSP, int maKC)
        {
            try
            {
                if (_conn.State != ConnectionState.Open) _conn.Open();

                String sql = @"SELECT soLuong FROM sanPham_KichCo WHERE maSP = @maSP AND maKichCo = @maKC";

                using (SqlCommand cmd = new SqlCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@maSP", maSP);
                    cmd.Parameters.AddWithValue("@maKC", maKC);
                    object result = cmd.ExecuteScalar();
                    return result != null && result != DBNull.Value ? Convert.ToInt32(result) : 0;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi lấy số lượng tồn kho của kích cỡ: " + ex.Message);
                return 0;
            }
            finally
            {
                _conn.Close();
            }
        }


    }
}
