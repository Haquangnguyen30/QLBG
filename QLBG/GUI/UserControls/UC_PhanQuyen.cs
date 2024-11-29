using BLL;
using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UserControls
{
    public partial class UC_PhanQuyen : UserControl
    {
        private PhanQuyenBUS pqBUS = new PhanQuyenBUS();
        private TaiKhoanDTO tkDto = new TaiKhoanDTO();
        private QLTaiKhoanBUS tkBus = new QLTaiKhoanBUS();
        private NhanVienBUS nvBus = new NhanVienBUS();
        public UC_PhanQuyen()
        {
            InitializeComponent();
        }

        private void UC_PhanQuyen_Load(object sender, EventArgs e)
        {
            dgvPhanQuyen.DataSource = pqBUS.getDSQuyen();
            dgvPhanQuyen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.DataSource = this.tkBus.getTaiKhoan();
            comboBox2.DataSource = tkBus.getAllMaNhanVien();
            comboBox2.DisplayMember = "tenNV"; // Tên cột bạn muốn hiển thị
            comboBox2.ValueMember = "maNV";
            comboBox1.DataSource = tkBus.getAllMaQuyen();
            comboBox1.DisplayMember = "tenQuyen"; // Tên cột bạn muốn hiển thị
            comboBox1.ValueMember = "maQuyen";
        }

        private void dgvPhanQuyen_CurrentCellDirtyStateChanged_1(object sender, EventArgs e)
        {
            if(dgvPhanQuyen.IsCurrentCellDirty && dgvPhanQuyen.CurrentCell is DataGridViewCheckBoxCell)
            {
                dgvPhanQuyen.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        
        private void dgvPhanQuyen_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPhanQuyen.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
            {
                DialogResult resultDialog = MessageBox.Show("Bạn có muốn thay đổi trường này?", "Thông báo",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultDialog == DialogResult.Yes)
                {
                    int maQuyen = (int)dgvPhanQuyen.Rows[e.RowIndex].Cells["Mã quyền"].Value;
                    String columnName = dgvPhanQuyen.Columns[e.ColumnIndex].Name;
                    bool check = (bool)dgvPhanQuyen.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                    int result = pqBUS.suaQuyen(maQuyen, columnName, check);
                    if (result > 0)
                    {
                        MessageBox.Show("Cập nhật thành công.", "Thông báo", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                dgvPhanQuyen.DataSource = pqBUS.getDSQuyen();
            }
        }




        // Tai Khoan
        // tai khoan
        private bool ValidateInput(string maNV, string maQuyen, string tenDangNhap, string matKhau)
        {
            // Kiểm tra điều kiện validate ở đây
            if (string.IsNullOrWhiteSpace(maNV) || string.IsNullOrWhiteSpace(maQuyen) ||
                string.IsNullOrWhiteSpace(tenDangNhap) || string.IsNullOrWhiteSpace(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return false;
            }

            if (matKhau.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự.");
                return false;
            }

            return true;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            tkDto = new TaiKhoanDTO();
            string maNV = comboBox2.SelectedValue.ToString();
            string maQuyenStr = comboBox1.SelectedValue.ToString();
            string tenDangNhap = textBox1.Text;
            string matKhau = textBox6.Text;
            if (ValidateInput(maNV, maQuyenStr, tenDangNhap, matKhau))
            {
                if (int.TryParse(maQuyenStr, out int maQuyen))
                {
                    // Lấy đối tượng tài khoản
                    var existingAccount = this.tkBus.getTk(maNV);

                    if (existingAccount != null && existingAccount.maNV == maNV)
                    {
                        MessageBox.Show("Tài khoản đã tồn tại. Vui lòng chọn tên đăng nhập khác.");
                    }
                    else
                    {
                        tkDto.maNV = maNV;
                        tkDto.maQuyen = maQuyen;
                        tkDto.tenDangNhap = tenDangNhap;
                        tkDto.matKhau = matKhau;

                        if (tkBus.themTaiKhoan(tkDto))
                        {
                            MessageBox.Show("Thêm thành công!");
                            dataGridView1.DataSource = this.tkBus.getTaiKhoan();
                            comboBox1.SelectedValue = -1;
                            comboBox2.SelectedValue = -1;
                            textBox1.Text = string.Empty;
                            textBox6.Text = string.Empty;
                            comboBox1.SelectedValue = -1;
                            comboBox2.SelectedValue = -1;
                            string chucvu = "";
                            if (maQuyen == 1)
                                chucvu = "Admin";
                            if (maQuyen == 2)
                                chucvu = "Quản lý";
                            if (maQuyen == 3)
                                chucvu = "Nhân Viên";
                            if (maQuyen == 4)
                                chucvu = "Thủ Kho";
                            nvBus.capNhapChucVu(maNV, chucvu);

                        }
                        else
                        {
                            MessageBox.Show("Thêm không thành công. Kiểm tra lại thông tin.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Mã quyền không hợp lệ. Vui lòng kiểm tra lại.");
                }
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            tkDto = new TaiKhoanDTO();
            string maNV = comboBox2.SelectedValue.ToString();
            string maQuyenStr = comboBox1.SelectedValue.ToString();
            string tenDangNhap = textBox1.Text;
            string matKhau = textBox6.Text;

            if (ValidateInput(maNV, maQuyenStr, tenDangNhap, matKhau))
            {
                if (int.TryParse(maQuyenStr, out int maQuyen))
                {
                    tkDto.maNV = maNV;
                    tkDto.maQuyen = maQuyen;
                    tkDto.tenDangNhap = tenDangNhap;
                    tkDto.matKhau = matKhau;

                    if (tkBus.suaTaiKhoan(tkDto))
                    {
                        MessageBox.Show("Sửa thành công!");
                        dataGridView1.DataSource = this.tkBus.getTaiKhoan();
                        comboBox1.SelectedValue = -1;
                        comboBox2.SelectedValue = -1;
                        textBox1.Text = string.Empty;
                        textBox6.Text = string.Empty;
                        comboBox1.SelectedValue = -1;
                        comboBox2.SelectedValue = -1;
                        string chucvu = "";
                        if (maQuyen == 1)
                            chucvu = "Admin";
                        if (maQuyen == 2)
                            chucvu = "Quản lý";
                        if (maQuyen == 3)
                            chucvu = "Nhân Viên";
                        if (maQuyen == 4)
                            chucvu = "Thủ kho";
                        nvBus.capNhapChucVu(maNV, chucvu);
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công. Kiểm tra lại thông tin.");
                    }
                }
                else
                {
                    MessageBox.Show("Mã quyền không hợp lệ. Vui lòng kiểm tra lại.");
                }
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedValue = -1;
            comboBox2.SelectedValue = -1;
            textBox1.Text = string.Empty;
            textBox6.Text = string.Empty;
            //dataGridView1.ClearSelection();
            comboBox1.SelectedValue = -1;
            comboBox2.SelectedValue = -1;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Lấy dữ liệu từ các cột trong hàng được chọn và hiển thị lên các TextBox
                comboBox2.SelectedValue = row.Cells["Column1"].Value.ToString();// Thay "Column1" bằng tên cột thích hợp
                comboBox1.SelectedValue = row.Cells["Column2"].Value.ToString();
                textBox1.Text = row.Cells["Column3"].Value.ToString();
                textBox6.Text = row.Cells["Column4"].Value.ToString();

            }
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            dgvPhanQuyen.DataSource = pqBUS.getDSQuyen();
            dgvPhanQuyen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.DataSource = this.tkBus.getTaiKhoan();
            comboBox2.DataSource = tkBus.getAllMaNhanVien();
            comboBox2.DisplayMember = "tenNV"; // Tên cột bạn muốn hiển thị
            comboBox2.ValueMember = "maNV";
            comboBox1.DataSource = tkBus.getAllMaQuyen();
            comboBox1.DisplayMember = "tenQuyen"; // Tên cột bạn muốn hiển thị
            comboBox1.ValueMember = "maQuyen";
        }

        
    }
}
