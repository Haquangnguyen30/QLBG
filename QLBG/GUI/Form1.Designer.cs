namespace GUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.pageBanHang = new System.Windows.Forms.TabPage();
            this.pageNhanVien = new System.Windows.Forms.TabPage();
            this.pageKhachHang = new System.Windows.Forms.TabPage();
            this.pageThongKe = new System.Windows.Forms.TabPage();
            this.pageKhuyenMai = new System.Windows.Forms.TabPage();
            this.pageSanPham = new System.Windows.Forms.TabPage();
            this.guna2TabControl2 = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pageNhapHang = new System.Windows.Forms.TabPage();
            this.guna2TabControl3 = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.guna2TabControl1.SuspendLayout();
            this.pageSanPham.SuspendLayout();
            this.guna2TabControl2.SuspendLayout();
            this.pageNhapHang.SuspendLayout();
            this.guna2TabControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1282, 50);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.Location = new System.Drawing.Point(1180, 12);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(99, 30);
            this.guna2Button1.TabIndex = 5;
            this.guna2Button1.Text = "Thoát";
            this.guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(35, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ BÁN GIÀY";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.guna2TabControl1.Controls.Add(this.pageBanHang);
            this.guna2TabControl1.Controls.Add(this.pageNhanVien);
            this.guna2TabControl1.Controls.Add(this.pageKhachHang);
            this.guna2TabControl1.Controls.Add(this.pageThongKe);
            this.guna2TabControl1.Controls.Add(this.pageKhuyenMai);
            this.guna2TabControl1.Controls.Add(this.pageSanPham);
            this.guna2TabControl1.Controls.Add(this.pageNhapHang);
            this.guna2TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2TabControl1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TabControl1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(200, 55);
            this.guna2TabControl1.Location = new System.Drawing.Point(0, 50);
            this.guna2TabControl1.Margin = new System.Windows.Forms.Padding(3, 50, 3, 50);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(1282, 623);
            this.guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.RoyalBlue;
            this.guna2TabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.SlateGray;
            this.guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.guna2TabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.Transparent;
            this.guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Transparent;
            this.guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(32)))), ((int)(((byte)(46)))));
            this.guna2TabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonSize = new System.Drawing.Size(200, 55);
            this.guna2TabControl1.TabIndex = 2;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            // 
            // pageBanHang
            // 
            this.pageBanHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(87)))));
            this.pageBanHang.Location = new System.Drawing.Point(204, 4);
            this.pageBanHang.Margin = new System.Windows.Forms.Padding(3, 40, 3, 3);
            this.pageBanHang.Name = "pageBanHang";
            this.pageBanHang.Padding = new System.Windows.Forms.Padding(3);
            this.pageBanHang.Size = new System.Drawing.Size(1074, 615);
            this.pageBanHang.TabIndex = 0;
            this.pageBanHang.Text = "Bán hàng";
            this.pageBanHang.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // pageNhanVien
            // 
            this.pageNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(87)))));
            this.pageNhanVien.Location = new System.Drawing.Point(204, 4);
            this.pageNhanVien.Name = "pageNhanVien";
            this.pageNhanVien.Padding = new System.Windows.Forms.Padding(3);
            this.pageNhanVien.Size = new System.Drawing.Size(1074, 615);
            this.pageNhanVien.TabIndex = 2;
            this.pageNhanVien.Text = "Nhân viên";
            // 
            // pageKhachHang
            // 
            this.pageKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(87)))));
            this.pageKhachHang.Location = new System.Drawing.Point(204, 4);
            this.pageKhachHang.Name = "pageKhachHang";
            this.pageKhachHang.Padding = new System.Windows.Forms.Padding(3);
            this.pageKhachHang.Size = new System.Drawing.Size(1074, 615);
            this.pageKhachHang.TabIndex = 3;
            this.pageKhachHang.Text = "Khách hàng";
            // 
            // pageThongKe
            // 
            this.pageThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(87)))));
            this.pageThongKe.Location = new System.Drawing.Point(204, 4);
            this.pageThongKe.Name = "pageThongKe";
            this.pageThongKe.Padding = new System.Windows.Forms.Padding(3);
            this.pageThongKe.Size = new System.Drawing.Size(1074, 615);
            this.pageThongKe.TabIndex = 4;
            this.pageThongKe.Text = "Thống kê";
            // 
            // pageKhuyenMai
            // 
            this.pageKhuyenMai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(87)))));
            this.pageKhuyenMai.Location = new System.Drawing.Point(204, 4);
            this.pageKhuyenMai.Name = "pageKhuyenMai";
            this.pageKhuyenMai.Size = new System.Drawing.Size(1074, 615);
            this.pageKhuyenMai.TabIndex = 5;
            this.pageKhuyenMai.Text = "Khuyến mãi";
            // 
            // pageSanPham
            // 
            this.pageSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(87)))));
            this.pageSanPham.Controls.Add(this.guna2TabControl2);
            this.pageSanPham.Location = new System.Drawing.Point(204, 4);
            this.pageSanPham.Name = "pageSanPham";
            this.pageSanPham.Size = new System.Drawing.Size(1074, 615);
            this.pageSanPham.TabIndex = 6;
            this.pageSanPham.Text = "Sản phẩm";
            // 
            // guna2TabControl2
            // 
            this.guna2TabControl2.Controls.Add(this.tabPage1);
            this.guna2TabControl2.Controls.Add(this.tabPage2);
            this.guna2TabControl2.Controls.Add(this.tabPage3);
            this.guna2TabControl2.Controls.Add(this.tabPage4);
            this.guna2TabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2TabControl2.ItemSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl2.Location = new System.Drawing.Point(0, 0);
            this.guna2TabControl2.Name = "guna2TabControl2";
            this.guna2TabControl2.SelectedIndex = 0;
            this.guna2TabControl2.Size = new System.Drawing.Size(1074, 615);
            this.guna2TabControl2.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl2.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl2.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl2.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl2.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl2.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl2.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl2.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl2.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.guna2TabControl2.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl2.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl2.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.guna2TabControl2.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl2.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl2.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.guna2TabControl2.TabButtonSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl2.TabIndex = 0;
            this.guna2TabControl2.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl2.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DimGray;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1066, 567);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sản phẩm";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1066, 567);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Loại sản phẩm";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 44);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1066, 567);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Màu sắc";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 44);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1066, 567);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Kích cỡ";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // pageNhapHang
            // 
            this.pageNhapHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(87)))));
            this.pageNhapHang.Controls.Add(this.guna2TabControl3);
            this.pageNhapHang.Location = new System.Drawing.Point(204, 4);
            this.pageNhapHang.Name = "pageNhapHang";
            this.pageNhapHang.Size = new System.Drawing.Size(1074, 615);
            this.pageNhapHang.TabIndex = 7;
            this.pageNhapHang.Text = "Nhập hàng";
            // 
            // guna2TabControl3
            // 
            this.guna2TabControl3.Controls.Add(this.tabPage5);
            this.guna2TabControl3.Controls.Add(this.tabPage6);
            this.guna2TabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2TabControl3.ItemSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl3.Location = new System.Drawing.Point(0, 0);
            this.guna2TabControl3.Name = "guna2TabControl3";
            this.guna2TabControl3.SelectedIndex = 0;
            this.guna2TabControl3.Size = new System.Drawing.Size(1074, 615);
            this.guna2TabControl3.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl3.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl3.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl3.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl3.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl3.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl3.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl3.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl3.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.guna2TabControl3.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl3.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl3.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.guna2TabControl3.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl3.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl3.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.guna2TabControl3.TabButtonSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl3.TabIndex = 0;
            this.guna2TabControl3.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl3.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(87)))));
            this.tabPage5.Location = new System.Drawing.Point(4, 44);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1066, 567);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "Nhập hàng";
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(87)))));
            this.tabPage6.Location = new System.Drawing.Point(4, 44);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1066, 567);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "Nhà cung cấp";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1282, 673);
            this.Controls.Add(this.guna2TabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quan ly ban giay";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.guna2TabControl1.ResumeLayout(false);
            this.pageSanPham.ResumeLayout(false);
            this.guna2TabControl2.ResumeLayout(false);
            this.pageNhapHang.ResumeLayout(false);
            this.guna2TabControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage pageBanHang;
        private System.Windows.Forms.TabPage pageNhanVien;
        private System.Windows.Forms.TabPage pageKhachHang;
        private System.Windows.Forms.TabPage pageThongKe;
        private System.Windows.Forms.TabPage pageKhuyenMai;
        private System.Windows.Forms.TabPage pageSanPham;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage pageNhapHang;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
    }
}

