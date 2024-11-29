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
        public List<SanPhamDTO> GetDSSP()
        {
            List<SanPhamDTO> productList = new List<SanPhamDTO>();
            try
            {
                _conn.Open();
                string SQL = "SELECT * FROM sanPham where tinhTrang = 'True'";
                SqlCommand command = new SqlCommand(SQL, _conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    SanPhamDTO SPdto = new SanPhamDTO();

                    SPdto.maSP = reader["maSP"].ToString();
                    SPdto.tenSP = reader["tenSP"].ToString();
                    SPdto.giaBan = (float)reader.GetDouble(reader.GetOrdinal("giaBan"));
                    //SPdto.soLuong = reader.GetInt32(reader.GetOrdinal("soLuong"));               
                    SPdto.giaNhap = Convert.ToSingle(reader["giaBan"]);
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
        public List<SanPhamDTO> TimKiemSanPham(string keyword)
        {
            List<SanPhamDTO> dsSanPham = new List<SanPhamDTO>();
            try
            {
                _conn.Open();
                string SQL = "SELECT maSP, tenSP, giaBan, soLuong, mau FROM sanPham WHERE tenSP LIKE @Keyword";
                SqlCommand command = new SqlCommand(SQL, _conn);
                command.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    SanPhamDTO sp = new SanPhamDTO
                    {
                        maSP = reader["maSP"].ToString(),
                        tenSP = reader["tenSP"].ToString(),
                        giaBan = (float)Convert.ToDecimal(reader["giaBan"]),
                        soLuong = Convert.ToInt32(reader["soLuong"]),
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


    }
}
