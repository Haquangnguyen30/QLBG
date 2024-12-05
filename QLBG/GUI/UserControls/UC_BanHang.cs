using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using BLL;
using BUS;
using DTO;
using GUI.BanHang;
using NPOI.SS.Formula.Functions;

namespace GUI.UserControls
{
    public partial class UC_BanHang : UserControl
    {
        private HoaDonBUS HDbll = new HoaDonBUS();
        private ChiTietHoaDonBUS CTHDbll = new ChiTietHoaDonBUS();
        private BanHangBLL BHbll = new BanHangBLL();
        private KhachHangBUS khachHangBUS = new KhachHangBUS();
        private SanPhamDTO currentProduct; // Sản phẩm hiện tại để hiển thị thông tin chi tiết
        private NhanVienBUS nvBUS = new NhanVienBUS();
        private List<KhachHangDTO> danhSachKhachHang;
        private int itemsPerPage = 12;
        private int startPage = 1;
        public UC_BanHang()
        {
            InitializeComponent();
            LoadProducts(); // Gọi hàm tải danh sách sản phẩm
            ConfigureCartGridBH(); //Cấu hình giỏ hàng
            LoadHoaDonData();
            danhSachKhachHang = khachHangBUS.getList();
            CapNhatComboBox(danhSachKhachHang);
        }

        // Hàm tải danh sách sản phẩm
        // Hàm tải danh sách sản phẩm
        private void LoadProducts()
        {
            try
            {
                List<SanPhamDTO> products = BHbll.GetDSSP(itemsPerPage, startLine(startPage)); // Lấy danh sách sản phẩm từ BLL
                txtTotalPage.Text = totalPage(BHbll.countAllSP()).ToString();
                txtCurrentPage.Text = startPage.ToString();
                HienThiSanPham(products);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách sản phẩm: " + ex.Message);
            }
        }

        // Hiển thị thông tin chi tiết sản phẩm ở bên phải
        private void DisplayProductDetails(SanPhamDTO product, Image productImage)
        {
            currentProduct = product; // Lưu lại sản phẩm hiện tại
            lblProductName.Text = product.tenSP;
            string idSP = product.maSP;
            pictureBoxProduct.Image = productImage;
            // Lấy danh sách size từ cơ sở dữ liệu
            List<KichCoDTO> listSizes = BHbll.GetSizeTheoSP(idSP);
            // Tạo các button size cố định
            pnlSizes.Controls.Clear(); // Xóa các button size cũ
            pnlSizes.AutoScroll = true; // Cho phép cuộn nếu nội dung vượt kích thước panel
            pnlSizes.FlowDirection = FlowDirection.LeftToRight; // Hướng sắp xếp ngang
            pnlSizes.WrapContents = true; // Tự động xuống dòng nếu không đủ chỗ
            foreach (var size in listSizes)
            {
                Button sizeButton = new Button
                {
                    Text = size.kichCo,
                    Size = new Size(48, 40),
                    Margin = new Padding(3),
                    Font = new Font("Arial", 12, FontStyle.Regular),
                    BackColor = Color.White,
                    ForeColor = Color.Purple,
                    FlatStyle = FlatStyle.Flat
                   
                };

                // Thêm sự kiện nhấn vào từng button size
                sizeButton.Click += (sender, e) => SizeButton_Click(sender, e, idSP, size.maKichCo, size.kichCo);

                pnlSizes.Controls.Add(sizeButton); // Thêm button vào panel
            }
            lblStock.Text = "Số lượng trong kho: Chọn size để xem"; // Hiển thị hướng dẫn ban đầu
        }
        string kichco = "";
        int maKichCo = 0;
        int stock = 0;
        private void SizeButton_Click(object sender, EventArgs e, string maSP, int selectedSize,string tenkichco)
        {
            // Lấy số lượng tồn kho từ cơ sở dữ liệu
            stock = BHbll.GetSoLuongTheoSize(maSP, selectedSize);

            if (stock > 0)
            {
                lblStock.Text = $"Số lượng trong kho: {stock}";
                kichco = tenkichco;
                maKichCo = selectedSize;
            }
            else
            {
                lblStock.Text = "Không có sản phẩm cho size này";
                stock = 0;
            }
        }
        // Thêm sản phẩm hiện tại vào giỏ hàng
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (currentProduct == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm!");
            }
            // Thêm sản phẩm hiện tại vào ListView giỏ hàng
            else if (currentProduct != null && kichco == "")
            {               
                MessageBox.Show("Vui lòng chọn kích cỡ");
            }
            else if (currentProduct != null && kichco != "" && stock == 0)
            {
                MessageBox.Show("Sản phẩm đã hết hàng vui lòng chọn sản phẩm khác!");
            }
            else
            {
                if((int)txtSoLuong.Value > stock){
                    MessageBox.Show("Số lượng sản phẩm vượt mức!");
                    txtSoLuong.Value = stock;
                }
                else
                {
                    int soLuong = (int)txtSoLuong.Value;
                    float giaBan = currentProduct.giaBan;
                    string mau = currentProduct.mau;
                    int maKC = maKichCo;
                    AddToCart(currentProduct, mau, soLuong, kichco, maKC); // Mặc định số lượng là 1
                }
            }
        }

