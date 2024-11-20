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
    public partial class ThemKichCoGUI : Form
    {
        private string maKichCo;
        public ThemKichCoGUI(string data)
        {
            InitializeComponent();
            this.maKichCo = data;
        }

        private void ThemKichCoGUI_Load(object sender, EventArgs e)
        {
            txtMaKichCo.Text = maKichCo;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
