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
    public partial class UC_ComponentSP : UserControl
    {
        public UC_ComponentSP()
        {
            InitializeComponent();
        }
        public string ProductName
        {
            get => tenSP.Text;
            set => tenSP.Text = value;
        }

        public string ProductPrice
        {
            get => giaBanSP.Text;
            set => giaBanSP.Text = value;
        }

        public Image ProductImage
        {
            get => imgSp.Image;
            set => imgSp.Image = value;
        }
        public string ProductColor
        {
            get => mauSp.Text;
            set => mauSp.Text = value;
        }
        private void tenSp_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public event EventHandler OnViewDetailsClicked;
        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            OnViewDetailsClicked?.Invoke(this, EventArgs.Empty); // Kích hoạt sự kiện khi nhấn nút "+"
        }
    }
}
