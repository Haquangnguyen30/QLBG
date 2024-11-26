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

namespace GUI.UserControls
{
    public partial class UC_PhanQuyen : UserControl
    {
        private PhanQuyenBUS pqBUS = new PhanQuyenBUS();
        public UC_PhanQuyen()
        {
            InitializeComponent();
        }

        private void UC_PhanQuyen_Load(object sender, EventArgs e)
        {
            dgvPhanQuyen.DataSource = pqBUS.getDSQuyen();
            dgvPhanQuyen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        }

        private void dgvPhanQuyen_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if(dgvPhanQuyen.IsCurrentCellDirty && dgvPhanQuyen.CurrentCell is DataGridViewCheckBoxCell)
            {
                dgvPhanQuyen.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgvPhanQuyen_CellValueChanged(object sender, DataGridViewCellEventArgs e)
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

        
    }
}
