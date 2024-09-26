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
using System.Windows.Forms.DataVisualization.Charting;


namespace DAL
{

    public class DatabaseConnect
    {
        //ông nào muốn chạy thì mở phần comment của mình, không xóa các comment connect chung
        //protected SqlConnection _conn = new SqlConnection("Data Source=DESKTOP-GH32RKT\\SQLEXPRESS;Initial Catalog=DoAnCSharp;Integrated Security=True");
        protected SqlConnection _conn = new SqlConnection("Data Source=WINDOWS-10\\SQLEXPRESS;Initial Catalog=DoAnCSharp;Integrated Security=True");

    }
}
