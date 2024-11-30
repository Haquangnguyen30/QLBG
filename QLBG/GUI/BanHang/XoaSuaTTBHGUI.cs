using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.BanHang
{
    public partial class XoaSuaTTBHGUI : Form
    {
        private int rowIndex;
        private DataGridView GioHangDataGridView;
        private string tenSP;
        private string maSP;
        private string size;
        private int soLuong;
        private int maKichCo;
        private float giaBan;
        private Action updateTongTien;
        private BanHangBLL BHbll = new BanHangBLL();
        public XoaSuaTTBHGUI(int rowIndex, DataGridView GioHangDataGridView, Action updateTongTien)
        {
            InitializeComponent();
            tenSP = GioHangDataGridView.Rows[rowIndex].Cells["tenSP"].Value.ToString();
            size = GioHangDataGridView.Rows[rowIndex].Cells["kichCo"].Value.ToString();
            soLuong = Convert.ToInt32(GioHangDataGridView.Rows[rowIndex].Cells["soLuong"].Value);
            giaBan = float.Parse(GioHangDataGridView.Rows[rowIndex].Cells["giaBan"].Value.ToString());
            maSP= GioHangDataGridView.Rows[rowIndex].Cells["maSP"].Value.ToString();
            maKichCo= int.Parse(GioHangDataGridView.Rows[rowIndex].Cells["maKichCo"].Value.ToString());
            this.rowIndex = rowIndex;
            this.GioHangDataGridView = GioHangDataGridView;
            this.updateTongTien = updateTongTien;
            txtTenSP.Text = tenSP;
            txtSize.Text = size;
            txtSoLuong.Value = soLuong;          
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            int stock = BHbll.GetSoLuongTheoSize(maSP, maKichCo);
            if (txtSoLuong.Value > stock)
            {
                MessageBox.Show("Số lượng đã vượt quá tồn kho");
                txtSoLuong.Value = stock;
            }
            else
            {
                GioHangDataGridView.Rows[rowIndex].Cells["soLuong"].Value = txtSoLuong.Value;
                GioHangDataGridView.Rows[rowIndex].Cells["thanhTien"].Value = giaBan * (int)txtSoLuong.Value;
                updateTongTien?.Invoke();
                this.Close();
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            GioHangDataGridView.Rows.RemoveAt(rowIndex);
            updateTongTien?.Invoke();
            this.Close();
        }

        private void XoaSuaTTBHGUI_Load(object sender, EventArgs e)
        {

        }
    }
}
