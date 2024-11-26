using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.NhapHang
{
    public partial class XoaSuaSPCNGUI : Form
    {
        private int rowIndex;
        private DataGridView dgvDSSPCN;
        private string maSP;
        private string size;
        private int soLuong;
        private float giaNhap;
        public XoaSuaSPCNGUI(int rowIndex, DataGridView dgvDSSPCN)
        {
            InitializeComponent();
            maSP = dgvDSSPCN.Rows[rowIndex].Cells["MaSP"].Value.ToString();
            size = dgvDSSPCN.Rows[rowIndex].Cells["KichCo"].Value.ToString();
            soLuong = Convert.ToInt32(dgvDSSPCN.Rows[rowIndex].Cells["SoLuong"].Value);
            giaNhap = float.Parse(dgvDSSPCN.Rows[rowIndex].Cells["GiaNhap"].Value.ToString());

            this.rowIndex = rowIndex;
            this.dgvDSSPCN = dgvDSSPCN;

            txtMaSP.Text = maSP;
            txtSize.Text = size;
            txtSoLuong.Value = soLuong;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            dgvDSSPCN.Rows[rowIndex].Cells["SoLuong"].Value = txtSoLuong.Value;
            dgvDSSPCN.Rows[rowIndex].Cells["ThanhTien"].Value = giaNhap * (int)txtSoLuong.Value;

            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            dgvDSSPCN.Rows.RemoveAt(rowIndex);

            this.Close();
        }

        private void XoaSuaSPCNGUI_Load(object sender, EventArgs e)
        {

        }
    }
}
