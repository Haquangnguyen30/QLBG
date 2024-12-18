﻿namespace GUI.UserControls
{
    partial class UC_KhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.tbSdt = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbTenKh = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbMaKh = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbTenKh = new System.Windows.Forms.Label();
            this.lbSdt = new System.Windows.Forms.Label();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.tblKh = new System.Windows.Forms.DataGridView();
            this.cotMaKh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cotTenKh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cotSdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox2.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblKh)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(47, 37);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(333, 68);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Kiếm";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(8, 22);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(292, 36);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderRadius = 10;
            this.guna2GroupBox1.Controls.Add(this.tbSdt);
            this.guna2GroupBox1.Controls.Add(this.tbTenKh);
            this.guna2GroupBox1.Controls.Add(this.tbMaKh);
            this.guna2GroupBox1.Controls.Add(this.lbTenKh);
            this.guna2GroupBox1.Controls.Add(this.lbSdt);
            this.guna2GroupBox1.Controls.Add(this.guna2Button2);
            this.guna2GroupBox1.Controls.Add(this.guna2Button1);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel10);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(809, 126);
            this.guna2GroupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(741, 495);
            this.guna2GroupBox1.TabIndex = 2;
            this.guna2GroupBox1.Text = "Chỉnh sửa thông tin khách hàng";
            // 
            // tbSdt
            // 
            this.tbSdt.BackColor = System.Drawing.Color.Transparent;
            this.tbSdt.BorderRadius = 10;
            this.tbSdt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSdt.DefaultText = "";
            this.tbSdt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSdt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSdt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSdt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSdt.Enabled = false;
            this.tbSdt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSdt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbSdt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSdt.Location = new System.Drawing.Point(349, 249);
            this.tbSdt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSdt.Name = "tbSdt";
            this.tbSdt.PasswordChar = '\0';
            this.tbSdt.PlaceholderText = "";
            this.tbSdt.SelectedText = "";
            this.tbSdt.Size = new System.Drawing.Size(229, 48);
            this.tbSdt.TabIndex = 125;
            // 
            // tbTenKh
            // 
            this.tbTenKh.BackColor = System.Drawing.Color.Transparent;
            this.tbTenKh.BorderRadius = 10;
            this.tbTenKh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTenKh.DefaultText = "";
            this.tbTenKh.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbTenKh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbTenKh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTenKh.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTenKh.Enabled = false;
            this.tbTenKh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTenKh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbTenKh.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTenKh.Location = new System.Drawing.Point(349, 171);
            this.tbTenKh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTenKh.Name = "tbTenKh";
            this.tbTenKh.PasswordChar = '\0';
            this.tbTenKh.PlaceholderText = "";
            this.tbTenKh.SelectedText = "";
            this.tbTenKh.Size = new System.Drawing.Size(229, 48);
            this.tbTenKh.TabIndex = 124;
            // 
            // tbMaKh
            // 
            this.tbMaKh.BackColor = System.Drawing.Color.Transparent;
            this.tbMaKh.BorderRadius = 10;
            this.tbMaKh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMaKh.DefaultText = "";
            this.tbMaKh.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbMaKh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbMaKh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMaKh.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMaKh.Enabled = false;
            this.tbMaKh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbMaKh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbMaKh.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbMaKh.Location = new System.Drawing.Point(349, 87);
            this.tbMaKh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbMaKh.Name = "tbMaKh";
            this.tbMaKh.PasswordChar = '\0';
            this.tbMaKh.PlaceholderText = "";
            this.tbMaKh.SelectedText = "";
            this.tbMaKh.Size = new System.Drawing.Size(229, 48);
            this.tbMaKh.TabIndex = 123;
            // 
            // lbTenKh
            // 
            this.lbTenKh.AutoSize = true;
            this.lbTenKh.Location = new System.Drawing.Point(373, 203);
            this.lbTenKh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTenKh.Name = "lbTenKh";
            this.lbTenKh.Size = new System.Drawing.Size(0, 20);
            this.lbTenKh.TabIndex = 122;
            // 
            // lbSdt
            // 
            this.lbSdt.AutoSize = true;
            this.lbSdt.Location = new System.Drawing.Point(373, 281);
            this.lbSdt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSdt.Name = "lbSdt";
            this.lbSdt.Size = new System.Drawing.Size(0, 20);
            this.lbSdt.TabIndex = 121;
            // 
            // guna2Button2
            // 
            this.guna2Button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderRadius = 20;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            this.guna2Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(379, 367);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(132, 41);
            this.guna2Button2.TabIndex = 120;
            this.guna2Button2.Text = "Lưu";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click_1);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 20;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            this.guna2Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(173, 367);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(132, 41);
            this.guna2Button1.TabIndex = 119;
            this.guna2Button1.Text = "Sửa";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(164, 176);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(138, 22);
            this.guna2HtmlLabel2.TabIndex = 118;
            this.guna2HtmlLabel2.Text = "Tên Khách Hàng :";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(181, 254);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(118, 22);
            this.guna2HtmlLabel1.TabIndex = 117;
            this.guna2HtmlLabel1.Text = "Số Điện Thoại :";
            // 
            // guna2HtmlLabel10
            // 
            this.guna2HtmlLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel10.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel10.Location = new System.Drawing.Point(171, 96);
            this.guna2HtmlLabel10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            this.guna2HtmlLabel10.Size = new System.Drawing.Size(129, 22);
            this.guna2HtmlLabel10.TabIndex = 116;
            this.guna2HtmlLabel10.Text = "Mã Khách hàng :";
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BorderRadius = 10;
            this.guna2GroupBox2.Controls.Add(this.tblKh);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox2.Location = new System.Drawing.Point(47, 126);
            this.guna2GroupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(691, 495);
            this.guna2GroupBox2.TabIndex = 3;
            this.guna2GroupBox2.Text = "Danh sách khách hàng";
            // 
            // tblKh
            // 
            this.tblKh.AllowUserToAddRows = false;
            this.tblKh.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.tblKh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblKh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cotMaKh,
            this.cotTenKh,
            this.cotSdt});
            this.tblKh.Location = new System.Drawing.Point(1, 44);
            this.tblKh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tblKh.Name = "tblKh";
            this.tblKh.RowHeadersVisible = false;
            this.tblKh.RowHeadersWidth = 51;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            this.tblKh.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tblKh.Size = new System.Drawing.Size(689, 447);
            this.tblKh.TabIndex = 6;
            this.tblKh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblKh_CellClick);
            // 
            // cotMaKh
            // 
            this.cotMaKh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cotMaKh.DataPropertyName = "maKH";
            this.cotMaKh.HeaderText = "Mã Khách Hàng";
            this.cotMaKh.MinimumWidth = 6;
            this.cotMaKh.Name = "cotMaKh";
            // 
            // cotTenKh
            // 
            this.cotTenKh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cotTenKh.DataPropertyName = "tenKH";
            this.cotTenKh.HeaderText = "Họ Tên ";
            this.cotTenKh.MinimumWidth = 6;
            this.cotTenKh.Name = "cotTenKh";
            // 
            // cotSdt
            // 
            this.cotSdt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cotSdt.DataPropertyName = "sdt";
            this.cotSdt.HeaderText = "Số Điện Thoại";
            this.cotSdt.MinimumWidth = 6;
            this.cotSdt.Name = "cotSdt";
            // 
            // guna2Button3
            // 
            this.guna2Button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button3.BorderRadius = 20;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            this.guna2Button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(411, 55);
            this.guna2Button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(132, 41);
            this.guna2Button3.TabIndex = 126;
            this.guna2Button3.Text = "Reload";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // UC_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UC_KhachHang";
            this.Size = new System.Drawing.Size(1600, 927);
            this.Load += new System.EventHandler(this.UC_KhachHang_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.guna2GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblKh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2TextBox tbSdt;
        private Guna.UI2.WinForms.Guna2TextBox tbTenKh;
        private Guna.UI2.WinForms.Guna2TextBox tbMaKh;
        private System.Windows.Forms.Label lbTenKh;
        private System.Windows.Forms.Label lbSdt;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel10;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private System.Windows.Forms.DataGridView tblKh;
        private System.Windows.Forms.DataGridViewTextBoxColumn cotMaKh;
        private System.Windows.Forms.DataGridViewTextBoxColumn cotTenKh;
        private System.Windows.Forms.DataGridViewTextBoxColumn cotSdt;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
    }
}
