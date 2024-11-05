namespace GUI.UserControls
{
    partial class UC_ThongKe
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabDoanhThu = new System.Windows.Forms.TabPage();
            this.tabSanPhamBanChay = new System.Windows.Forms.TabPage();
            this.tabKhachHangTichDiem = new System.Windows.Forms.TabPage();
            this.guna2TabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Controls.Add(this.tabDoanhThu);
            this.guna2TabControl1.Controls.Add(this.tabSanPhamBanChay);
            this.guna2TabControl1.Controls.Add(this.tabKhachHangTichDiem);
            this.guna2TabControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.guna2TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.Location = new System.Drawing.Point(0, 0);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(1200, 753);
            this.guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            this.guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            this.guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            this.guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            this.guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            this.guna2TabControl1.TabButtonSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.TabIndex = 0;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tabDoanhThu
            // 
            this.tabDoanhThu.BackColor = System.Drawing.Color.DimGray;
            this.tabDoanhThu.Location = new System.Drawing.Point(4, 44);
            this.tabDoanhThu.Name = "tabDoanhThu";
            this.tabDoanhThu.Padding = new System.Windows.Forms.Padding(3);
            this.tabDoanhThu.Size = new System.Drawing.Size(1192, 705);
            this.tabDoanhThu.TabIndex = 0;
            this.tabDoanhThu.Text = "Doanh thu";
            // 
            // tabSanPhamBanChay
            // 
            this.tabSanPhamBanChay.BackColor = System.Drawing.Color.RosyBrown;
            this.tabSanPhamBanChay.Location = new System.Drawing.Point(4, 44);
            this.tabSanPhamBanChay.Name = "tabSanPhamBanChay";
            this.tabSanPhamBanChay.Padding = new System.Windows.Forms.Padding(3);
            this.tabSanPhamBanChay.Size = new System.Drawing.Size(1192, 705);
            this.tabSanPhamBanChay.TabIndex = 1;
            this.tabSanPhamBanChay.Text = "Sản phẩm bán chạy";
            // 
            // tabKhachHangTichDiem
            // 
            this.tabKhachHangTichDiem.BackColor = System.Drawing.Color.LimeGreen;
            this.tabKhachHangTichDiem.Location = new System.Drawing.Point(4, 44);
            this.tabKhachHangTichDiem.Name = "tabKhachHangTichDiem";
            this.tabKhachHangTichDiem.Size = new System.Drawing.Size(1192, 705);
            this.tabKhachHangTichDiem.TabIndex = 2;
            this.tabKhachHangTichDiem.Text = "Khách hàng tích điểm";
            // 
            // UC_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2TabControl1);
            this.Name = "UC_ThongKe";
            this.Size = new System.Drawing.Size(1200, 753);
            this.guna2TabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage tabDoanhThu;
        private System.Windows.Forms.TabPage tabSanPhamBanChay;
        private System.Windows.Forms.TabPage tabKhachHangTichDiem;
    }
}
