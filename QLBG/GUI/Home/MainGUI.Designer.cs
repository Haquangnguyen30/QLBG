namespace GUI.Home
{
    partial class MainGUI
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabNhanVien = new System.Windows.Forms.TabPage();
            this.tabNhapHang = new System.Windows.Forms.TabPage();
            this.tabBanHang = new System.Windows.Forms.TabPage();
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabKhachHang = new System.Windows.Forms.TabPage();
            this.tabKhuyenMai = new System.Windows.Forms.TabPage();
            this.tabSanPham = new System.Windows.Forms.TabPage();
            this.tabPhanQuyen = new System.Windows.Forms.TabPage();
            this.tabThongKe = new System.Windows.Forms.TabPage();
            this.btnThoat = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.tabBanHang.SuspendLayout();
            this.guna2TabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.guna2Panel1.Controls.Add(this.btnThoat);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1300, 64);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ CỦA HÀNG BÁN GIÀY";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabNhanVien
            // 
            this.tabNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.tabNhanVien.Location = new System.Drawing.Point(204, 4);
            this.tabNhanVien.Name = "tabNhanVien";
            this.tabNhanVien.Padding = new System.Windows.Forms.Padding(3);
            this.tabNhanVien.Size = new System.Drawing.Size(1092, 628);
            this.tabNhanVien.TabIndex = 2;
            this.tabNhanVien.Text = "Nhân viên";
            this.tabNhanVien.Click += new System.EventHandler(this.tabNhanVien_Click);
            // 
            // tabNhapHang
            // 
            this.tabNhapHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.tabNhapHang.Location = new System.Drawing.Point(204, 4);
            this.tabNhapHang.Name = "tabNhapHang";
            this.tabNhapHang.Padding = new System.Windows.Forms.Padding(3);
            this.tabNhapHang.Size = new System.Drawing.Size(1092, 628);
            this.tabNhapHang.TabIndex = 1;
            this.tabNhapHang.Text = "Nhập hàng";
            this.tabNhapHang.Click += new System.EventHandler(this.tabNhapHang_Click);
            // 
            // tabBanHang
            // 
            this.tabBanHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.tabBanHang.Controls.Add(this.label2);
            this.tabBanHang.Location = new System.Drawing.Point(204, 4);
            this.tabBanHang.Name = "tabBanHang";
            this.tabBanHang.Padding = new System.Windows.Forms.Padding(3);
            this.tabBanHang.Size = new System.Drawing.Size(1092, 628);
            this.tabBanHang.TabIndex = 0;
            this.tabBanHang.Text = "Bán hàng";
            this.tabBanHang.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.guna2TabControl1.Controls.Add(this.tabBanHang);
            this.guna2TabControl1.Controls.Add(this.tabNhapHang);
            this.guna2TabControl1.Controls.Add(this.tabNhanVien);
            this.guna2TabControl1.Controls.Add(this.tabKhachHang);
            this.guna2TabControl1.Controls.Add(this.tabKhuyenMai);
            this.guna2TabControl1.Controls.Add(this.tabSanPham);
            this.guna2TabControl1.Controls.Add(this.tabPhanQuyen);
            this.guna2TabControl1.Controls.Add(this.tabThongKe);
            this.guna2TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(200, 55);
            this.guna2TabControl1.Location = new System.Drawing.Point(0, 64);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(1300, 636);
            this.guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(32)))), ((int)(((byte)(46)))));
            this.guna2TabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(32)))), ((int)(((byte)(46)))));
            this.guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.guna2TabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(32)))), ((int)(((byte)(46)))));
            this.guna2TabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(32)))), ((int)(((byte)(46)))));
            this.guna2TabControl1.TabButtonSize = new System.Drawing.Size(200, 55);
            this.guna2TabControl1.TabIndex = 1;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.guna2TabControl1.SelectedIndexChanged += new System.EventHandler(this.guna2TabControl1_SelectedIndexChanged);
            // 
            // tabKhachHang
            // 
            this.tabKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.tabKhachHang.Location = new System.Drawing.Point(204, 4);
            this.tabKhachHang.Name = "tabKhachHang";
            this.tabKhachHang.Size = new System.Drawing.Size(1092, 628);
            this.tabKhachHang.TabIndex = 3;
            this.tabKhachHang.Text = "Khách hàng";
            this.tabKhachHang.Click += new System.EventHandler(this.tabKhachHang_Click);
            // 
            // tabKhuyenMai
            // 
            this.tabKhuyenMai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.tabKhuyenMai.Location = new System.Drawing.Point(204, 4);
            this.tabKhuyenMai.Name = "tabKhuyenMai";
            this.tabKhuyenMai.Size = new System.Drawing.Size(1092, 628);
            this.tabKhuyenMai.TabIndex = 4;
            this.tabKhuyenMai.Text = "Khuyến mãi";
            this.tabKhuyenMai.Click += new System.EventHandler(this.tabKhuyenMai_Click);
            // 
            // tabSanPham
            // 
            this.tabSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.tabSanPham.Location = new System.Drawing.Point(234, 4);
            this.tabSanPham.Name = "tabSanPham";
            this.tabSanPham.Size = new System.Drawing.Size(1704, 828);
            this.tabSanPham.TabIndex = 5;
            this.tabSanPham.Text = "Sản phẩm";
            this.tabSanPham.Click += new System.EventHandler(this.tabSanPham_Click);
            // 
            // tabPhanQuyen
            // 
            this.tabPhanQuyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.tabPhanQuyen.Location = new System.Drawing.Point(204, 4);
            this.tabPhanQuyen.Name = "tabPhanQuyen";
            this.tabPhanQuyen.Size = new System.Drawing.Size(1092, 628);
            this.tabPhanQuyen.TabIndex = 6;
            this.tabPhanQuyen.Text = "Phân quyền";
            this.tabPhanQuyen.Click += new System.EventHandler(this.tabPhanQuyen_Click);
            // 
            // tabThongKe
            // 
            this.tabThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.tabThongKe.Location = new System.Drawing.Point(234, 4);
            this.tabThongKe.Name = "tabThongKe";
            this.tabThongKe.Size = new System.Drawing.Size(1704, 828);
            this.tabThongKe.TabIndex = 7;
            this.tabThongKe.Text = "Thống kê";
            this.tabThongKe.Click += new System.EventHandler(this.tabThongKe_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BorderRadius = 20;
            this.btnThoat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThoat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThoat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThoat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThoat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(32)))), ((int)(((byte)(46)))));
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI Emoji", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(1208, 12);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(80, 38);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(349, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bán hàng nè";
            // 
            // MainGUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.guna2TabControl1);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainGUI_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.tabBanHang.ResumeLayout(false);
            this.tabBanHang.PerformLayout();
            this.guna2TabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabNhanVien;
        private System.Windows.Forms.TabPage tabNhapHang;
        private System.Windows.Forms.TabPage tabBanHang;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage tabKhachHang;
        private System.Windows.Forms.TabPage tabKhuyenMai;
        private System.Windows.Forms.TabPage tabSanPham;
        private System.Windows.Forms.TabPage tabPhanQuyen;
        private System.Windows.Forms.TabPage tabThongKe;
        private Guna.UI2.WinForms.Guna2Button btnThoat;
        private System.Windows.Forms.Label label2;
    }
}