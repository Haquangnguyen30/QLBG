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

namespace GUI.SanPham
{
    public partial class SuaKichCoGUI : Form
    {
        KichCoDTO kc;
        DataGridView grid_KichCo;
        public SuaKichCoGUI(KichCoDTO kichCo,DataGridView grid_KichCo)
        {
            InitializeComponent();
            this.kc = kichCo;
            this.grid_KichCo = grid_KichCo;
        }

        private void SuaKichCoGUI_Load(object sender, EventArgs e)
        {
            txtMaKichCo.Text = kc.maKichCo.ToString();
            txtKichCo.Text = kc.kichCo.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Điều kiện nhập vào
            // else

        }
    }
}
