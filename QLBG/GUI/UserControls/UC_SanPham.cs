using BLL;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.SanPham;
using NPOI.POIFS.NIO;
using NPOI.SS.Formula.Functions;
using DTO;
using OfficeOpenXml;
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;
using OfficeOpenXml.Drawing.Slicer.Style;

namespace GUI.UserControls
{
    public partial class UC_SanPham : UserControl
    {
        SanPhamBUS spBUS = new SanPhamBUS();
        LoaiSanPhamBUS lspBUS = new LoaiSanPhamBUS();
        KichCoBUS kcBUS = new KichCoBUS();
        SanPham_KichCoBUS spkcBUS = new SanPham_KichCoBUS();
        public UC_SanPham()
        {
            InitializeComponent();
        }
        private void UC_SanPham_Load(object sender, EventArgs e)
        {

            //SanPham
            grid_SanPham.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SanPham.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(80, 17, 132);

            grid_SanPham.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SanPham.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SanPham.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SanPham.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SanPham.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SanPham.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SanPham.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // cột img
            grid_SanPham.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SanPham.DataSource = this.spBUS.getDSSanPham();
            textSanPham(0);

            //ChiTietSoLuong
            grid_ChiTietSoLuong.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ChiTietSoLuong.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ChiTietSoLuong.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_ChiTietSoLuong.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(80, 17, 132);
            
            //KichCo
            grid_KichCo.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_KichCo.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_KichCo.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_KichCo.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(80, 17, 132);
            DataTable dt = this.kcBUS.getDSKichCo();

            dt.Columns.Add("chieuDaiBanChan", typeof(double));
            double[] chieuDaiValues = { 24, 24.5, 25, 25.5, 26 };
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["chieuDaiBanChan"] = chieuDaiValues[i % chieuDaiValues.Length];
            }
            grid_KichCo.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_KichCo.DataSource = dt;

            //LoaiSanPham
            grid_LoaiSanPham.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_LoaiSanPham.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_LoaiSanPham.Columns[1].DefaultCellStyle.Alignment= DataGridViewContentAlignment.MiddleCenter;
            grid_LoaiSanPham.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(80, 17, 132);
            grid_LoaiSanPham.DataSource = this.lspBUS.getDSLoaiSanPham();
            textLoaiSanPham(0);

        }



