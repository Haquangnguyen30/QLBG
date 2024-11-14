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
        public DataTable getDSNCC(String searchString, bool radioTenNCC, bool radioSDT, bool radioDiaChi)
        {
            try
            {
                String sSql = "SELECT n.maNCC, n.tenNCC, n.sdt, n.diaChi FROM ncc n WHERE n.tinhTrang LIKE 1";

                if (searchString.Length > 0)
                {
                    sSql += searchSql(searchString, radioTenNCC, radioSDT, radioDiaChi);
                }

                SqlDataReader reader = DatabaseConnect.queryData(sSql);


                DataTable dataTable = new DataTable();

                dataTable.Columns.Add("Mã NCC", typeof(int));
                dataTable.Columns.Add("Tên NCC", typeof(string));
                dataTable.Columns.Add("SDT", typeof(string));
                dataTable.Columns.Add("Địa chỉ", typeof(string));

                while (reader.Read())
                {
                    DataRow row = dataTable.NewRow();
                    row["Mã NCC"] = reader.GetInt32(0);
                    row["Tên NCC"] = reader.GetString(1);
                    row["SDT"] = reader.GetString(2);
                    row["Địa chỉ"] = reader.GetString(3);

                    dataTable.Rows.Add(row);
                }

                reader.Close();
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy danh sách nhà cung cấp: " + ex.ToString());
                return null;
            }
        }

        public DataTable getDSTenNCC()
        {
            try
            {
                String sSql = "SELECT n.maNCC, n.tenNCC FROM ncc n WHERE n.tinhTrang = 1";
                SqlDataReader reader = DatabaseConnect.queryData(sSql);

                DataTable dataTable = new DataTable();

                dataTable.Columns.Add("Mã NCC", typeof(int));
                dataTable.Columns.Add("Tên NCC", typeof(string));

                while (reader.Read())
                {
                    DataRow row = dataTable.NewRow();
                    row["Mã NCC"] = reader.GetInt32(0);
                    row["Tên NCC"] = reader.GetString(1);

                    dataTable.Rows.Add(row);
                }

                reader.Close();
                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi lấy danh sách tên nhà cung cấp: " + ex.ToString());
                return null;
            }
        }

        public int themNCC(NhaCungCapDTO ncc)
        {
            try
            {
                String updateString = "INSERT INTO ncc (maNCC, tenNCC, sdt, diaChi, tinhTrang) " +
                                        "VALUES (@maNCC, @tenNCC, @sdt, @diaChi, @tinhTrang)";

                List<SqlParameter> parameters = new List<SqlParameter>();

                foreach (var prop in ncc.GetType().GetProperties())
                {
                    string paramName = "@" + prop.Name;
                    object paramValue = prop.GetValue(ncc) ?? DBNull.Value;

                    parameters.Add(new SqlParameter(paramName, paramValue));
                }

                return DatabaseConnect.updateData(updateString, parameters);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi thêm nhà cung cấp: " + ex.ToString());
                return 0;
            }
        }

        public int suaNCC(NhaCungCapDTO ncc)
        {
            try
            {
                String updateString = "UPDATE ncc SET " +
                                        "tenNCC = @tenNCC, " +
                                        "sdt = @sdt, " +
                                        "diaChi = @diaChi " +
                                        "WHERE maNCC = @maNCC";

                List<SqlParameter> parameters = new List<SqlParameter>();

                foreach(var prop in ncc.GetType().GetProperties())
                {
                    string paramName = "@" + prop.Name;
                    object paramValue = prop.GetValue(ncc) ?? DBNull.Value;

                    parameters.Add(new SqlParameter(paramName, paramValue));
                }

                return DatabaseConnect.updateData(updateString, parameters);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Lỗi sửa nhà cung cấp: " + ex.ToString());
                return 0;
            }
        }

        public int xoaNCC(int maNCC)
        {
            try
            {
                String updateString = "UPDATE ncc SET tinhTrang = 0 WHERE maNCC = @maNCC";
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter("@maNCC", maNCC));

                return DatabaseConnect.updateData(updateString, parameters);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Lỗi xóa nhà cung cấp: " + ex.ToString());
                return 0;
            }
        }

        public int countRowsNCC()
        {
            try
            {
                String queryString = "SELECT COUNT(*) FROM ncc";

                return DatabaseConnect.queryScalar(queryString, new List<SqlParameter>());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi đếm số dòng: " + ex.Message);
                return -1;
            }
        }

        public int getMaxIDNCC()
        {
            try
            {
                String queryString = "SELECT MAX(maNCC) FROM ncc";

                return DatabaseConnect.queryScalar(queryString, new List<SqlParameter>());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy ID lớn nhất: " + ex.Message);
                return -1;
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
