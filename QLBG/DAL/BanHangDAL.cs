using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace DAL
{
    public class BanHangDAL: DatabaseConnect
    {
        public List<SanPhamDTO> GetDSSP(int itemsPerPage, int startLine)
        {
            List<SanPhamDTO> productList = new List<SanPhamDTO>();
            try
            {
                _conn.Open();
                string SQL = @"SELECT * 
                                FROM sanPham 
                                WHERE tinhTrang = 'True' 
                                ORDER BY maSP DESC
                                OFFSET @startLine ROWS FETCH NEXT @itemsPerPage ROWS ONLY";
                SqlCommand command = new SqlCommand(SQL, _conn);
                command.Parameters.AddWithValue("@itemsPerPage", itemsPerPage);
                command.Parameters.AddWithValue("@startLine", startLine);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    SanPhamDTO SPdto = new SanPhamDTO();

                    SPdto.maSP = reader["maSP"].ToString();
                    SPdto.tenSP = reader["tenSP"].ToString();
                    SPdto.giaBan = (float)reader.GetDouble(reader.GetOrdinal("giaBan"));
                    //SPdto.soLuong = reader.GetInt32(reader.GetOrdinal("soLuong"));               
                    SPdto.giaNhap = Convert.ToSingle(reader["giaNhap"]);
                    SPdto.mau = reader["mau"].ToString();
                    SPdto.tinhTrang = Convert.ToBoolean(reader["tinhTrang"]);
                    SPdto.maLoai = Convert.ToInt32(reader["maLoai"]);
                    SPdto.img = reader["img"].ToString();

                    productList.Add(SPdto);
                }
                return productList;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy danh sách sản phẩm: " + ex.Message);
            }
            finally
            {
                _conn.Close();
            }
            return null;
        }
        public int GetSoLuongTheoSize(string maSP, int maKC)
        {
            int soLuong = 0; // Khởi tạo giá trị mặc định cho soLuong
            try
            {
                _conn.Open();
                string SQL = "SELECT SPKC.soLuong " +
                             "FROM dbo.sanPham_KichCo AS SPKC " +
                             "JOIN dbo.sanPham AS SP ON SP.maSP = SPKC.maSP " +
                             "JOIN dbo.kichCo KC ON KC.maKichCo = SPKC.maKichCo " +
                             "WHERE SP.maSP like @maSP AND SPKC.maKichCo = @maKC";

                SqlCommand command = new SqlCommand(SQL, _conn);
                command.Parameters.AddWithValue("@maSP", maSP);
                command.Parameters.AddWithValue("@maKC", maKC);

                // Kiểm tra giá trị trả về có phải là null không
                var result = command.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    soLuong = (int)result; // Gán kết quả nếu không phải null
                }
                return soLuong;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy số lượng: " + ex.Message);
                return 0;
            }
            finally
            {
                _conn.Close();
            }
        }
        public List<KichCoDTO> GetSizeTheoSP(string maSP)
        {
            List<KichCoDTO> sizes = new List<KichCoDTO>();

            try
            {
                _conn.Open();
                string SQL = "SELECT KC.maKichCo, KC.kichCo " +
                             "FROM dbo.sanPham_KichCo AS SPKC " +
                             "JOIN dbo.kichCo AS KC ON KC.maKichCo = SPKC.maKichCo " +
                             "WHERE SPKC.maSP like @maSP";

                SqlCommand command = new SqlCommand(SQL, _conn);
                command.Parameters.AddWithValue("@maSP", maSP);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        KichCoDTO kcDto = new KichCoDTO();
                        kcDto.maKichCo= (int)reader["maKichCo"];
                        kcDto.kichCo = reader["kichCo"].ToString();
                        kcDto.tinhTrang = true;
                        sizes.Add(kcDto);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy danh sách size: " + ex.Message);
            }
            finally
            {
                _conn.Close();
            }

            return sizes;
        }
        public List<SanPhamDTO> TimKiemSanPham(string keyword, int itemsPerPage, int startLine)
        {
            List<SanPhamDTO> dsSanPham = new List<SanPhamDTO>();
            try
            {
                _conn.Open();
                string SQL = @"SELECT maSP, tenSP, giaBan, img,  mau 
                                FROM sanPham 
                                WHERE tenSP LIKE @Keyword
                                AND tinhTrang = 'True' 
                                ORDER BY maSP DESC
                                OFFSET @startLine ROWS FETCH NEXT @itemsPerPage ROWS ONLY";
                SqlCommand command = new SqlCommand(SQL, _conn);
                command.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                command.Parameters.AddWithValue("@itemsPerPage", itemsPerPage);
                command.Parameters.AddWithValue("@startLine", startLine);

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    SanPhamDTO sp = new SanPhamDTO
                    {
                        maSP = reader["maSP"].ToString(),
                        tenSP = reader["tenSP"].ToString(),
                        giaBan = (float)Convert.ToDecimal(reader["giaBan"]),
                        //soLuong = Convert.ToInt32(reader["soLuong"]),
                        img = reader["img"].ToString(),
                        mau = reader["mau"].ToString()
                    };
                    dsSanPham.Add(sp);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi tìm kiếm sản phẩm: " + ex.Message);
            }
            finally
            {
                _conn.Close();
            }
            return dsSanPham;
        }
        public int countFilteredSP(string keyword)
        {
            try
            {
                if (_conn.State != ConnectionState.Open) _conn.Open();

                String sql = @"SELECT COUNT(*) 
                                FROM sanPham 
                                WHERE tenSP LIKE @Keyword
                                AND tinhTrang = 'True'";

                using (SqlCommand sqlCommand = new SqlCommand(sql, _conn))
                {
                    sqlCommand.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                    return (int)sqlCommand.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi đếm số lượng sản phẩm tìm được!!!" + ex.Message);
                return 0;
            }
            finally
            {
                if (_conn.State == ConnectionState.Open) _conn.Close();
            }

        }

        public int countAllSP()
        {
            try
            {
                if (_conn.State != ConnectionState.Open) _conn.Open();

                String sql = "SELECT COUNT(*) FROM sanPham WHERE tinhTrang = 1";

                using (SqlCommand sqlCommand = new SqlCommand(sql, _conn))
                {
                    return (int)sqlCommand.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi đếm số lượng sản phẩm!!!" + ex.Message);
                return 0;
            }
            finally
            {
                if (_conn.State == ConnectionState.Open) _conn.Close();
            }

        }

    }
}
