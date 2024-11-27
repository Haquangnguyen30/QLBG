using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UserControls
{
    public partial class UC_KhuyenMai : UserControl
    {
        ChiTietKhuyenMaiBUS ctkmBus = new ChiTietKhuyenMaiBUS();
        KhuyenMaiBUS kmBus = new KhuyenMaiBUS();
        ChiTietKhuyenMaiDTO ctkmDto;
        KhuyenMaiDTO kmDto;
        private bool isTextBox5Changing = false;
        private bool isTextBox6Changing = false;
        public UC_KhuyenMai()
        {
            InitializeComponent();
        }

        private void UC_KhuyenMai_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = this.kmBus.getKhuyenMai();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            textBox1.Text = capNhatMa().ToString();
            textBox3.Text = dateTimePicker2.Value.ToString("dd/MM/yyyy");
            textBox4.Text = dateTimePicker1.Value.ToString("dd/MM/yyyy");
        }


        
        public int capNhatMa()
        {
            int maKM = 0;
            foreach (KhuyenMaiDTO nv in kmBus.getList())
            {
                if (nv.maKM > maKM)
                {
                    maKM = nv.maKM;
                }
            }
            maKM += 1;

            return maKM;
        }

        private void btnLichSuNH_Click(object sender, EventArgs e)
        {
            
        }
        private bool ValidateTenKhuyenMai(string promoName)
        {
            // Kiểm tra nếu tên khuyến mãi không được rỗng
            if (string.IsNullOrWhiteSpace(promoName))
            {
                MessageBox.Show("Tên khuyến mãi không được để trống.");
                return false;
            }

            // Nếu tên khuyến mãi hợp lệ
            return true;
        }
        private bool ValidateDates(DateTime startDate, DateTime endDate)
        {
            // Kiểm tra nếu ngày bắt đầu và ngày kết thúc không được bỏ trống
            if (startDate == DateTime.MinValue || endDate == DateTime.MinValue)
            {
                MessageBox.Show("Ngày bắt đầu và ngày kết thúc không được để trống.");
                return false;
            }

            // Kiểm tra nếu ngày bắt đầu và ngày kết thúc không trùng nhau
            if (startDate == endDate)
            {
                MessageBox.Show("Ngày bắt đầu và ngày kết thúc không được trùng nhau.");
                return false;
            }

            // Kiểm tra nếu ngày bắt đầu nhỏ hơn ngày kết thúc
            if (startDate >= endDate)
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc.");
                return false;
            }
            if (startDate < DateTime.Now ||  endDate < DateTime.Now)
            {
                MessageBox.Show("Ngày bắt đầu và ngày kết thúc phải lớn hơn hiện tại.");
                return false;
            }

            // Nếu tất cả điều kiện đều thỏa mãn
            return true;
        }

        private bool ValidateDiscountUnit(string discountUnit)
        {
            if (string.IsNullOrWhiteSpace(discountUnit))
            {
                MessageBox.Show("Đơn vị giảm không được để trống.");
                return false;
            }

            if (!int.TryParse(discountUnit, out int discountValue))
            {
                MessageBox.Show("Đơn vị giảm không hợp lệ. Xin vui lòng nhập một số nguyên.");
                return false;
            }

            if (discountValue < 0 || discountValue > 100)
            {
                MessageBox.Show("Đơn vị giảm phải nằm trong khoảng từ 0 đến 100.");
                return false;
            }

            return true; // Đơn vị giảm hợp lệ
        }

        private bool ValidateDiscountValue(string discountValueStr)
        {
            if (decimal.TryParse(discountValueStr, out decimal discountValue))
            {
                if (discountValue < 0)
                {
                    MessageBox.Show("Giá trị giảm phải lớn hơn hoặc bằng 0.");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Giá trị giảm không hợp lệ. Xin vui lòng nhập một số.");
                return false;
            }

            return true; // Giá trị giảm hợp lệ
        }




        private void btnLichSuNH_Click_1(object sender, EventArgs e)
        {
            kmDto = new KhuyenMaiDTO();
            string tenKM = textBox2.Text;
            string ngayBD = textBox3.Text;
            string ngayKT = textBox4.Text;
            string giaTriGiam=textBox6.Text;
            DateTime startDate, endDate;
            string dateFormat = "dd/MM/yyyy";
            DateTime.TryParseExact(ngayBD, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out startDate);
            DateTime.TryParseExact(ngayKT, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out endDate);
            if (ValidateTenKhuyenMai(tenKM) && ValidateDiscountValue(giaTriGiam)&& ValidateDates(startDate, endDate))
            {
                kmDto.maKM = capNhatMa();
                kmDto.tenKM = tenKM;
                kmDto.giaTriGiam = int.Parse(giaTriGiam);
                kmDto.ngayBatDau = startDate;
                kmDto.ngayKetThuc = endDate;
                kmDto.tinhTrang=true;

                if (kmBus.themKhuyenMai(kmDto))
                {
                    // Thêm thành công, hiển thị thông báo
                    MessageBox.Show("Thêm thành công!");
                    dataGridView1.DataSource = this.kmBus.getKhuyenMai();
                    textBox1.Text = string.Empty;
                    textBox2.Text = string.Empty;
                    textBox3.Text = string.Empty;
                    textBox4.Text = string.Empty;
                    textBox6.Text = string.Empty;
                }

            }
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            kmDto = new KhuyenMaiDTO();
            string maKMStr = textBox1.Text;
            string tenKM = textBox2.Text;
            string ngayBD = textBox3.Text;
            string ngayKT = textBox4.Text;
            string giaTriGiam = textBox6.Text;
            DateTime startDate, endDate;
            string dateFormat = "dd/MM/yyyy";
            DateTime.TryParseExact(ngayBD, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out startDate);
            DateTime.TryParseExact(ngayKT, dateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out endDate);
            if (ValidateTenKhuyenMai(tenKM) && ValidateDiscountValue(giaTriGiam) && ValidateDates(startDate, endDate))
            {
                int maKM;

                if (int.TryParse(maKMStr, out maKM))
                    kmDto.maKM = maKM;
                kmDto.tenKM = tenKM;
                kmDto.giaTriGiam = int.Parse(giaTriGiam);
                kmDto.ngayBatDau = startDate;
                kmDto.ngayKetThuc = endDate;
                kmDto.tinhTrang=true;
                if (kmBus.suaKhuyenMai(kmDto))
                {
                    // Sửa thành công, hiển thị thông báo
                    MessageBox.Show("Sửa thành công!");
                    dataGridView1.DataSource = this.kmBus.getKhuyenMai();
                    textBox1.Text = string.Empty;
                    textBox2.Text = string.Empty;
                    textBox3.Text = string.Empty;
                    textBox4.Text = string.Empty;
                    textBox6.Text = string.Empty;

                }

            }
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            string maKMStr = textBox1.Text;
            int maKM;
            if (int.TryParse(maKMStr, out maKM))
                if (kmBus.xoaKhuyenMai(maKM))
                {
                    // Xóa thành công, hiển thị thông báo
                    kmBus.xoaKhuyenMai(maKM);
                    MessageBox.Show("Xóa thành công!");
                    dataGridView1.DataSource = this.kmBus.getKhuyenMai();
                    textBox1.Text = string.Empty;
                    textBox2.Text = string.Empty;
                    textBox3.Text = string.Empty;
                    textBox4.Text = string.Empty;
                    textBox6.Text = string.Empty;
                }
            else MessageBox.Show("Xóa thành công!");
        }

        private void guna2Button3_Click_2(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
        }

        private void dateTimePicker2_ValueChanged_1(object sender, EventArgs e)
        {
            textBox3.Text = dateTimePicker2.Value.ToString("dd/MM/yyyy");
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            textBox4.Text = dateTimePicker1.Value.ToString("dd/MM/yyyy");
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Lấy dữ liệu từ các cột trong hàng được chọn và hiển thị lên các TextBox
                textBox1.Text = row.Cells["Column1"].Value.ToString();// Thay "Column1" bằng tên cột thích hợp
                textBox2.Text = row.Cells["Column2"].Value.ToString();

                // Chuyển giá trị từ "Column3" thành đối tượng DateTime và định dạng thành "dd/MM/yyyy"
                if (DateTime.TryParse(row.Cells["Column3"].Value.ToString(), out DateTime dateValue3))
                {
                    textBox3.Text = dateValue3.ToString("dd/MM/yyyy");
                }
                else
                {
                    // Xử lý lỗi nếu giá trị không thể chuyển đổi thành DateTime
                    textBox3.Text = "Giá trị không hợp lệ";
                }

                // Chuyển giá trị từ "Column4" thành đối tượng DateTime và định dạng thành "dd/MM/yyyy"
                if (DateTime.TryParse(row.Cells["Column4"].Value.ToString(), out DateTime dateValue4))
                {
                    textBox4.Text = dateValue4.ToString("dd/MM/yyyy");
                }
                else
                {
                    // Xử lý lỗi nếu giá trị không thể chuyển đổi thành DateTime
                    textBox4.Text = "Giá trị không hợp lệ";
                }
                textBox6.Text= row.Cells["giatrigiam"].Value.ToString();

                // Thêm các TextBox khác tương ứng với các cột trong DataGridView
            }
        }



        
    }
    
}
