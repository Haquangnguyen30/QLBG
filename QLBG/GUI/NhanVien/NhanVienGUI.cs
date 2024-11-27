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
using ClosedXML.Excel;
using BUS;

namespace GUI.NhanVien
{
    public partial class NhanVienGUI : Form
    {
        NhanVienBUS nvBus = new NhanVienBUS();
        //TaiKhoanBUS tkBus = new TaiKhoanBUS();
        NhanVienDTO nvDto = new NhanVienDTO();
        TaiKhoanDTO tkDto = new TaiKhoanDTO();
        public NhanVienGUI()
        {
            InitializeComponent();
        }
        private void NhanVienGUI_Load_1(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = this.nvBus.getNhanVien();
            //cotXoa.Text = "Xóa";
            //cotXoa.UseColumnTextForButtonValue = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "cotXoa")
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string ID = row.Cells["cotMaNv"].Value.ToString();
                // Xóa
                if (nvBus.xoaNhanVien(ID))
                {
                    MessageBox.Show("Xóa thành công");
                    dataGridView1.DataSource = nvBus.getNhanVien(); // get thanh vien
                }
                else
                {
                    MessageBox.Show("Xóa ko thành công");
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Form themSp = null;
            //themSp = new ThongTinNhanVienGUI(this, dataGridView1);
            //themSp.StartPosition = FormStartPosition.CenterScreen;
            //themSp.ShowDialog();
        }

        private void dataGridView1_CellMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            nvDto = new NhanVienDTO();
            Form thongTinNv = null;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name != "cotXoa")
                {
                    dataGridView1.CurrentRow.Selected = true;

                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    nvDto.maNV = row.Cells["cotMaNv"].Value.ToString();
                    nvDto.tenNV = row.Cells["cotTenNv"].Value.ToString();
                    nvDto.gioiTinh = row.Cells["cotGioiTinh"].Value.ToString();
                    nvDto.sdt = row.Cells["cotSdt"].Value.ToString();
                    nvDto.diaChi = row.Cells["cotDiaChi"].Value.ToString();
                    nvDto.chucVu = row.Cells["cotChucVu"].Value.ToString();
                    nvDto.ngaySinh = row.Cells["cotNgaySinh"].Value.ToString();
                    //nvDto.tinhTrang = true;
                    //tkDto = tkBus.getTk(nvDto.maNV);
                    thongTinNv = new SuaThongTinNhanVienGUI(nvDto, dataGridView1);
                    thongTinNv.StartPosition = FormStartPosition.CenterScreen;
                    thongTinNv.ShowDialog();


                }
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            nvBus.ThemDS();
            dataGridView1.DataSource = nvBus.getNhanVien();
        }


        public void ExportToExcel(DataGridView dataGridView)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Data");

                // Lấy tên cột từ DataGridView và thêm vào file Excel
                for (int i = 2; i <= dataGridView.Columns.Count; i++)
                {
                    worksheet.Cell(1, i).Value = dataGridView.Columns[i - 1].HeaderText;
                }

                // Thêm dữ liệu từ DataGridView vào file Excel
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    for (int j = 1; j < dataGridView.Columns.Count; j++)
                    {
                        worksheet.Cell(i + 2, j + 1).Value = dataGridView.Rows[i].Cells[j].Value?.ToString();
                    }
                }

                // Lưu file Excel
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 1;
                saveDialog.RestoreDirectory = true;

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Xuất file thành công!");
                }
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            ExportToExcel(dataGridView1);
        }


        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            string key = textBox1.Text;

            dataGridView1.DataSource = nvBus.getFindThanhVien(key);
        }
    }
}
