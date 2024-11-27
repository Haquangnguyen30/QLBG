namespace GUI.UserControls
{
    partial class UC_NhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cotMaNv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cotTenNv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cotGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cotSdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cotDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cotChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cotNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cotXoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnNhap = new Guna.UI2.WinForms.Guna2Button();
            this.btnXuat = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cotMaNv,
            this.cotTenNv,
            this.cotGioiTinh,
            this.cotSdt,
            this.cotDiaChi,
            this.cotChucVu,
            this.cotNgaySinh,
            this.cotXoa});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Location = new System.Drawing.Point(6, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Size = new System.Drawing.Size(926, 450);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // cotMaNv
            // 
            this.cotMaNv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cotMaNv.DataPropertyName = "maNV";
            this.cotMaNv.HeaderText = "Mã Nhân viên";
            this.cotMaNv.MinimumWidth = 6;
            this.cotMaNv.Name = "cotMaNv";
            this.cotMaNv.ReadOnly = true;
            // 
            // cotTenNv
            // 
            this.cotTenNv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cotTenNv.DataPropertyName = "tenNV";
            this.cotTenNv.HeaderText = "Họ Tên Nhân Viên";
            this.cotTenNv.MinimumWidth = 6;
            this.cotTenNv.Name = "cotTenNv";
            this.cotTenNv.ReadOnly = true;
            // 
            // cotGioiTinh
            // 
            this.cotGioiTinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cotGioiTinh.DataPropertyName = "gioiTinh";
            this.cotGioiTinh.HeaderText = "Giới Tính";
            this.cotGioiTinh.MinimumWidth = 6;
            this.cotGioiTinh.Name = "cotGioiTinh";
            this.cotGioiTinh.ReadOnly = true;
            // 
            // cotSdt
            // 
            this.cotSdt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cotSdt.DataPropertyName = "sdt";
            this.cotSdt.HeaderText = "Số Điện Thoại";
            this.cotSdt.MinimumWidth = 6;
            this.cotSdt.Name = "cotSdt";
            this.cotSdt.ReadOnly = true;
            // 
            // cotDiaChi
            // 
            this.cotDiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cotDiaChi.DataPropertyName = "diaChi";
            this.cotDiaChi.HeaderText = "Địa chỉ";
            this.cotDiaChi.MinimumWidth = 6;
            this.cotDiaChi.Name = "cotDiaChi";
            this.cotDiaChi.ReadOnly = true;
            // 
            // cotChucVu
            // 
            this.cotChucVu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cotChucVu.DataPropertyName = "chucVu";
            this.cotChucVu.HeaderText = "Chức Vụ";
            this.cotChucVu.MinimumWidth = 6;
            this.cotChucVu.Name = "cotChucVu";
            this.cotChucVu.ReadOnly = true;
            // 
            // cotNgaySinh
            // 
            this.cotNgaySinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cotNgaySinh.DataPropertyName = "ngaySinh";
            this.cotNgaySinh.HeaderText = "Ngày Sinh";
            this.cotNgaySinh.MinimumWidth = 6;
            this.cotNgaySinh.Name = "cotNgaySinh";
            this.cotNgaySinh.ReadOnly = true;
            // 
            // cotXoa
            // 
            this.cotXoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cotXoa.HeaderText = "Xóa";
            this.cotXoa.MinimumWidth = 6;
            this.cotXoa.Name = "cotXoa";
            this.cotXoa.ReadOnly = true;
            this.cotXoa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cotXoa.Width = 35;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(51, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(938, 481);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách nhân viên";
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.BorderRadius = 20;
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(1025, 106);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(127, 42);
            this.btnThem.TabIndex = 62;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(51, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 39);
            this.groupBox2.TabIndex = 63;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Kiếm";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 14);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnNhap
            // 
            this.btnNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNhap.BackColor = System.Drawing.Color.Transparent;
            this.btnNhap.BorderRadius = 20;
            this.btnNhap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNhap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNhap.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            this.btnNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btnNhap.ForeColor = System.Drawing.Color.White;
            this.btnNhap.Location = new System.Drawing.Point(1025, 191);
            this.btnNhap.Margin = new System.Windows.Forms.Padding(2);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(127, 44);
            this.btnNhap.TabIndex = 64;
            this.btnNhap.Text = "Nhập file excel";
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // btnXuat
            // 
            this.btnXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXuat.BackColor = System.Drawing.Color.Transparent;
            this.btnXuat.BorderRadius = 20;
            this.btnXuat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXuat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXuat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXuat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXuat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            this.btnXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btnXuat.ForeColor = System.Drawing.Color.White;
            this.btnXuat.Location = new System.Drawing.Point(1025, 282);
            this.btnXuat.Margin = new System.Windows.Forms.Padding(2);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(127, 42);
            this.btnXuat.TabIndex = 65;
            this.btnXuat.Text = "Xuất file excel";
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // UC_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Name = "UC_NhanVien";
            this.Size = new System.Drawing.Size(1200, 753);
            this.Load += new System.EventHandler(this.UC_NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cotMaNv;
        private System.Windows.Forms.DataGridViewTextBoxColumn cotTenNv;
        private System.Windows.Forms.DataGridViewTextBoxColumn cotGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn cotSdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn cotDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn cotChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cotNgaySinh;
        private System.Windows.Forms.DataGridViewButtonColumn cotXoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private Guna.UI2.WinForms.Guna2Button btnNhap;
        private Guna.UI2.WinForms.Guna2Button btnXuat;
    }
}
