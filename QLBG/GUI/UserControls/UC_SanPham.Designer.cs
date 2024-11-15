namespace GUI.UserControls
{
    partial class UC_SanPham
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sanPhamDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grid_SanPham = new Guna.UI2.WinForms.Guna2DataGridView();
            this.maSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imgDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.giaNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maMauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makichCoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhTrangDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamDTOBindingSource)).BeginInit();
            this.guna2TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_SanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // sanPhamDTOBindingSource
            // 
            this.sanPhamDTOBindingSource.DataSource = typeof(DTO.SanPhamDTO);
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Controls.Add(this.tabPage1);
            this.guna2TabControl1.Controls.Add(this.tabPage2);
            this.guna2TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.Location = new System.Drawing.Point(0, 0);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(1600, 927);
            this.guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            this.guna2TabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(50)))), ((int)(((byte)(120)))));
            this.guna2TabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(50)))), ((int)(((byte)(120)))));
            this.guna2TabControl1.TabButtonSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.TabIndex = 1;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            this.guna2TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grid_SanPham);
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1592, 879);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sản Phẩm";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1592, 879);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Các Bảng Liên Quan";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // grid_SanPham
            // 
            this.grid_SanPham.AllowUserToResizeColumns = false;
            this.grid_SanPham.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.grid_SanPham.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_SanPham.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_SanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_SanPham.ColumnHeadersHeight = 35;
            this.grid_SanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grid_SanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSPDataGridViewTextBoxColumn,
            this.tenSPDataGridViewTextBoxColumn,
            this.giaBanDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.imgDataGridViewImageColumn,
            this.giaNhapDataGridViewTextBoxColumn,
            this.maLoaiDataGridViewTextBoxColumn,
            this.maMauDataGridViewTextBoxColumn,
            this.makichCoDataGridViewTextBoxColumn,
            this.tinhTrangDataGridViewCheckBoxColumn});
            this.grid_SanPham.DataSource = this.sanPhamDTOBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_SanPham.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid_SanPham.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grid_SanPham.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grid_SanPham.Location = new System.Drawing.Point(3, 456);
            this.grid_SanPham.MultiSelect = false;
            this.grid_SanPham.Name = "grid_SanPham";
            this.grid_SanPham.RowHeadersVisible = false;
            this.grid_SanPham.RowHeadersWidth = 51;
            this.grid_SanPham.RowTemplate.Height = 35;
            this.grid_SanPham.Size = new System.Drawing.Size(1586, 420);
            this.grid_SanPham.TabIndex = 1;
            this.grid_SanPham.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grid_SanPham.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grid_SanPham.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grid_SanPham.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grid_SanPham.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grid_SanPham.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grid_SanPham.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grid_SanPham.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.grid_SanPham.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grid_SanPham.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid_SanPham.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grid_SanPham.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grid_SanPham.ThemeStyle.HeaderStyle.Height = 35;
            this.grid_SanPham.ThemeStyle.ReadOnly = false;
            this.grid_SanPham.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grid_SanPham.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grid_SanPham.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid_SanPham.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grid_SanPham.ThemeStyle.RowsStyle.Height = 35;
            this.grid_SanPham.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grid_SanPham.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // maSPDataGridViewTextBoxColumn
            // 
            this.maSPDataGridViewTextBoxColumn.DataPropertyName = "maSP";
            this.maSPDataGridViewTextBoxColumn.HeaderText = "Mã Sản Phẩm";
            this.maSPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maSPDataGridViewTextBoxColumn.Name = "maSPDataGridViewTextBoxColumn";
            this.maSPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenSPDataGridViewTextBoxColumn
            // 
            this.tenSPDataGridViewTextBoxColumn.DataPropertyName = "tenSP";
            this.tenSPDataGridViewTextBoxColumn.HeaderText = "Tên Sản Phẩm";
            this.tenSPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenSPDataGridViewTextBoxColumn.Name = "tenSPDataGridViewTextBoxColumn";
            this.tenSPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // giaBanDataGridViewTextBoxColumn
            // 
            this.giaBanDataGridViewTextBoxColumn.DataPropertyName = "giaBan";
            this.giaBanDataGridViewTextBoxColumn.HeaderText = "Giá Bán";
            this.giaBanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giaBanDataGridViewTextBoxColumn.Name = "giaBanDataGridViewTextBoxColumn";
            this.giaBanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "soLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "Số Lượng";
            this.soLuongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            this.soLuongDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imgDataGridViewImageColumn
            // 
            this.imgDataGridViewImageColumn.DataPropertyName = "img";
            this.imgDataGridViewImageColumn.HeaderText = "Hình Ảnh";
            this.imgDataGridViewImageColumn.MinimumWidth = 6;
            this.imgDataGridViewImageColumn.Name = "imgDataGridViewImageColumn";
            this.imgDataGridViewImageColumn.ReadOnly = true;
            // 
            // giaNhapDataGridViewTextBoxColumn
            // 
            this.giaNhapDataGridViewTextBoxColumn.DataPropertyName = "giaNhap";
            this.giaNhapDataGridViewTextBoxColumn.HeaderText = "Giá Nhập";
            this.giaNhapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giaNhapDataGridViewTextBoxColumn.Name = "giaNhapDataGridViewTextBoxColumn";
            this.giaNhapDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maLoaiDataGridViewTextBoxColumn
            // 
            this.maLoaiDataGridViewTextBoxColumn.DataPropertyName = "maLoai";
            this.maLoaiDataGridViewTextBoxColumn.HeaderText = "Mã Loại";
            this.maLoaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maLoaiDataGridViewTextBoxColumn.Name = "maLoaiDataGridViewTextBoxColumn";
            this.maLoaiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maMauDataGridViewTextBoxColumn
            // 
            this.maMauDataGridViewTextBoxColumn.DataPropertyName = "mau";
            this.maMauDataGridViewTextBoxColumn.HeaderText = "Mã Màu";
            this.maMauDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maMauDataGridViewTextBoxColumn.Name = "maMauDataGridViewTextBoxColumn";
            this.maMauDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // makichCoDataGridViewTextBoxColumn
            // 
            this.makichCoDataGridViewTextBoxColumn.DataPropertyName = "makichCo";
            this.makichCoDataGridViewTextBoxColumn.HeaderText = "Mã Kích Cỡ";
            this.makichCoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.makichCoDataGridViewTextBoxColumn.Name = "makichCoDataGridViewTextBoxColumn";
            this.makichCoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tinhTrangDataGridViewCheckBoxColumn
            // 
            this.tinhTrangDataGridViewCheckBoxColumn.DataPropertyName = "tinhTrang";
            this.tinhTrangDataGridViewCheckBoxColumn.HeaderText = "Tình Trạng";
            this.tinhTrangDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.tinhTrangDataGridViewCheckBoxColumn.Name = "tinhTrangDataGridViewCheckBoxColumn";
            // 
            // UC_SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2TabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_SanPham";
            this.Size = new System.Drawing.Size(1600, 927);
            this.Load += new System.EventHandler(this.UC_SanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamDTOBindingSource)).EndInit();
            this.guna2TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_SanPham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource sanPhamDTOBindingSource;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Guna.UI2.WinForms.Guna2DataGridView grid_SanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imgDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makichCoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn tinhTrangDataGridViewCheckBoxColumn;
    }
}
