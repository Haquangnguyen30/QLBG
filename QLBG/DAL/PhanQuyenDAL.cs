using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class PhanQuyenDAL: DatabaseConnect
    {
        public PhanQuyenDTO getPhanQuyen(int maPQ)
        {
            try
            {
                _conn.Open();
                string query = $"SELECT * FROM phanQuyen WHERE  maQuyen ={maPQ}";
                PhanQuyenDTO pq = new PhanQuyenDTO();
                SqlCommand cmd = new SqlCommand(query, _conn);
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    pq.maQuyen = rd.GetInt32(0);
                    pq.tenQuyen=rd.GetString(1);
                    pq.qlyTK=rd.GetBoolean(2);
                    pq.qlyBH=rd.GetBoolean(3);
                    pq.qlySP=rd.GetBoolean(4);
                    pq.qlyNV=rd.GetBoolean(5);
                    pq.qlyKH= rd.GetBoolean(6);
                    pq.qlyKM=rd.GetBoolean(7);
                    pq.qlyNH=rd.GetBoolean(8);
                    pq.xemThongKe=rd.GetBoolean(9);
                    return pq;
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
    }
}
