using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Drawing.Spreadsheet;
using System.Windows.Forms;

namespace DAL
{
    public class NhaCungCapDAL:DatabaseConnect
    {
        SqlConnection _conn = DatabaseConnect._conn;
        public DataTable getDSNCC(String searchString, bool radioTenNCC, bool radioSDT, bool radioDiaChi)
        {
            try
            {
                if(_conn.State != ConnectionState.Open) _conn.Open();

                String sql = "SELECT n.maNCC, n.tenNCC, n.sdt, n.diaChi FROM ncc n WHERE n.tinhTrang LIKE 1";

                if (searchString.Length > 0)
                {
                    sql += searchSql(searchString, radioTenNCC, radioSDT, radioDiaChi);
                }

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Mã NCC", typeof(int));
                dataTable.Columns.Add("Tên NCC", typeof(string));
                dataTable.Columns.Add("SDT", typeof(string));
                dataTable.Columns.Add("Địa chỉ", typeof(string));

                using (SqlCommand sqlCommand = new SqlCommand(sql, _conn))
                {
                    using(SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            DataRow row = dataTable.NewRow();
                            row["Mã NCC"] = reader.GetInt32(0);
                            row["Tên NCC"] = reader.GetString(1);
                            row["SDT"] = reader.GetString(2);
                            row["Địa chỉ"] = reader.GetString(3);

                            dataTable.Rows.Add(row);
                        }
                    }
                }

                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy danh sách nhà cung cấp: " + ex.Message);
                return null;
            }
            finally
            {
                if(_conn.State == ConnectionState.Open) _conn.Close();
            }
        }

        public DataTable getDSTenNCC()
        {
            try
            {
                if(_conn.State != ConnectionState.Open) _conn.Open();

                String sql = "SELECT n.maNCC, n.tenNCC FROM ncc n WHERE n.tinhTrang = 1";

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Mã NCC", typeof(int));
                dataTable.Columns.Add("Tên NCC", typeof(string));

                using(SqlCommand sqlCommand = new SqlCommand(sql, _conn))
                {
                    using(SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DataRow row = dataTable.NewRow();
                            row["Mã NCC"] = reader.GetInt32(0);
                            row["Tên NCC"] = reader.GetString(1);

                            dataTable.Rows.Add(row);
                        }
                    }
                }

                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi lấy danh sách tên nhà cung cấp: " + ex.Message);
                return null;
            }
            finally
            {
                if(_conn.State == ConnectionState.Open) _conn.Close();
            }
        }

        public int themNCC(NhaCungCapDTO ncc)
        {
            try
            {
                if (_conn.State != ConnectionState.Open)
                    _conn.Open();

                string sql = "INSERT INTO ncc (maNCC, tenNCC, sdt, diaChi, tinhTrang) " +
                             "VALUES (@maNCC, @tenNCC, @sdt, @diaChi, @tinhTrang)";

                using (SqlCommand sqlCommand = new SqlCommand(sql, _conn))
                {
                    sqlCommand.Parameters.AddWithValue("@maNCC", ncc.maNCC);
                    sqlCommand.Parameters.AddWithValue("@tenNCC", ncc.tenNCC);
                    sqlCommand.Parameters.AddWithValue("@sdt", ncc.sdt);
                    sqlCommand.Parameters.AddWithValue("@diaChi", ncc.diaChi);
                    sqlCommand.Parameters.AddWithValue("@tinhTrang", ncc.tinhTrang);

                    return sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi thêm nhà cung cấp: " + ex.Message);
                return 0;
            }
            finally
            {
                if (_conn.State == ConnectionState.Open)
                    _conn.Close();
            }
        }


        public int suaNCC(NhaCungCapDTO ncc)
        {
            try
            {
                if(_conn.State != ConnectionState.Open) _conn.Open();

                String sql = "UPDATE ncc SET tenNCC = @tenNCC, sdt = @sdt, diaChi = @diaChi " +
                                        "WHERE maNCC = @maNCC";

                using(SqlCommand sqlCommand = new SqlCommand(sql, _conn))
                {
                    sqlCommand.Parameters.AddWithValue("@tenNCC", ncc.tenNCC);
                    sqlCommand.Parameters.AddWithValue("@sdt", ncc.sdt);
                    sqlCommand.Parameters.AddWithValue("@diaChi", ncc.diaChi);
                    sqlCommand.Parameters.AddWithValue("@maNCC", ncc.maNCC);

                    return sqlCommand.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Lỗi sửa nhà cung cấp: " + ex.Message);
                return 0;
            }
            finally
            {
                if(_conn.State == ConnectionState.Open) _conn.Close() ;
            }
        }

        public int xoaNCC(int maNCC)
        {
            try
            {
                if(_conn.State != ConnectionState.Open) _conn.Open() ;

                String sql = "UPDATE ncc SET tinhTrang = 0 WHERE maNCC = @maNCC";

                using (SqlCommand sqlCommand = new SqlCommand(sql, _conn))
                {
                    sqlCommand.Parameters.AddWithValue("@maNCC", maNCC);

                    return sqlCommand.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Lỗi xóa nhà cung cấp: " + ex.Message);
                return 0;
            }
            finally
            {
                if(_conn.State == ConnectionState.Open) _conn.Close();
            }
        }

        public int getMaxIDNCC()
        {
            try
            {
                if(_conn.State != ConnectionState.Open) _conn.Open();

                String sql = "SELECT MAX(maNCC) FROM ncc";

                using(SqlCommand sqlCommand = new SqlCommand(sql, _conn))
                {
                    return (int)sqlCommand.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy ID lớn nhất: " + ex.Message);
                return -1;
            }
            finally
            {
                if (_conn.State == ConnectionState.Open) _conn.Close();
            }
        }

        private String searchSql(String searchString, bool radioTenNCC, bool radioSDT, bool radioDiaChi)
        {
            if(!radioTenNCC && !radioSDT && !radioDiaChi)
            {
                return $"AND (n.tenNCC LIKE '%{searchString}%' " +
                        $"OR n.sdt LIKE '%{searchString}%' " +
                        $"OR n.diaChi LIKE '%{searchString}%')";
            } 
            else
            {
                String sqlBonus = "AND (";
                if (radioTenNCC)
                {
                    sqlBonus += $"n.tenNCC LIKE '%{searchString}%' ";
                } else if (!radioTenNCC)
                {
                    sqlBonus += "";
                }

                if (!radioTenNCC && radioSDT)
                {
                    sqlBonus += $"n.sdt LIKE '%{searchString}%' ";
                } else if (radioTenNCC && radioSDT) {
                    sqlBonus += $"OR n.sdt LIKE '%{searchString}%' ";
                }

                if (!radioTenNCC && !radioSDT && radioDiaChi)
                {
                    sqlBonus += $"n.diaChi LIKE '%{searchString}%'";
                } else if (radioSDT && radioDiaChi || radioTenNCC && radioDiaChi)
                {
                    sqlBonus += $"OR n.diaChi LIKE '%{searchString}%'";
                }
                sqlBonus += ")";

                return sqlBonus;
            }
            
        }

    }
}
