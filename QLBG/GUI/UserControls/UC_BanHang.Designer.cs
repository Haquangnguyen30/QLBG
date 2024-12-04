using System.Collections.Generic;
using System.IO;
using BLL;
using DTO;
using System.Drawing;
using DocumentFormat.OpenXml.Drawing;
using NPOI.Util;
namespace GUI.UserControls
{
    partial class UC_BanHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_BanHang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tienThua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel9 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.guna2Panel8 = new Guna.UI2.WinForms.Guna2Panel();
            this.cbKhachHang = new System.Windows.Forms.ComboBox();
            this.btnThemKH = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.GioHangPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.GioHangDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnThanhToan = new Guna.UI2.WinForms.Guna2Button();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAddToCart = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel7 = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBoxProduct = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtSoLuong = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.pnlSizes = new System.Windows.Forms.FlowLayoutPanel();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.tenSp = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.reloadbtn = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.guna2Panel10 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel11 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtTotalPage = new System.Windows.Forms.Label();
            this.btnBackPage = new Guna.UI2.WinForms.Guna2Button();
            this.btnNextPage = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCurrentPage = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.tabledulieusp = new System.Windows.Forms.TableLayoutPanel();
            this.pageHD = new System.Windows.Forms.TabPage();
            this.guna2Panel12 = new Guna.UI2.WinForms.Guna2Panel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvCTHD = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkichCo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvHD = new Guna.UI2.WinForms.Guna2DataGridView();
            this.maHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienGiam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienKhachDua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchHD = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBoxKhCoSP = new System.Windows.Forms.PictureBox();
            this.txtKhCoSP = new System.Windows.Forms.Label();
            this.guna2TabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel9.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.guna2Panel8.SuspendLayout();
            this.GioHangPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GioHangDataGridView)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.guna2Panel6.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.guna2Panel10.SuspendLayout();
            this.guna2Panel11.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.pageHD.SuspendLayout();
            this.guna2Panel12.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKhCoSP)).BeginInit();
            this.SuspendLayout();
            // 
            // tienThua
            // 
            this.tienThua.DataPropertyName = "tienThua";
            this.tienThua.HeaderText = "Tiền thừa";
            this.tienThua.MinimumWidth = 6;
            this.tienThua.Name = "tienThua";
            this.tienThua.ReadOnly = true;
            this.tienThua.Width = 125;
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Controls.Add(this.tabPage3);
            this.guna2TabControl1.Controls.Add(this.pageHD);
            this.guna2TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.Location = new System.Drawing.Point(0, 0);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(1200, 753);
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
            this.guna2TabControl1.TabIndex = 2;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            this.guna2TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            this.guna2TabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.tableLayoutPanel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 44);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1192, 705);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Bán Hàng";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 480F));
            this.tableLayoutPanel3.Controls.Add(this.guna2Panel2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.guna2Panel1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1186, 699);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.guna2Panel9);
            this.guna2Panel2.Controls.Add(this.guna2Panel3);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.FillColor = System.Drawing.Color.White;
            this.guna2Panel2.Location = new System.Drawing.Point(709, 3);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(474, 693);
            this.guna2Panel2.TabIndex = 5;
            // 
            // guna2Panel9
            // 
            this.guna2Panel9.AutoScroll = true;
            this.guna2Panel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel9.BorderRadius = 15;
            this.guna2Panel9.Controls.Add(this.guna2Panel4);
            this.guna2Panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel9.FillColor = System.Drawing.Color.White;
            this.guna2Panel9.Location = new System.Drawing.Point(0, 232);
            this.guna2Panel9.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.guna2Panel9.Name = "guna2Panel9";
            this.guna2Panel9.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.guna2Panel9.Size = new System.Drawing.Size(474, 461);
            this.guna2Panel9.TabIndex = 7;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.AutoScroll = true;
            this.guna2Panel4.BackColor = System.Drawing.Color.White;
            this.guna2Panel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Panel4.BorderRadius = 20;
            this.guna2Panel4.Controls.Add(this.tableLayoutPanel2);
            this.guna2Panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Panel4.Location = new System.Drawing.Point(0, 10);
            this.guna2Panel4.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Padding = new System.Windows.Forms.Padding(10);
            this.guna2Panel4.Size = new System.Drawing.Size(474, 451);
            this.guna2Panel4.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.guna2Panel8, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.GioHangPanel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnThanhToan, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblTongTien, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(454, 431);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // guna2Panel8
            // 
            this.guna2Panel8.Controls.Add(this.cbKhachHang);
            this.guna2Panel8.Controls.Add(this.btnThemKH);
            this.guna2Panel8.Controls.Add(this.label2);
            this.guna2Panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel8.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel8.Name = "guna2Panel8";
            this.guna2Panel8.Size = new System.Drawing.Size(448, 44);
            this.guna2Panel8.TabIndex = 17;
            // 
            // cbKhachHang
            // 
            this.cbKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKhachHang.FormattingEnabled = true;
            this.cbKhachHang.ItemHeight = 25;
            this.cbKhachHang.Location = new System.Drawing.Point(140, 8);
            this.cbKhachHang.Name = "cbKhachHang";
            this.cbKhachHang.Size = new System.Drawing.Size(230, 33);
            this.cbKhachHang.TabIndex = 19;
            this.cbKhachHang.SelectedIndexChanged += new System.EventHandler(this.cbKhachHang_SelectedIndexChanged);
            this.cbKhachHang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbKhachHang_KeyDown);
            // 
            // btnThemKH
            // 
            this.btnThemKH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemKH.BackColor = System.Drawing.Color.Transparent;
            this.btnThemKH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            this.btnThemKH.BorderRadius = 10;
            this.btnThemKH.BorderThickness = 2;
            this.btnThemKH.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            this.btnThemKH.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemKH.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemKH.FillColor = System.Drawing.Color.White;
            this.btnThemKH.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            this.btnThemKH.Location = new System.Drawing.Point(405, 3);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(40, 40);
            this.btnThemKH.TabIndex = 18;
            this.btnThemKH.Text = "+";
            this.btnThemKH.TextOffset = new System.Drawing.Point(1, 0);
            this.btnThemKH.Click += new System.EventHandler(this.btnThemKH_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(7, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 15, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "GIỎ HÀNG";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GioHangPanel
            // 
            this.GioHangPanel.AutoScroll = true;
            this.GioHangPanel.BackColor = System.Drawing.Color.Transparent;
            this.GioHangPanel.BorderRadius = 15;
            this.GioHangPanel.Controls.Add(this.GioHangDataGridView);
            this.GioHangPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GioHangPanel.FillColor = System.Drawing.Color.White;
            this.GioHangPanel.Location = new System.Drawing.Point(3, 53);
            this.GioHangPanel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.GioHangPanel.Name = "GioHangPanel";
            this.GioHangPanel.Size = new System.Drawing.Size(448, 278);
            this.GioHangPanel.TabIndex = 6;
            // 
            // GioHangDataGridView
            // 
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.White;
            this.GioHangDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle31;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GioHangDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.GioHangDataGridView.ColumnHeadersHeight = 4;
            this.GioHangDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GioHangDataGridView.DefaultCellStyle = dataGridViewCellStyle33;
            this.GioHangDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GioHangDataGridView.Location = new System.Drawing.Point(3, 3);
            this.GioHangDataGridView.Name = "GioHangDataGridView";
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GioHangDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.GioHangDataGridView.RowHeadersVisible = false;
            this.GioHangDataGridView.RowHeadersWidth = 51;
            this.GioHangDataGridView.RowTemplate.Height = 24;
            this.GioHangDataGridView.Size = new System.Drawing.Size(464, 292);
            this.GioHangDataGridView.TabIndex = 0;
            this.GioHangDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.GioHangDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.GioHangDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.GioHangDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.GioHangDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.GioHangDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.GioHangDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GioHangDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.GioHangDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GioHangDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.GioHangDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.GioHangDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.GioHangDataGridView.ThemeStyle.HeaderStyle.Height = 4;
            this.GioHangDataGridView.ThemeStyle.ReadOnly = false;
            this.GioHangDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.GioHangDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GioHangDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.GioHangDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.GioHangDataGridView.ThemeStyle.RowsStyle.Height = 24;
            this.GioHangDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GioHangDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.GioHangDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GioHangDataGridView_CellDoubleClick);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.Transparent;
            this.btnThanhToan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            this.btnThanhToan.BorderRadius = 5;
            this.btnThanhToan.BorderThickness = 2;
            this.btnThanhToan.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            this.btnThanhToan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhToan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhToan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThanhToan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThanhToan.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnThanhToan.FillColor = System.Drawing.Color.White;
            this.btnThanhToan.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            this.btnThanhToan.Location = new System.Drawing.Point(330, 384);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(121, 44);
            this.btnThanhToan.TabIndex = 6;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.BackColor = System.Drawing.Color.Transparent;
            this.lblTongTien.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.ForeColor = System.Drawing.Color.Black;
            this.lblTongTien.Location = new System.Drawing.Point(10, 351);
            this.lblTongTien.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(231, 25);
            this.lblTongTien.TabIndex = 20;
            this.lblTongTien.Text = "Tổng hoá đơn: 0 VNĐ";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.White;
            this.guna2Panel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Panel3.BorderRadius = 20;
            this.guna2Panel3.Controls.Add(this.btnAddToCart);
            this.guna2Panel3.Controls.Add(this.guna2Panel7);
            this.guna2Panel3.Controls.Add(this.txtSoLuong);
            this.guna2Panel3.Controls.Add(this.pnlSizes);
            this.guna2Panel3.Controls.Add(this.lblProductName);
            this.guna2Panel3.Controls.Add(this.lblStock);
            this.guna2Panel3.Controls.Add(this.tenSp);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Panel3.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.guna2Panel3.Size = new System.Drawing.Size(474, 232);
            this.guna2Panel3.TabIndex = 5;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.Transparent;
            this.btnAddToCart.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            this.btnAddToCart.BorderRadius = 5;
            this.btnAddToCart.BorderThickness = 2;
            this.btnAddToCart.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            this.btnAddToCart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddToCart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddToCart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddToCart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddToCart.FillColor = System.Drawing.Color.White;
            this.btnAddToCart.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            this.btnAddToCart.Location = new System.Drawing.Point(326, 170);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(140, 40);
            this.btnAddToCart.TabIndex = 5;
            this.btnAddToCart.Text = "Thêm vào giỏ";
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // guna2Panel7
            // 
            this.guna2Panel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel7.BorderRadius = 20;
            this.guna2Panel7.Controls.Add(this.pictureBoxProduct);
            this.guna2Panel7.FillColor = System.Drawing.Color.White;
            this.guna2Panel7.Location = new System.Drawing.Point(16, 34);
            this.guna2Panel7.Name = "guna2Panel7";
            this.guna2Panel7.Size = new System.Drawing.Size(160, 178);
            this.guna2Panel7.TabIndex = 2;
            // 
            // pictureBoxProduct
            // 
            this.pictureBoxProduct.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxProduct.FillColor = System.Drawing.Color.Transparent;
            this.pictureBoxProduct.ImageRotate = 0F;
            this.pictureBoxProduct.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxProduct.Name = "pictureBoxProduct";
            this.pictureBoxProduct.Size = new System.Drawing.Size(160, 178);
            this.pictureBoxProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProduct.TabIndex = 1;
            this.pictureBoxProduct.TabStop = false;
            this.pictureBoxProduct.UseTransparentBackground = true;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoLuong.BackColor = System.Drawing.Color.Transparent;
            this.txtSoLuong.BorderRadius = 10;
            this.txtSoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoLuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoLuong.Location = new System.Drawing.Point(184, 170);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoLuong.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(129, 39);
            this.txtSoLuong.TabIndex = 74;
            this.txtSoLuong.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            this.txtSoLuong.UpDownButtonForeColor = System.Drawing.Color.White;
            this.txtSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // pnlSizes
            // 
            this.pnlSizes.BackColor = System.Drawing.Color.LightGray;
            this.pnlSizes.Location = new System.Drawing.Point(182, 86);
            this.pnlSizes.Name = "pnlSizes";
            this.pnlSizes.Size = new System.Drawing.Size(284, 56);
            this.pnlSizes.TabIndex = 17;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.BackColor = System.Drawing.Color.Transparent;
            this.lblProductName.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.ForeColor = System.Drawing.Color.Black;
            this.lblProductName.Location = new System.Drawing.Point(182, 34);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(117, 19);
            this.lblProductName.TabIndex = 16;
            this.lblProductName.Text = "Tên sản phẩm";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.BackColor = System.Drawing.Color.Transparent;
            this.lblStock.Font = new System.Drawing.Font("Century Schoolbook", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.ForeColor = System.Drawing.Color.Black;
            this.lblStock.Location = new System.Drawing.Point(182, 145);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(145, 16);
            this.lblStock.TabIndex = 4;
            this.lblStock.Text = "Số lượng trong kho: ";
            // 
            // tenSp
            // 
            this.tenSp.AutoSize = true;
            this.tenSp.BackColor = System.Drawing.Color.Transparent;
            this.tenSp.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenSp.ForeColor = System.Drawing.Color.Black;
            this.tenSp.Location = new System.Drawing.Point(182, 64);
            this.tenSp.Name = "tenSp";
            this.tenSp.Size = new System.Drawing.Size(47, 19);
            this.tenSp.TabIndex = 3;
            this.tenSp.Text = "SIZE";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.tableLayoutPanel4);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(700, 693);
            this.guna2Panel1.TabIndex = 6;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.guna2Panel6, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.guna2Panel5, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(700, 693);
            this.tableLayoutPanel4.TabIndex = 128;
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.Controls.Add(this.reloadbtn);
            this.guna2Panel6.Controls.Add(this.txtSearch);
            this.guna2Panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel6.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.Size = new System.Drawing.Size(694, 54);
            this.guna2Panel6.TabIndex = 2;
            // 
            // reloadbtn
            // 
            this.reloadbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reloadbtn.BackColor = System.Drawing.Color.Transparent;
            this.reloadbtn.BorderRadius = 20;
            this.reloadbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.reloadbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.reloadbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.reloadbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.reloadbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            this.reloadbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.reloadbtn.ForeColor = System.Drawing.Color.White;
            this.reloadbtn.Location = new System.Drawing.Point(578, 7);
            this.reloadbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reloadbtn.Name = "reloadbtn";
            this.reloadbtn.Size = new System.Drawing.Size(96, 43);
            this.reloadbtn.TabIndex = 127;
            this.reloadbtn.Text = "Reload";
            this.reloadbtn.Click += new System.EventHandler(this.reloadbtn_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSearch.BorderRadius = 20;
            this.txtSearch.BorderThickness = 2;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtSearch.IconLeft")));
            this.txtSearch.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txtSearch.Location = new System.Drawing.Point(15, 5);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(280, 43);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextOffset = new System.Drawing.Point(5, 0);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.AutoScroll = true;
            this.guna2Panel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel5.BorderRadius = 20;
            this.guna2Panel5.Controls.Add(this.tableLayoutPanel5);
            this.guna2Panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel5.FillColor = System.Drawing.Color.White;
            this.guna2Panel5.Location = new System.Drawing.Point(3, 63);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(694, 627);
            this.guna2Panel5.TabIndex = 1;
            this.guna2Panel5.UseTransparentBackground = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.guna2Panel10, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.guna2CustomGradientPanel1, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(694, 627);
            this.tableLayoutPanel5.TabIndex = 23;
            // 
            // guna2Panel10
            // 
            this.guna2Panel10.Controls.Add(this.guna2Panel11);
            this.guna2Panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel10.FillColor = System.Drawing.Color.White;
            this.guna2Panel10.Location = new System.Drawing.Point(0, 572);
            this.guna2Panel10.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Panel10.Name = "guna2Panel10";
            this.guna2Panel10.Size = new System.Drawing.Size(694, 60);
            this.guna2Panel10.TabIndex = 1;
            // 
            // guna2Panel11
            // 
            this.guna2Panel11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel11.BackColor = System.Drawing.Color.White;
            this.guna2Panel11.BorderColor = System.Drawing.Color.White;
            this.guna2Panel11.BorderRadius = 10;
            this.guna2Panel11.BorderThickness = 2;
            this.guna2Panel11.Controls.Add(this.txtTotalPage);
            this.guna2Panel11.Controls.Add(this.btnBackPage);
            this.guna2Panel11.Controls.Add(this.btnNextPage);
            this.guna2Panel11.Controls.Add(this.label4);
            this.guna2Panel11.Controls.Add(this.txtCurrentPage);
            this.guna2Panel11.FillColor = System.Drawing.Color.White;
            this.guna2Panel11.Location = new System.Drawing.Point(519, -1);
            this.guna2Panel11.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Panel11.Name = "guna2Panel11";
            this.guna2Panel11.Size = new System.Drawing.Size(175, 40);
            this.guna2Panel11.TabIndex = 20;
            // 
            // txtTotalPage
            // 
            this.txtTotalPage.AutoSize = true;
            this.txtTotalPage.BackColor = System.Drawing.Color.Transparent;
            this.txtTotalPage.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            this.txtTotalPage.Location = new System.Drawing.Point(109, 10);
            this.txtTotalPage.Name = "txtTotalPage";
            this.txtTotalPage.Size = new System.Drawing.Size(20, 21);
            this.txtTotalPage.TabIndex = 20;
            this.txtTotalPage.Text = "8";
            // 
            // btnBackPage
            // 
            this.btnBackPage.BackColor = System.Drawing.Color.Transparent;
            this.btnBackPage.BorderRadius = 10;
            this.btnBackPage.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            this.btnBackPage.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnBackPage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBackPage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBackPage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBackPage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBackPage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            this.btnBackPage.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackPage.ForeColor = System.Drawing.Color.White;
            this.btnBackPage.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            this.btnBackPage.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnBackPage.Location = new System.Drawing.Point(16, 5);
            this.btnBackPage.Name = "btnBackPage";
            this.btnBackPage.Size = new System.Drawing.Size(30, 30);
            this.btnBackPage.TabIndex = 17;
            this.btnBackPage.Text = "<";
            this.btnBackPage.UseTransparentBackground = true;
            this.btnBackPage.Click += new System.EventHandler(this.btnBackPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.BackColor = System.Drawing.Color.Transparent;
            this.btnNextPage.BorderRadius = 10;
            this.btnNextPage.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            this.btnNextPage.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnNextPage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNextPage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNextPage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNextPage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNextPage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            this.btnNextPage.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextPage.ForeColor = System.Drawing.Color.White;
            this.btnNextPage.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            this.btnNextPage.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnNextPage.Location = new System.Drawing.Point(135, 4);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(30, 30);
            this.btnNextPage.TabIndex = 18;
            this.btnNextPage.Text = ">";
            this.btnNextPage.UseTransparentBackground = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            this.label4.Location = new System.Drawing.Point(88, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "/";
            // 
            // txtCurrentPage
            // 
            this.txtCurrentPage.BorderRadius = 10;
            this.txtCurrentPage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCurrentPage.DefaultText = "";
            this.txtCurrentPage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCurrentPage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCurrentPage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCurrentPage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCurrentPage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCurrentPage.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtCurrentPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            this.txtCurrentPage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCurrentPage.Location = new System.Drawing.Point(52, 5);
            this.txtCurrentPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCurrentPage.Name = "txtCurrentPage";
            this.txtCurrentPage.PasswordChar = '\0';
            this.txtCurrentPage.PlaceholderText = "";
            this.txtCurrentPage.SelectedText = "";
            this.txtCurrentPage.Size = new System.Drawing.Size(30, 30);
            this.txtCurrentPage.TabIndex = 19;
            this.txtCurrentPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCurrentPage_KeyPress);
            this.txtCurrentPage.Leave += new System.EventHandler(this.txtCurrentPage_Leave);
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.txtKhCoSP);
            this.guna2CustomGradientPanel1.Controls.Add(this.pictureBoxKhCoSP);
            this.guna2CustomGradientPanel1.Controls.Add(this.tabledulieusp);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(3, 3);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(688, 566);
            this.guna2CustomGradientPanel1.TabIndex = 21;
            // 
            // tabledulieusp
            // 
            this.tabledulieusp.BackColor = System.Drawing.Color.White;
            this.tabledulieusp.ColumnCount = 3;
            this.tabledulieusp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tabledulieusp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tabledulieusp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tabledulieusp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabledulieusp.Location = new System.Drawing.Point(0, 0);
            this.tabledulieusp.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.tabledulieusp.Name = "tabledulieusp";
            this.tabledulieusp.RowCount = 4;
            this.tabledulieusp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tabledulieusp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tabledulieusp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tabledulieusp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tabledulieusp.Size = new System.Drawing.Size(688, 566);
            this.tabledulieusp.TabIndex = 3;
            // 
            // pageHD
            // 
            this.pageHD.Controls.Add(this.guna2Panel12);
            this.pageHD.Location = new System.Drawing.Point(4, 44);
            this.pageHD.Name = "pageHD";
            this.pageHD.Padding = new System.Windows.Forms.Padding(3);
            this.pageHD.Size = new System.Drawing.Size(1192, 705);
            this.pageHD.TabIndex = 0;
            this.pageHD.Text = "Hoá Đơn";
            this.pageHD.UseVisualStyleBackColor = true;
            // 
            // guna2Panel12
            // 
            this.guna2Panel12.Controls.Add(this.tableLayoutPanel6);
            this.guna2Panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel12.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel12.Name = "guna2Panel12";
            this.guna2Panel12.Size = new System.Drawing.Size(1186, 699);
            this.guna2Panel12.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.guna2GroupBox2, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.guna2GroupBox1, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.searchHD, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1186, 699);
            this.tableLayoutPanel6.TabIndex = 5;
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.Controls.Add(this.dgvCTHD);
            this.guna2GroupBox2.CustomBorderThickness = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.guna2GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox2.Location = new System.Drawing.Point(3, 382);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(1180, 314);
            this.guna2GroupBox2.TabIndex = 4;
            this.guna2GroupBox2.Text = "CHI TIẾT HOÁ ĐƠN";
            // 
            // dgvCTHD
            // 
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.White;
            this.dgvCTHD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle35;
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCTHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle36;
            this.dgvCTHD.ColumnHeadersHeight = 32;
            this.dgvCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.tenkichCo,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle37.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle37.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCTHD.DefaultCellStyle = dataGridViewCellStyle37;
            this.dgvCTHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCTHD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCTHD.Location = new System.Drawing.Point(0, 30);
            this.dgvCTHD.Name = "dgvCTHD";
            this.dgvCTHD.RowHeadersVisible = false;
            this.dgvCTHD.RowHeadersWidth = 51;
            this.dgvCTHD.RowTemplate.Height = 24;
            this.dgvCTHD.Size = new System.Drawing.Size(1180, 284);
            this.dgvCTHD.TabIndex = 3;
            this.dgvCTHD.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCTHD.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCTHD.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCTHD.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCTHD.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCTHD.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvCTHD.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCTHD.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvCTHD.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCTHD.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dgvCTHD.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCTHD.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCTHD.ThemeStyle.HeaderStyle.Height = 32;
            this.dgvCTHD.ThemeStyle.ReadOnly = false;
            this.dgvCTHD.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCTHD.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCTHD.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dgvCTHD.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCTHD.ThemeStyle.RowsStyle.Height = 24;
            this.dgvCTHD.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCTHD.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "maHD";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã HD";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 84;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "maSP";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã SP";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "tenSP";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tên SP";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "mau";
            this.dataGridViewTextBoxColumn4.HeaderText = "Màu";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // tenkichCo
            // 
            this.tenkichCo.DataPropertyName = "kichCo";
            this.tenkichCo.HeaderText = "Kích cỡ";
            this.tenkichCo.MinimumWidth = 6;
            this.tenkichCo.Name = "tenkichCo";
            this.tenkichCo.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "giaBan";
            this.dataGridViewTextBoxColumn5.HeaderText = "Giá bán";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "soLuong";
            this.dataGridViewTextBoxColumn6.HeaderText = "Số lượng";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "thanhTien";
            this.dataGridViewTextBoxColumn7.HeaderText = "Thành tiền";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.dgvHD);
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(3, 63);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(1180, 313);
            this.guna2GroupBox1.TabIndex = 3;
            this.guna2GroupBox1.Text = "DANH SÁCH HOÁ ĐƠN";
            // 
            // dgvHD
            // 
            dataGridViewCellStyle38.BackColor = System.Drawing.Color.White;
            this.dgvHD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle38;
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle39.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle39.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle39;
            this.dgvHD.ColumnHeadersHeight = 32;
            this.dgvHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHD,
            this.maNV,
            this.tenKH,
            this.ngayLap,
            this.tongTien,
            this.tienGiam,
            this.tienKhachDua,
            this.tienThu});
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle40.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle40.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle40.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle40.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle40.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHD.DefaultCellStyle = dataGridViewCellStyle40;
            this.dgvHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHD.Location = new System.Drawing.Point(0, 30);
            this.dgvHD.Name = "dgvHD";
            this.dgvHD.RowHeadersVisible = false;
            this.dgvHD.RowHeadersWidth = 51;
            this.dgvHD.RowTemplate.Height = 24;
            this.dgvHD.Size = new System.Drawing.Size(1180, 283);
            this.dgvHD.TabIndex = 1;
            this.dgvHD.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHD.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvHD.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvHD.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvHD.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvHD.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvHD.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHD.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvHD.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvHD.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dgvHD.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvHD.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvHD.ThemeStyle.HeaderStyle.Height = 32;
            this.dgvHD.ThemeStyle.ReadOnly = false;
            this.dgvHD.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHD.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHD.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dgvHD.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvHD.ThemeStyle.RowsStyle.Height = 24;
            this.dgvHD.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHD.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHD_CellClick);
            // 
            // maHD
            // 
            this.maHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.maHD.DataPropertyName = "maHD";
            this.maHD.HeaderText = "Mã HD";
            this.maHD.MinimumWidth = 6;
            this.maHD.Name = "maHD";
            this.maHD.ReadOnly = true;
            this.maHD.Width = 84;
            // 
            // maNV
            // 
            this.maNV.DataPropertyName = "maNV";
            this.maNV.HeaderText = "Mã NV";
            this.maNV.MinimumWidth = 6;
            this.maNV.Name = "maNV";
            this.maNV.ReadOnly = true;
            // 
            // tenKH
            // 
            this.tenKH.DataPropertyName = "tenKH";
            this.tenKH.HeaderText = "Tên KH";
            this.tenKH.MinimumWidth = 6;
            this.tenKH.Name = "tenKH";
            this.tenKH.ReadOnly = true;
            // 
            // ngayLap
            // 
            this.ngayLap.DataPropertyName = "ngayLap";
            this.ngayLap.HeaderText = "Ngày lập";
            this.ngayLap.MinimumWidth = 6;
            this.ngayLap.Name = "ngayLap";
            this.ngayLap.ReadOnly = true;
            // 
            // tongTien
            // 
            this.tongTien.DataPropertyName = "tongTien";
            this.tongTien.HeaderText = "Tổng tiền";
            this.tongTien.MinimumWidth = 6;
            this.tongTien.Name = "tongTien";
            this.tongTien.ReadOnly = true;
            // 
            // tienGiam
            // 
            this.tienGiam.DataPropertyName = "tienGiam";
            this.tienGiam.HeaderText = "Tiền giảm";
            this.tienGiam.MinimumWidth = 6;
            this.tienGiam.Name = "tienGiam";
            this.tienGiam.ReadOnly = true;
            // 
            // tienKhachDua
            // 
            this.tienKhachDua.DataPropertyName = "tienKhachDua";
            this.tienKhachDua.HeaderText = "Tiền khách đưa";
            this.tienKhachDua.MinimumWidth = 6;
            this.tienKhachDua.Name = "tienKhachDua";
            this.tienKhachDua.ReadOnly = true;
            // 
            // tienThu
            // 
            this.tienThu.DataPropertyName = "tienThua";
            this.tienThu.HeaderText = "Tiền thừa";
            this.tienThu.MinimumWidth = 6;
            this.tienThu.Name = "tienThu";
            // 
            // searchHD
            // 
            this.searchHD.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.searchHD.BorderRadius = 20;
            this.searchHD.BorderThickness = 2;
            this.searchHD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchHD.DefaultText = "";
            this.searchHD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchHD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchHD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchHD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchHD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchHD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchHD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchHD.IconLeft = ((System.Drawing.Image)(resources.GetObject("searchHD.IconLeft")));
            this.searchHD.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.searchHD.Location = new System.Drawing.Point(4, 6);
            this.searchHD.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.searchHD.Name = "searchHD";
            this.searchHD.PasswordChar = '\0';
            this.searchHD.PlaceholderText = "";
            this.searchHD.SelectedText = "";
            this.searchHD.Size = new System.Drawing.Size(280, 43);
            this.searchHD.TabIndex = 1;
            this.searchHD.TextOffset = new System.Drawing.Point(5, 0);
            this.searchHD.TextChanged += new System.EventHandler(this.searchHD_TextChanged);
            // 
            // pictureBoxKhCoSP
            // 
            this.pictureBoxKhCoSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxKhCoSP.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxKhCoSP.Image")));
            this.pictureBoxKhCoSP.Location = new System.Drawing.Point(227, 190);
            this.pictureBoxKhCoSP.Name = "pictureBoxKhCoSP";
            this.pictureBoxKhCoSP.Size = new System.Drawing.Size(257, 240);
            this.pictureBoxKhCoSP.TabIndex = 8;
            this.pictureBoxKhCoSP.TabStop = false;
            // 
            // txtKhCoSP
            // 
            this.txtKhCoSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKhCoSP.AutoSize = true;
            this.txtKhCoSP.BackColor = System.Drawing.Color.Transparent;
            this.txtKhCoSP.Font = new System.Drawing.Font("Century", 12.2F, System.Drawing.FontStyle.Bold);
            this.txtKhCoSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            this.txtKhCoSP.Location = new System.Drawing.Point(209, 150);
            this.txtKhCoSP.Name = "txtKhCoSP";
            this.txtKhCoSP.Size = new System.Drawing.Size(292, 25);
            this.txtKhCoSP.TabIndex = 7;
            this.txtKhCoSP.Text = "Không tìm thấy sản phẩm";
            this.txtKhCoSP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UC_BanHang
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2TabControl1);
            this.Name = "UC_BanHang";
            this.Size = new System.Drawing.Size(1200, 753);
            this.guna2TabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel9.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.guna2Panel8.ResumeLayout(false);
            this.guna2Panel8.PerformLayout();
            this.GioHangPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GioHangDataGridView)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.guna2Panel6.ResumeLayout(false);
            this.guna2Panel5.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.guna2Panel10.ResumeLayout(false);
            this.guna2Panel11.ResumeLayout(false);
            this.guna2Panel11.PerformLayout();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.pageHD.ResumeLayout(false);
            this.guna2Panel12.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.guna2GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKhCoSP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn tienThua;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage pageHD;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel9;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel8;
        private System.Windows.Forms.ComboBox cbKhachHang;
        private Guna.UI2.WinForms.Guna2Button btnThemKH;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel GioHangPanel;
        private Guna.UI2.WinForms.Guna2DataGridView GioHangDataGridView;
        private Guna.UI2.WinForms.Guna2Button btnThanhToan;
        private System.Windows.Forms.Label lblTongTien;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2NumericUpDown txtSoLuong;
        private System.Windows.Forms.FlowLayoutPanel pnlSizes;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblStock;
        private Guna.UI2.WinForms.Guna2Button btnAddToCart;
        private System.Windows.Forms.Label tenSp;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel7;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxProduct;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.TableLayoutPanel tabledulieusp;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel10;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel11;
        private Guna.UI2.WinForms.Guna2Button btnBackPage;
        private Guna.UI2.WinForms.Guna2Button btnNextPage;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtCurrentPage;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private Guna.UI2.WinForms.Guna2Button reloadbtn;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel12;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCTHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkichCo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvHD;
        private Guna.UI2.WinForms.Guna2TextBox searchHD;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienGiam;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienKhachDua;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienThu;
        private System.Windows.Forms.Label txtTotalPage;
        private System.Windows.Forms.Label txtKhCoSP;
        private System.Windows.Forms.PictureBox pictureBoxKhCoSP;
    }
}
