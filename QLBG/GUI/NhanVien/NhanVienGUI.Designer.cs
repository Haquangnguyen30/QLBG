namespace GUI.NhanVien
{
    partial class NhanVienGUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cotMaNv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cotTenNv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cotGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cotSdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cotDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cotChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cotNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cotXoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(136, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 22);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tìm kiếm";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1056, 84);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(209, 454);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "THÊM";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 53);
            this.button2.TabIndex = 1;
            this.button2.Text = "NHẬP FILE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 121);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 53);
            this.button3.TabIndex = 2;
            this.button3.Text = "XUẤT FILE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(42, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 454);
            this.panel1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
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
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1008, 454);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick_1);
            // 
            // cotMaNv
            // 
            this.cotMaNv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cotMaNv.DataPropertyName = "maNV";
            this.cotMaNv.HeaderText = "Mã Nhân viên";
            this.cotMaNv.MinimumWidth = 6;
            this.cotMaNv.Name = "cotMaNv";
            // 
            // cotTenNv
            // 
            this.cotTenNv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cotTenNv.DataPropertyName = "tenNV";
            this.cotTenNv.HeaderText = "Họ Tên Nhân Viên";
            this.cotTenNv.MinimumWidth = 6;
            this.cotTenNv.Name = "cotTenNv";
            // 
            // cotGioiTinh
            // 
            this.cotGioiTinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cotGioiTinh.DataPropertyName = "gioiTinh";
            this.cotGioiTinh.HeaderText = "Giới Tính";
            this.cotGioiTinh.MinimumWidth = 6;
            this.cotGioiTinh.Name = "cotGioiTinh";
            // 
            // cotSdt
            // 
            this.cotSdt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cotSdt.DataPropertyName = "sdt";
            this.cotSdt.HeaderText = "Số Điện Thoại";
            this.cotSdt.MinimumWidth = 6;
            this.cotSdt.Name = "cotSdt";
            // 
            // cotDiaChi
            // 
            this.cotDiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cotDiaChi.DataPropertyName = "diaChi";
            this.cotDiaChi.HeaderText = "Địa chỉ";
            this.cotDiaChi.MinimumWidth = 6;
            this.cotDiaChi.Name = "cotDiaChi";
            // 
            // cotChucVu
            // 
            this.cotChucVu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cotChucVu.DataPropertyName = "chucVu";
            this.cotChucVu.HeaderText = "Chức Vụ";
            this.cotChucVu.MinimumWidth = 6;
            this.cotChucVu.Name = "cotChucVu";
            // 
            // cotNgaySinh
            // 
            this.cotNgaySinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cotNgaySinh.DataPropertyName = "ngaySinh";
            this.cotNgaySinh.HeaderText = "Ngày Sinh";
            this.cotNgaySinh.MinimumWidth = 6;
            this.cotNgaySinh.Name = "cotNgaySinh";
            // 
            // cotXoa
            // 
            this.cotXoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cotXoa.HeaderText = "Xóa";
            this.cotXoa.MinimumWidth = 6;
            this.cotXoa.Name = "cotXoa";
            this.cotXoa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cotXoa.Width = 39;
            // 
            // NhanVienGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 590);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "NhanVienGUI";
            this.Text = "ThongTinNhanVienGUI";
            this.Load += new System.EventHandler(this.NhanVienGUI_Load_1);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cotMaNv;
        private System.Windows.Forms.DataGridViewTextBoxColumn cotTenNv;
        private System.Windows.Forms.DataGridViewTextBoxColumn cotGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn cotSdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn cotDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn cotChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cotNgaySinh;
        private System.Windows.Forms.DataGridViewButtonColumn cotXoa;
    }
}