        // Thêm sản phẩm vào ListView giỏ hàng
        private void AddToCart(SanPhamDTO product, string mau,int quantity,string kichco, int makichco)
        {
            
            // Kiểm tra xem sản phẩm đã có trong giỏ hàng hay chưa
            foreach (DataGridViewRow row in GioHangDataGridView.Rows)
            {
                if (row.Cells["tenSP"].Value.ToString() == product.tenSP && row.Cells["kichCo"].Value.ToString() == kichco)
                {
                    // Cập nhật số lượng nếu sản phẩm đã tồn tại
                    int currentQuantity = int.Parse(row.Cells["soLuong"].Value.ToString());
                    currentQuantity += quantity;
                    row.Cells["soLuong"].Value = currentQuantity;
                    row.Cells["ThanhTien"].Value = product.giaBan * currentQuantity;
                    TinhTongTien();
                    return;
                }
            }
            float thanhTien = product.giaBan * quantity;
            // Thêm sản phẩm mới vào giỏ hàng
            GioHangDataGridView.Rows.Add(product.maSP,product.tenSP,product.mau, kichco, product.giaBan.ToString("N0"), quantity, thanhTien.ToString("N0"),makichco);
            TinhTongTien();
            
        }
        //Load danh sách hoá đơn
        private void ConfigureCartGridBH()
        {
            GioHangDataGridView.Columns.Clear();
            GioHangDataGridView.Columns.Add("maSP", "Mã SP");
            GioHangDataGridView.Columns.Add("tenSP", "Tên SP");
            GioHangDataGridView.Columns.Add("mau", "Màu");
            GioHangDataGridView.Columns.Add("kichCo", "Kích Cỡ");
            GioHangDataGridView.Columns.Add("giaBan", "Giá Bán");
            GioHangDataGridView.Columns["giaBan"].DefaultCellStyle.Format = "N0"; // Định dạng tiền tệ
            GioHangDataGridView.Columns.Add("soLuong", "Số Lượng");
            GioHangDataGridView.Columns.Add("thanhTien", "Thành tiền");
            GioHangDataGridView.Columns["thanhTien"].DefaultCellStyle.Format = "N0"; // Định dạng tiền tệ
            GioHangDataGridView.Columns.Add("maKichCo", "Mã Kích Cỡ");
            GioHangDataGridView.Columns["maKichCo"].Visible = false;
            // Định dạng DataGridView
            GioHangDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GioHangDataGridView.AllowUserToAddRows = false; // Không cho phép người dùng thêm hàng thủ công
            GioHangDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Chọn toàn hàng
            GioHangDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GioHangDataGridView.ReadOnly = true;
        }
        private void LoadHoaDonData()
        {
            // Lấy dữ liệu từ HoaDonDAL
            DataTable dt = HDbll.getDSHD();
            // Kiểm tra và gán dữ liệu vào DataGridView
            if (dt != null && dt.Rows.Count > 0)
            {
                // Gán dữ liệu vào DataGridView
                dgvHD.DataSource = dt;

                // Kiểm tra và ánh xạ dữ liệu đúng với các cột
                dgvHD.Columns["maHD"].DataPropertyName = "maHD";
                dgvHD.Columns["maNV"].DataPropertyName = "maNV";
                dgvHD.Columns["tenKH"].DataPropertyName = "tenKH";
                dgvHD.Columns["ngayLap"].DataPropertyName = "ngayLap";
                dgvHD.Columns["tongTien"].DataPropertyName = "tongTien";
                dgvHD.Columns["tongTien"].DefaultCellStyle.Format = "N0"; // Định dạng tiền tệ
                dgvHD.Columns["tienGiam"].DataPropertyName = "tienGiam";
                dgvHD.Columns["tienGiam"].DefaultCellStyle.Format = "N0"; // Định dạng tiền tệ
                dgvHD.Columns["tienKhachDua"].DataPropertyName = "tienKhachDua";
                dgvHD.Columns["tienKhachDua"].DefaultCellStyle.Format = "N0"; // Định dạng tiền tệ
                //dgvHD.Columns["tienThua"].DataPropertyName = "tienThua";
                //dgvHD.Columns["tienThua"].DefaultCellStyle.Format = "N0"; // Định dạng tiền tệ
                dgvHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvHD.AllowUserToAddRows = false; // Không cho phép người dùng thêm hàng thủ công
                dgvHD.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Chọn toàn hàng
            }
            else
            {
                // Nếu không có dữ liệu, có thể hiển thị thông báo hoặc làm gì đó tùy ý.
                MessageBox.Show("Không có dữ liệu.");
            }
        }
        private void GioHangDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                XoaSuaTTBHGUI formSuaXoa = new XoaSuaTTBHGUI(e.RowIndex, GioHangDataGridView, UpdateTongTien);
                formSuaXoa.Show();
            }
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            
            String tenKH = cbKhachHang.Text;
            int maKH = (int)cbKhachHang.SelectedValue;
            float tongTien = TinhTongTien();
            HoaDonBanHangGUI formHoaDon = new HoaDonBanHangGUI(maKH,tenKH, GioHangDataGridView, tongTien);
            DialogResult result = formHoaDon.ShowDialog();

            if (result == DialogResult.OK)
            {
                GioHangDataGridView.Rows.Clear();
                clearInfo();
            }

        }
        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự không hợp lệ
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            showSPByCurrentPage(1);
        }
        private void showSPByCurrentPage(int currentPage)
        {
            string searchText = txtSearch.Text.Trim();
            List<SanPhamDTO> filteredProducts;

            if (string.IsNullOrWhiteSpace(searchText))
            {
                filteredProducts = BHbll.GetDSSP(itemsPerPage, startLine(currentPage)); // Lấy tất cả sản phẩm
                txtTotalPage.Text = totalPage(BHbll.countAllSP()).ToString();
            }
            else
            {
                filteredProducts = BHbll.TimKiemSanPham(searchText, itemsPerPage, startLine(currentPage)); // Tìm kiếm sản phẩm
                txtTotalPage.Text = totalPage(BHbll.countFilteredSP(searchText)).ToString();
            }


            txtCurrentPage.Text = startPage.ToString();
            // Hiển thị danh sách sản phẩm trong TableLayoutPanel
            HienThiSanPham(filteredProducts);
        }
        private int totalPage(int items)
        {
            return (int)Math.Ceiling((double)items / itemsPerPage);
        }
        private int startLine(int curPage)
        {
            return (curPage - 1) * 12 + 1;
        }
        private void HienThiSanPham(List<SanPhamDTO> products) // Hàm hiển thị sản phẩm sau khi nhập tên sản phẩm
        {
            try
            {   
                if (products != null && products.Count > 0)
                {
                    txtKhCoSP.Visible = false;
                    pictureBoxKhCoSP.Visible = false;
                    tabledulieusp.Visible = true;

                    int row = 0, col = 0;
                    tabledulieusp.Controls.Clear();
                    tabledulieusp.RowCount = 0;

                    // Lấy đường dẫn thư mục ảnh trong dự án
                    string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
                    string imageDirectory = Path.Combine(projectDirectory, @"..\..\..\GUI\Resources\ImgSanPham");

                    // Kiểm tra xem thư mục có tồn tại không
                    if (!Directory.Exists(imageDirectory))
                    {
                        Console.WriteLine($"Thư mục ảnh không tồn tại: {imageDirectory}");
                        return;
                    }

                    foreach (var product in products)
                    {
                        // Tạo đường dẫn ảnh cho sản phẩm
                        string imagePath = Path.Combine(imageDirectory, product.img);
                        Console.WriteLine($"Đường dẫn ảnh: {imagePath}"); // In ra đường dẫn ảnh để kiểm tra

                        Image productImage = Properties.Resources.DefaultImage; // Ảnh mặc định nếu không tìm thấy ảnh sản phẩm

                        // Kiểm tra và tải ảnh từ thư mục
                        try
                        {
                            if (File.Exists(imagePath))
                            {
                                // Đọc ảnh từ file
                                productImage = new Bitmap(imagePath);
                            }
                            else
                            {
                                Console.WriteLine($"File ảnh không tồn tại: {imagePath}");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Lỗi khi tải ảnh: {ex.Message}");
                            productImage = Properties.Resources.DefaultImage; // Gán ảnh mặc định nếu có lỗi
                        }

                        // Tạo instance của UC_ComponentSP
                        var productControl = new UC_ComponentSP
                        {
                            ProductName = product.tenSP,
                            ProductPrice = product.giaBan.ToString("N0") + " VNĐ",
                            ProductColor = "Màu: " + product.mau,
                            ProductImage = productImage // Gán ảnh đã chọn hoặc ảnh mặc định
                        };

                        // Gắn sự kiện hiển thị thông tin chi tiết
                        productControl.OnViewDetailsClicked += (sender, e) =>
                        {
                            DisplayProductDetails(product, productImage); // Truyền ảnh vào DisplayProductDetails
                        };

                        // Thêm sản phẩm vào TableLayoutPanel
                        tabledulieusp.Controls.Add(productControl, col, row);
                        col++;
                        if (col >= tabledulieusp.ColumnCount)
                        {
                            col = 0;
                            row++;
                            tabledulieusp.RowCount++;
                        }
                    }
                }
                else
                {
                    txtKhCoSP.Visible = true;
                    pictureBoxKhCoSP.Visible = true;
                    tabledulieusp.Visible = false;
                    //txtSearch.Text = "";
                    //showSPByCurrentPage(1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hiển thị sản phẩm: " + ex.Message);
            }
        }
        private void CapNhatComboBox(List<KhachHangDTO> danhSach)
        {
            cbKhachHang.DataSource = null;
            cbKhachHang.DataSource = danhSach;
            cbKhachHang.DisplayMember = "tenKH"; // Hiển thị tên khách hàng
            cbKhachHang.ValueMember = "maKH";   // Lấy mã khách hàng
            cbKhachHang.DropDownStyle = ComboBoxStyle.DropDown;
            cbKhachHang.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbKhachHang.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        private void cbKhachHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Kiểm tra nếu nhấn phím Enter
            {
                string searchText = cbKhachHang.Text.Trim(); // Lấy nội dung trong ComboBox

                if (!string.IsNullOrWhiteSpace(searchText))
                {
                    // Tìm kiếm danh sách khách hàng theo từ khóa
                    var filteredList = khachHangBUS.TimKiemKhachHangTheoKey(searchText);
                    CapNhatComboBox(filteredList);

                    if (filteredList.Count > 0)
                    {
                        cbKhachHang.DroppedDown = true; // Mở danh sách nếu có kết quả
                    }
                    else
                    {
                        cbKhachHang.DroppedDown = false; // Đóng danh sách nếu không có kết quả
                        MessageBox.Show("Không tìm thấy khách hàng nào!", "Thông báo");
                    }
                }
                else
                {
                    // Nếu không nhập gì, hiển thị danh sách đầy đủ
                    CapNhatComboBox(danhSachKhachHang);
                }

                e.Handled = true; // Ngăn chặn sự kiện mặc định
            }
        }
        private void cbKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Đảm bảo rằng ComboBox đã được gán DataSource và không có lỗi khi chọn
            if (cbKhachHang.SelectedValue != null && cbKhachHang.SelectedValue is int)
            {
                int maKH = (int)cbKhachHang.SelectedValue;
                Console.WriteLine("Mã khách hàng được chọn: " + maKH);
                // Thực hiện các xử lý khác với mã khách hàng
            }
            else
            {
                Console.WriteLine("Không có khách hàng nào được chọn.");
            }
        }
        private float TinhTongTien()
        {
            float tongTien = 0;

            // Duyệt qua các dòng trong DataGridView để tính tổng tiền
            foreach (DataGridViewRow row in GioHangDataGridView.Rows)
            {
                if (row.Cells["thanhTien"].Value != null)
                {
                    tongTien += float.Parse(row.Cells["thanhTien"].Value.ToString());
                }
            }

            // Cập nhật Label hiển thị tổng tiền
            lblTongTien.Text = $"Tổng tiền: {tongTien.ToString("N0")} VNĐ";
            lblTongTien.ForeColor = Color.Black;
            lblTongTien.BackColor = Color.Transparent;
            return tongTien;
        }
        private void UpdateTongTien()
        {
            TinhTongTien();
        }
        private void clearInfo()
        {
            txtSearch.Text = "";
            lblProductName.Text = "Tên sản phẩm";
            kichco = "";
        }
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (guna2TabControl1.SelectedTab.Name == "pageHD")
            {
                LoadHoaDonData(); // Tải lại dữ liệu nếu cần
            }
        }
        private void searchHD_TextChanged(object sender, EventArgs e)
        {
            if (searchHD.Text.Equals(""))
            {
                LoadHoaDonData();
            }
            else
            {
                DataTable result = HDbll.TimKiemHoaDon(searchHD.Text);
                dgvHD.DataSource = result;
            }
        }
        private void dgvHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int mahd = int.Parse(dgvHD.SelectedRows[0].Cells["maHD"].Value.ToString());
            dgvCTHD.DataSource = CTHDbll.GetChiTietHoaDon(mahd);
        }
        private void dgvHD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String fileName = dgvHD.SelectedRows[0].Cells["maHD"].Value.ToString();
            openPdf(fileName);
        }

        private void openPdf(String fileName)
        {
            // Lấy đường dẫn gốc của ứng dụng khi chạy
            string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Tạo đường dẫn tới thư mục Resources (đường dẫn tương đối từ project)
            string resourcePath = Path.Combine(projectDirectory, @"..\..\..\GUI\Resources\Import_HDInvoice");

            String pdfPath = Path.Combine(resourcePath, fileName + ".pdf");
            if (File.Exists(pdfPath))
            {
                try
                {
                    // Mở file PDF bằng ứng dụng mặc định
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                    {
                        FileName = pdfPath,
                        UseShellExecute = true // Dùng ứng dụng mặc định của hệ thống để mở
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error opening PDF: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("PDF file not found at: " + pdfPath);
            }
        }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void uC_ComponentSP1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tenSp_Click(object sender, EventArgs e)
        {

        }

        private void uC_ComponentSP3_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            ThemKhachHangGUI formKhachHang = new ThemKhachHangGUI(cbKhachHang);
            DialogResult result = formKhachHang.ShowDialog();
        }

        private void reloadbtn_Click(object sender, EventArgs e)
        {
            LoadProducts();
            txtSearch.Text = "";

        }

        private void txtCurrentPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự không hợp lệ
            }
        }

        private void txtCurrentPage_Leave(object sender, EventArgs e)
        {
            int maxPage = int.Parse(txtTotalPage.Text);
            if (string.IsNullOrWhiteSpace(txtCurrentPage.Text))
            {
                MessageBox.Show("Không thể để trống!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                showSPByCurrentPage(1);
                txtCurrentPage.SelectionStart = txtCurrentPage.Text.Length; // Đặt lại con trỏ
                return;
            }
            else if (int.Parse(txtCurrentPage.Text) < 1 || int.Parse(txtCurrentPage.Text) > maxPage)
            {
                MessageBox.Show("Trang bạn chọn không hợp lệ!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                showSPByCurrentPage(1);
                txtCurrentPage.SelectionStart = txtCurrentPage.Text.Length; // Đặt lại con trỏ
                return;
            }
            else
            {
                showSPByCurrentPage(int.Parse(txtCurrentPage.Text));
                txtCurrentPage.Text = int.Parse(txtCurrentPage.Text).ToString();
            }
        }

        private void btnBackPage_Click(object sender, EventArgs e)
        {
            int backPage = int.Parse(txtCurrentPage.Text) - 1;
            if (backPage == 0)
            {
                MessageBox.Show("Không thể xem trang nhỏ hơn!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                showSPByCurrentPage(backPage);
                txtCurrentPage.Text = backPage.ToString();

            }
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            int nextPage = int.Parse(txtCurrentPage.Text) + 1;
            int maxPage = int.Parse(txtTotalPage.Text);
            if (nextPage > maxPage)
            {
                MessageBox.Show("Không thể xem trang lớn hơn!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                showSPByCurrentPage(nextPage);
                txtCurrentPage.Text = nextPage.ToString();
            }
        }
    }
}