        public void textSanPham(int id) 
        {
            DataGridViewRow row = grid_SanPham.Rows[id];
            txtMaSanPham.Text = row.Cells[0].Value.ToString();
            txtTenSanPham.Text = row.Cells[1].Value.ToString();
            txtGiaBan.Text = row.Cells[2].Value.ToString();
            txtSoLuong.Text = row.Cells[3].Value.ToString();
            txtGiaNhap.Text = row.Cells[5].Value.ToString();
            txtMau.Text = row.Cells[6].Value.ToString(); 
            txtMaLoai.Text = row.Cells[7].Value.ToString();
            DataTable tbSoLuong = this.spkcBUS.getChiTietSoLuong(row.Cells[0].Value.ToString());

            string imageFileName = row.Cells[4].Value.ToString();
            string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string imagePath = Path.Combine(projectDirectory, @"..\..\..\GUI\Resources\ImgSanPham", imageFileName);
            try
            {
                ptbSanPham.Image = new Bitmap(imagePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading image: {ex.Message}");
                ptbSanPham.Image = null;
            }

            ptbSanPham.SizeMode = PictureBoxSizeMode.Zoom;
            grid_ChiTietSoLuong.DataSource = tbSoLuong;
        }
        public void textLoaiSanPham(int id)
        {
            DataGridViewRow row = grid_LoaiSanPham.Rows[id];
            txtMaLoaiSanPham.Text = row.Cells[0].Value.ToString();
            txtTenLoaiSanPham.Text = row.Cells[1].Value.ToString();
        }



        private void grid_SanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textSanPham(e.RowIndex);
            }
        }
        private void grid_LoaiSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textLoaiSanPham(e.RowIndex);
            }
        }



        public string newMaSP()
        {
            string MaSP;
            DataTable tbMaSP = spBUS.getMaSP();
            string maxMaSP = tbMaSP.Rows[0]["maSP"].ToString();
            foreach (DataRow row in tbMaSP.Rows)
            {
                string temp = row["maSP"].ToString();
                if (String.Compare(temp, maxMaSP) > 0)
                {
                    maxMaSP = temp;
                }
            }
            string tiento = maxMaSP.Substring(0, 1);
            string hauto = maxMaSP.Substring(1);

            int number = int.Parse(hauto) + 1;
            MaSP = tiento + number.ToString("D3");
            return MaSP;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string MaSP = newMaSP();
            ThemSanPhamGUI newForm = new ThemSanPhamGUI(MaSP, grid_SanPham);
            newForm.ShowDialog();
        }
      
        private void btnThemLoai_Click(object sender, EventArgs e)
        {   
            DataTable tbMaLSP = this.lspBUS.getMaLSP();
            int maxLoaiSanPham = 0;
            foreach(DataRow row in tbMaLSP.Rows)
            {
                int temp = Convert.ToInt32(row["maLoai"]);
                if(temp > maxLoaiSanPham)
                {
                    maxLoaiSanPham = temp;
                }
            }
            int newLoaiSanPham = maxLoaiSanPham + 1;
            ThemLoaiSanPhamGUI newForm = new ThemLoaiSanPhamGUI(newLoaiSanPham.ToString(), grid_LoaiSanPham);
            newForm.ShowDialog();
            textSanPham(0);
        }




        private void btnSuaSanPham_Click(object sender, EventArgs e)
        {
            string maSP = txtMaSanPham.Text;
            SanPhamDTO sp = spBUS.getSanPham(maSP);
            if (ptbSanPham.Image != null)
            {
                ptbSanPham.Image.Dispose();
            }
            SuaSanPhamGUI newForm = new SuaSanPhamGUI(sp, grid_SanPham);
            newForm.ShowDialog();
            textSanPham(0);


        }

        private void btnSuaLoai_Click(object sender, EventArgs e)
        {   
            LoaiSanPhamDTO loai = new LoaiSanPhamDTO();
            loai.maLoai = Convert.ToInt32(txtMaLoaiSanPham.Text);
            loai.tenLoai = txtTenLoaiSanPham.Text;
            SuaLoaiSanPhamGUI newForm = new SuaLoaiSanPhamGUI(loai, grid_LoaiSanPham);
            newForm.ShowDialog();
            textLoaiSanPham(0);
        }



        private void btnReloadSanPham_Click(object sender, EventArgs e)
        {
            grid_SanPham.DataSource = null;
            grid_SanPham.DataSource = this.spBUS.getDSSanPham();
            textSanPham(0);
        }
        private void btnReloadLoaiSanPham_Click(object sender, EventArgs e)
        {
            grid_LoaiSanPham.DataSource = null;
            grid_LoaiSanPham.DataSource = this.lspBUS.getDSLoaiSanPham();
            textLoaiSanPham(0);
        }



        private void btnXoaSanPham_Click(object sender, EventArgs e)
        {
            string maSP = txtMaSanPham.Text;
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm có mã = " + maSP + " không?", "Xóa sản phẩm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SanPhamDTO sanPham = new SanPhamDTO();
                sanPham.maSP = txtMaSanPham.Text.Trim();
                sanPham.tinhTrang = false;
                if (spBUS.deleteSanPham(sanPham))
                {
                    MessageBox.Show("Xóa sản phẩm thành công");
                    grid_SanPham.DataSource = spBUS.getDSSanPham();
                    textLoaiSanPham(0);

                }
                else
                {
                    MessageBox.Show("Xóa sản phẩm thất bại");
                }
            }
            else
            {
                return;
            }
        }
        private void btnXoaLoaiSanPham_Click(object sender, EventArgs e)
        {
            string maLSP = txtMaLoaiSanPham.Text;
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa loại sản phẩm có mã = " +maLSP +" không?", "Xóa loại sản phẩm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) { 
                LoaiSanPhamDTO loai = new LoaiSanPhamDTO();
                loai.maLoai = Convert.ToInt32(txtMaLoaiSanPham.Text.Trim());
                loai.tenLoai = txtTenLoaiSanPham.Text;
                loai.tinhTrang = false;
                if (lspBUS.deleteLoaiSanPham(loai))
                {
                    MessageBox.Show("Xóa loại sản phẩm thành công");
                    grid_LoaiSanPham.DataSource = lspBUS.getDSLoaiSanPham();
                    textLoaiSanPham(0);

                }
                else
                {
                    MessageBox.Show("Xóa loại sản phẩm thất bại");
                }
            }
            else{
                return;
            }
        }
     

       
        private void ImportExcel(string path)
        {   
            using (ExcelPackage excelPackage = new ExcelPackage(new FileInfo(path)))
            {
                ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets[0];
                DataTable Dttable = new DataTable();
                for (int i = excelWorksheet.Dimension.Start.Column; i <= excelWorksheet.Dimension.End.Column; i++)
                {
                    Dttable.Columns.Add(excelWorksheet.Cells[1, i].Value.ToString());          
                }
                for (int i = excelWorksheet.Dimension.Start.Row + 1; i <= excelWorksheet.Dimension.End.Row;i++)
                {
                    List<string> list = new List<string>();
                    for (int j = excelWorksheet.Dimension.Start.Column; j <= excelWorksheet.Dimension.End.Column; j++)
                    {
                        list.Add(excelWorksheet.Cells[i, j].Value.ToString());
                    }
                    Dttable.Rows.Add(list.ToArray());
                }
                foreach (DataRow row in Dttable.Rows)
                {
                    SanPhamDTO sanPham = new SanPhamDTO();

                    sanPham.maSP = newMaSP();
                    sanPham.tenSP = row["tenSP"].ToString();
                    sanPham.giaBan = float.Parse(row["giaBan"].ToString());
                    sanPham.giaNhap = float.Parse(row["giaNhap"].ToString());
                    sanPham.mau = row["mau"].ToString();
                    sanPham.maLoai = Convert.ToInt32(row["maLoai"].ToString());
                    sanPham.img = newMaSP();
                    sanPham.tinhTrang = true;
                    if (spBUS.addSanPham(sanPham))
                    {
                        grid_SanPham.DataSource = spBUS.getDSSanPham();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại");
                    }
                }
            }
        }
        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Import Excel";
            openFile.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ImportExcel(openFile.FileName);
                    MessageBox.Show("Nhập file thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nhập file không thành công:\n" + ex.Message);
                }
            }
        }



        private void ExportExcel(string path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < grid_SanPham.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = grid_SanPham.Columns[i].HeaderText;
            }
            for (int i = 0; i < grid_SanPham.Rows.Count; i++)
            {
                for (int j = 0; j < grid_SanPham.Columns.Count; j++) 
                {
                    application.Cells[i + 2, j + 1] = grid_SanPham.Rows[i].Cells[j].Value;
                }
            }
            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;
        }
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export Excel";
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportExcel(saveFileDialog.FileName);
                    MessageBox.Show("Xuất file thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xuất file không thành công!\n"+ ex.Message);
                }
            }
        }



        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                grid_SanPham.DataSource = spBUS.getDSSanPham();
            }
            else
            {
                grid_SanPham.DataSource = spBUS.searchSanPham(txtSearch.Text);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
