using Org.BouncyCastle.Crypto.Utilities;
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
    public class PhanQuyenDAL : DatabaseConnect
    {
        SqlConnection _conn = DatabaseConnect._conn;

        public DataTable getDSQuyen()
        {
            try
            {
                if (_conn.State != ConnectionState.Open) _conn.Open();

                String sql = "SELECT * FROM phanQuyen";

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Mã quyền", typeof(int));
                dataTable.Columns.Add("Tên quyền", typeof(string));
                dataTable.Columns.Add("QL tài khoản", typeof(bool));
                dataTable.Columns.Add("QL bán hàng", typeof(bool));
                dataTable.Columns.Add("QL sản phẩm", typeof(bool));
                dataTable.Columns.Add("QL nhân viên", typeof(bool));
                dataTable.Columns.Add("QL khách hàng", typeof(bool));
                dataTable.Columns.Add("QL khuyến mãi", typeof(bool));
                dataTable.Columns.Add("QL nhập hàng", typeof(bool));
                dataTable.Columns.Add("Xem thống kê", typeof(bool));

                using (SqlCommand sqlCommand = new SqlCommand(sql, _conn))
                {
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DataRow row = dataTable.NewRow();
                            row["Mã quyền"] = reader.GetInt32(0);
                            row["Tên quyền"] = reader.GetString(1);
                            row["QL tài khoản"] = reader.GetBoolean(2);
                            row["QL bán hàng"] = reader.GetBoolean(3);
                            row["QL sản phẩm"] = reader.GetBoolean(4);
                            row["QL nhân viên"] = reader.GetBoolean(5);
                            row["QL khách hàng"] = reader.GetBoolean(6);
                            row["QL khuyến mãi"] = reader.GetBoolean(7);
                            row["QL nhập hàng"] = reader.GetBoolean(8);
                            row["Xem thống kê"] = reader.GetBoolean(9);

                            dataTable.Rows.Add(row);
                        }
                    }
                }
                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi lấy danh sách phân quyền: " + ex.Message);
                return null;
            }
            finally
            {
                if (_conn.State == ConnectionState.Open) _conn.Close();
            }
        }

        public int suaQuyen(int maQuyen, String columnName, bool check)
        {
            try
            {
                if (_conn.State != ConnectionState.Open) _conn.Open();

                string column = checkColumnName(columnName);
                if (string.IsNullOrEmpty(column))
                {
                    Console.WriteLine("Tên cột không hợp lệ.");
                    return -1;
                }

                int value = check ? 1 : 0;

                string sql = $"UPDATE phanQuyen SET {column} = '{value}' WHERE maQuyen = {maQuyen}";
                
                using (SqlCommand sqlCommand = new SqlCommand(sql, _conn))
                {
                    MessageBox.Show(sql);
                    return sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi sửa quyền: " + ex.Message);
                return -1;
            }
            finally
            {
                if (_conn.State == ConnectionState.Open) _conn.Close();
            }
        }

        public string checkColumnName(string columnName)
        {
            switch (columnName)
            {
                case "QL tài khoản":
                    return "qLyTK";
                case "QL bán hàng":
                    return "qLyBH";
                case "QL sản phẩm":
                    return "qLySP";
                case "QL nhân viên":
                    return "qLyNV";
                case "QL khách hàng":
                    return "qLyKH";
                case "QL khuyến mãi":
                    return "qLyKM";
                case "QL nhập hàng":
                    return "qLyNH";
                case "Xem thống kê":
                    return "xemThongKe";
                default:
                    return null;
            }
        }

    }
    }
