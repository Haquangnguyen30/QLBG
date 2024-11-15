using DocumentFormat.OpenXml.Spreadsheet;
using MathNet.Numerics;
using NPOI.POIFS.Crypt.Dsig;
using NPOI.SS.Formula.Functions;
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

    public class DatabaseConnect
    {
        //ông nào muốn chạy thì mở phần comment của mình, không xóa các comment connect chung
        //protected SqlConnection _conn = new SqlConnection("Data Source=DESKTOP-GH32RKT\\SQLEXPRESS;Initial Catalog=DoAnCSharp;Integrated Security=True");
        //protected SqlConnection _conn = new SqlConnection("Data Source=WINDOWS-10\\SQLEXPRESS;Initial Catalog=DoAnCSharp;Integrated Security=True");
        protected static SqlConnection _conn = new SqlConnection("Data Source=localhost;Initial Catalog=QLBG;User ID=sa;Password=Password1@");
    
        public static SqlDataReader queryData(String sql)
        {
            try
            {
                if(_conn.State != ConnectionState.Open)
                {
                    _conn.Open();
                }

                SqlCommand mySqlCommamd = new SqlCommand(sql, _conn);

                SqlDataReader reader = mySqlCommamd.ExecuteReader();
        
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static int updateData(String sql, List<SqlParameter> parameters)
        {
            try
            {
                if(_conn.State != ConnectionState.Open)
                {
                    _conn.Open();
                }
                SqlCommand mySqlCommamd = new SqlCommand(sql, _conn);

                if(parameters != null)
                {
                    foreach(SqlParameter param in parameters)
                    {
                        mySqlCommamd.Parameters.Add(param);
                    }
                }

                return mySqlCommamd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
            finally
            {
                if(_conn.State == ConnectionState.Open)
                {
                    _conn.Close();
                }
            }
        }

        public static int queryScalar(String sql, List<SqlParameter> parameters)
        {
            try
            {
                if (_conn.State != ConnectionState.Open)
                {
                    _conn.Open();
                }
                SqlCommand mySqlCommamd = new SqlCommand(sql, _conn);

                if (parameters != null)
                {
                    foreach (SqlParameter param in parameters)
                    {
                        mySqlCommamd.Parameters.Add(param);
                    }
                }

                return (int) mySqlCommamd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
            finally
            {
                if (_conn.State == ConnectionState.Open)
                {
                    _conn.Close();
                }
            }
        }

    }
}
