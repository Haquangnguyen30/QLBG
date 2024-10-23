namespace GUI.Home
{
    partial class HomeGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeGUI));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnPhanQuyen = new Guna.UI2.WinForms.Guna2Button();
            this.btnThongKe = new Guna.UI2.WinForms.Guna2Button();
            this.btnKhuyenMai = new Guna.UI2.WinForms.Guna2Button();
            this.btnNhanVien = new Guna.UI2.WinForms.Guna2Button();
            this.btnKhachHang = new Guna.UI2.WinForms.Guna2Button();
            this.btnSanPham = new Guna.UI2.WinForms.Guna2Button();
            this.btnNhapHang = new Guna.UI2.WinForms.Guna2Button();
            this.btnBanHang = new Guna.UI2.WinForms.Guna2Button();
            this.imgSlide = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.uC_KhuyenMai1 = new GUI.UserControls.UC_KhuyenMai();
            this.uC_SanPham1 = new GUI.UserControls.UC_SanPham();
            this.uC_ThongKe1 = new GUI.UserControls.UC_ThongKe();
            this.uC_PhanQuyen1 = new GUI.UserControls.UC_PhanQuyen();
            this.uC_NhanVien1 = new GUI.UserControls.UC_NhanVien();
            this.uC_NhapHang1 = new GUI.UserControls.UC_NhapHang();
            this.uC_KhachHang1 = new GUI.UserControls.UC_KhachHang();
            this.uC_BanHang1 = new GUI.UserControls.UC_BanHang();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSlide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.btnPhanQuyen);
            this.guna2Panel1.Controls.Add(this.btnThongKe);
            this.guna2Panel1.Controls.Add(this.btnKhuyenMai);
            this.guna2Panel1.Controls.Add(this.btnNhanVien);
            this.guna2Panel1.Controls.Add(this.btnKhachHang);
            this.guna2Panel1.Controls.Add(this.btnSanPham);
            this.guna2Panel1.Controls.Add(this.btnNhapHang);
            this.guna2Panel1.Controls.Add(this.btnBanHang);
            this.guna2Panel1.Controls.Add(this.imgSlide);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.White;
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(160, 753);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // btnPhanQuyen
            // 
            this.btnPhanQuyen.BackColor = System.Drawing.Color.Transparent;
            this.btnPhanQuyen.BorderRadius = 25;
            this.btnPhanQuyen.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnPhanQuyen.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnPhanQuyen.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            this.btnPhanQuyen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPhanQuyen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPhanQuyen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPhanQuyen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPhanQuyen.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            this.btnPhanQuyen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPhanQuyen.ForeColor = System.Drawing.Color.White;
            this.btnPhanQuyen.Location = new System.Drawing.Point(-1, 622);
            this.btnPhanQuyen.Name = "btnPhanQuyen";
            this.btnPhanQuyen.Size = new System.Drawing.Size(178, 50);
            this.btnPhanQuyen.TabIndex = 11;
            this.btnPhanQuyen.Text = "Phân quyền";
            this.btnPhanQuyen.UseTransparentBackground = true;
            this.btnPhanQuyen.CheckedChanged += new System.EventHandler(this.guna2Button1_CheckedChanged);
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.Transparent;
            this.btnThongKe.BorderRadius = 25;
            this.btnThongKe.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnThongKe.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnThongKe.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            this.btnThongKe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThongKe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThongKe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThongKe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThongKe.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Location = new System.Drawing.Point(-1, 557);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(178, 50);
            this.btnThongKe.TabIndex = 10;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseTransparentBackground = true;
            this.btnThongKe.CheckedChanged += new System.EventHandler(this.guna2Button1_CheckedChanged);
            // 
            // btnKhuyenMai
            // 
            this.btnKhuyenMai.BackColor = System.Drawing.Color.Transparent;
            this.btnKhuyenMai.BorderRadius = 25;
            this.btnKhuyenMai.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnKhuyenMai.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnKhuyenMai.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            this.btnKhuyenMai.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKhuyenMai.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKhuyenMai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKhuyenMai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKhuyenMai.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            this.btnKhuyenMai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnKhuyenMai.ForeColor = System.Drawing.Color.White;
            this.btnKhuyenMai.Location = new System.Drawing.Point(-1, 492);
            this.btnKhuyenMai.Name = "btnKhuyenMai";
            this.btnKhuyenMai.Size = new System.Drawing.Size(178, 50);
            this.btnKhuyenMai.TabIndex = 9;
            this.btnKhuyenMai.Text = "Khuyến mãi";
            this.btnKhuyenMai.UseTransparentBackground = true;
            this.btnKhuyenMai.CheckedChanged += new System.EventHandler(this.guna2Button1_CheckedChanged);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.btnNhanVien.BorderRadius = 25;
            this.btnNhanVien.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnNhanVien.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnNhanVien.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            this.btnNhanVien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNhanVien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNhanVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNhanVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNhanVien.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            this.btnNhanVien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnNhanVien.Location = new System.Drawing.Point(-1, 427);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(178, 50);
            this.btnNhanVien.TabIndex = 8;
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.UseTransparentBackground = true;
            this.btnNhanVien.CheckedChanged += new System.EventHandler(this.guna2Button1_CheckedChanged);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.BackColor = System.Drawing.Color.Transparent;
            this.btnKhachHang.BorderRadius = 25;
            this.btnKhachHang.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnKhachHang.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnKhachHang.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            this.btnKhachHang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKhachHang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKhachHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKhachHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKhachHang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            this.btnKhachHang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnKhachHang.ForeColor = System.Drawing.Color.White;
            this.btnKhachHang.Location = new System.Drawing.Point(-1, 362);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(178, 50);
            this.btnKhachHang.TabIndex = 7;
            this.btnKhachHang.Text = "Khách hàng";
            this.btnKhachHang.UseTransparentBackground = true;
            this.btnKhachHang.CheckedChanged += new System.EventHandler(this.guna2Button1_CheckedChanged);
            // 
            // btnSanPham
            // 
            this.btnSanPham.BackColor = System.Drawing.Color.Transparent;
            this.btnSanPham.BorderRadius = 25;
            this.btnSanPham.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSanPham.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnSanPham.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            this.btnSanPham.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSanPham.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSanPham.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSanPham.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSanPham.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            this.btnSanPham.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSanPham.ForeColor = System.Drawing.Color.White;
            this.btnSanPham.Location = new System.Drawing.Point(-1, 297);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Size = new System.Drawing.Size(178, 50);
            this.btnSanPham.TabIndex = 6;
            this.btnSanPham.Text = "Sản phẩm";
            this.btnSanPham.UseTransparentBackground = true;
            this.btnSanPham.CheckedChanged += new System.EventHandler(this.guna2Button1_CheckedChanged);
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.BackColor = System.Drawing.Color.Transparent;
            this.btnNhapHang.BorderRadius = 25;
            this.btnNhapHang.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnNhapHang.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnNhapHang.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            this.btnNhapHang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNhapHang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNhapHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNhapHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNhapHang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            this.btnNhapHang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNhapHang.ForeColor = System.Drawing.Color.White;
            this.btnNhapHang.Location = new System.Drawing.Point(-1, 232);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(178, 50);
            this.btnNhapHang.TabIndex = 5;
            this.btnNhapHang.Text = "Nhập hàng";
            this.btnNhapHang.UseTransparentBackground = true;
            this.btnNhapHang.CheckedChanged += new System.EventHandler(this.guna2Button1_CheckedChanged);
            this.btnNhapHang.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // btnBanHang
            // 
            this.btnBanHang.BackColor = System.Drawing.Color.Transparent;
            this.btnBanHang.BorderRadius = 25;
            this.btnBanHang.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnBanHang.Checked = true;
            this.btnBanHang.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnBanHang.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            this.btnBanHang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBanHang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBanHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBanHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBanHang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            this.btnBanHang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBanHang.ForeColor = System.Drawing.Color.White;
            this.btnBanHang.Location = new System.Drawing.Point(-1, 167);
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Size = new System.Drawing.Size(178, 50);
            this.btnBanHang.TabIndex = 4;
            this.btnBanHang.Text = "Bán hàng";
            this.btnBanHang.UseTransparentBackground = true;
            this.btnBanHang.CheckedChanged += new System.EventHandler(this.guna2Button1_CheckedChanged);
            this.btnBanHang.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // imgSlide
            // 
            this.imgSlide.BackColor = System.Drawing.Color.Transparent;
            this.imgSlide.Image = ((System.Drawing.Image)(resources.GetObject("imgSlide.Image")));
            this.imgSlide.ImageRotate = 0F;
            this.imgSlide.Location = new System.Drawing.Point(121, 119);
            this.imgSlide.Name = "imgSlide";
            this.imgSlide.Size = new System.Drawing.Size(50, 146);
            this.imgSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSlide.TabIndex = 3;
            this.imgSlide.TabStop = false;
            this.imgSlide.UseTransparentBackground = true;
            this.imgSlide.Click += new System.EventHandler(this.guna2PictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "C# Project";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(180, 87);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.White;
            this.guna2Panel2.BorderColor = System.Drawing.Color.White;
            this.guna2Panel2.BorderRadius = 20;
            this.guna2Panel2.Controls.Add(this.uC_KhuyenMai1);
            this.guna2Panel2.Controls.Add(this.uC_SanPham1);
            this.guna2Panel2.Controls.Add(this.uC_ThongKe1);
            this.guna2Panel2.Controls.Add(this.uC_PhanQuyen1);
            this.guna2Panel2.Controls.Add(this.uC_NhanVien1);
            this.guna2Panel2.Controls.Add(this.uC_NhapHang1);
            this.guna2Panel2.Controls.Add(this.uC_KhachHang1);
            this.guna2Panel2.Controls.Add(this.uC_BanHang1);
            this.guna2Panel2.CustomBorderColor = System.Drawing.Color.White;
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.FillColor = System.Drawing.Color.White;
            this.guna2Panel2.ForeColor = System.Drawing.Color.White;
            this.guna2Panel2.Location = new System.Drawing.Point(160, 0);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.guna2Panel2.Size = new System.Drawing.Size(1222, 753);
            this.guna2Panel2.TabIndex = 1;
            // 
            // uC_KhuyenMai1
            // 
            this.uC_KhuyenMai1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_KhuyenMai1.Location = new System.Drawing.Point(10, 10);
            this.uC_KhuyenMai1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.uC_KhuyenMai1.Name = "uC_KhuyenMai1";
            this.uC_KhuyenMai1.Size = new System.Drawing.Size(1202, 733);
            this.uC_KhuyenMai1.TabIndex = 7;
            // 
            // uC_SanPham1
            // 
            this.uC_SanPham1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_SanPham1.Location = new System.Drawing.Point(10, 10);
            this.uC_SanPham1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.uC_SanPham1.Name = "uC_SanPham1";
            this.uC_SanPham1.Size = new System.Drawing.Size(1202, 733);
            this.uC_SanPham1.TabIndex = 6;
            // 
            // uC_ThongKe1
            // 
            this.uC_ThongKe1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_ThongKe1.Location = new System.Drawing.Point(10, 10);
            this.uC_ThongKe1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.uC_ThongKe1.Name = "uC_ThongKe1";
            this.uC_ThongKe1.Size = new System.Drawing.Size(1202, 733);
            this.uC_ThongKe1.TabIndex = 5;
            // 
            // uC_PhanQuyen1
            // 
            this.uC_PhanQuyen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_PhanQuyen1.Location = new System.Drawing.Point(10, 10);
            this.uC_PhanQuyen1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.uC_PhanQuyen1.Name = "uC_PhanQuyen1";
            this.uC_PhanQuyen1.Size = new System.Drawing.Size(1202, 733);
            this.uC_PhanQuyen1.TabIndex = 4;
            // 
            // uC_NhanVien1
            // 
            this.uC_NhanVien1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_NhanVien1.Location = new System.Drawing.Point(10, 10);
            this.uC_NhanVien1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.uC_NhanVien1.Name = "uC_NhanVien1";
            this.uC_NhanVien1.Size = new System.Drawing.Size(1202, 733);
            this.uC_NhanVien1.TabIndex = 3;
            // 
            // uC_NhapHang1
            // 
            this.uC_NhapHang1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_NhapHang1.Location = new System.Drawing.Point(10, 10);
            this.uC_NhapHang1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.uC_NhapHang1.Name = "uC_NhapHang1";
            this.uC_NhapHang1.Size = new System.Drawing.Size(1202, 733);
            this.uC_NhapHang1.TabIndex = 2;
            // 
            // uC_KhachHang1
            // 
            this.uC_KhachHang1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_KhachHang1.Location = new System.Drawing.Point(10, 10);
            this.uC_KhachHang1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.uC_KhachHang1.Name = "uC_KhachHang1";
            this.uC_KhachHang1.Size = new System.Drawing.Size(1202, 733);
            this.uC_KhachHang1.TabIndex = 1;
            // 
            // uC_BanHang1
            // 
            this.uC_BanHang1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_BanHang1.Location = new System.Drawing.Point(10, 10);
            this.uC_BanHang1.Name = "uC_BanHang1";
            this.uC_BanHang1.Size = new System.Drawing.Size(1202, 733);
            this.uC_BanHang1.TabIndex = 0;
            this.uC_BanHang1.Load += new System.EventHandler(this.uC_BanHang1_Load);
            // 
            // HomeGUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HomeGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OUR STORE";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSlide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox imgSlide;
        private Guna.UI2.WinForms.Guna2Button btnPhanQuyen;
        private Guna.UI2.WinForms.Guna2Button btnThongKe;
        private Guna.UI2.WinForms.Guna2Button btnKhuyenMai;
        private Guna.UI2.WinForms.Guna2Button btnNhanVien;
        private Guna.UI2.WinForms.Guna2Button btnKhachHang;
        private Guna.UI2.WinForms.Guna2Button btnSanPham;
        private Guna.UI2.WinForms.Guna2Button btnNhapHang;
        private Guna.UI2.WinForms.Guna2Button btnBanHang;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private UserControls.UC_BanHang uC_BanHang1;
        private UserControls.UC_KhuyenMai uC_KhuyenMai1;
        private UserControls.UC_SanPham uC_SanPham1;
        private UserControls.UC_ThongKe uC_ThongKe1;
        private UserControls.UC_PhanQuyen uC_PhanQuyen1;
        private UserControls.UC_NhanVien uC_NhanVien1;
        private UserControls.UC_NhapHang uC_NhapHang1;
        private UserControls.UC_KhachHang uC_KhachHang1;
    }
}