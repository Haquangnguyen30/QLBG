namespace GUI.UserControls
{
    partial class UC_PhanQuyen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvPhanQuyen = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblDSSPCN = new System.Windows.Forms.Label();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanQuyen)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel2.AutoScroll = true;
            this.guna2Panel2.BackColor = System.Drawing.Color.White;
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Panel2.BorderRadius = 20;
            this.guna2Panel2.Controls.Add(this.dgvPhanQuyen);
            this.guna2Panel2.Controls.Add(this.lblDSSPCN);
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.guna2Panel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.guna2Panel2.Location = new System.Drawing.Point(28, 20);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(3, 20, 3, 2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1541, 724);
            this.guna2Panel2.TabIndex = 7;
            // 
            // dgvPhanQuyen
            // 
            this.dgvPhanQuyen.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvPhanQuyen.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPhanQuyen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPhanQuyen.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhanQuyen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPhanQuyen.ColumnHeadersHeight = 4;
            this.dgvPhanQuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPhanQuyen.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhanQuyen.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPhanQuyen.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPhanQuyen.Location = new System.Drawing.Point(47, 36);
            this.dgvPhanQuyen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPhanQuyen.Name = "dgvPhanQuyen";
            this.dgvPhanQuyen.RowHeadersVisible = false;
            this.dgvPhanQuyen.RowHeadersWidth = 51;
            this.dgvPhanQuyen.RowTemplate.Height = 24;
            this.dgvPhanQuyen.Size = new System.Drawing.Size(1445, 656);
            this.dgvPhanQuyen.TabIndex = 43;
            this.dgvPhanQuyen.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPhanQuyen.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPhanQuyen.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPhanQuyen.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPhanQuyen.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPhanQuyen.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvPhanQuyen.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPhanQuyen.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvPhanQuyen.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvPhanQuyen.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPhanQuyen.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPhanQuyen.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPhanQuyen.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvPhanQuyen.ThemeStyle.ReadOnly = false;
            this.dgvPhanQuyen.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPhanQuyen.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPhanQuyen.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPhanQuyen.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPhanQuyen.ThemeStyle.RowsStyle.Height = 24;
            this.dgvPhanQuyen.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPhanQuyen.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPhanQuyen.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhanQuyen_CellValueChanged);
            this.dgvPhanQuyen.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvPhanQuyen_CurrentCellDirtyStateChanged);
            // 
            // lblDSSPCN
            // 
            this.lblDSSPCN.AutoSize = true;
            this.lblDSSPCN.BackColor = System.Drawing.Color.Transparent;
            this.lblDSSPCN.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold);
            this.lblDSSPCN.ForeColor = System.Drawing.Color.Black;
            this.lblDSSPCN.Location = new System.Drawing.Point(43, 15);
            this.lblDSSPCN.Name = "lblDSSPCN";
            this.lblDSSPCN.Size = new System.Drawing.Size(226, 19);
            this.lblDSSPCN.TabIndex = 23;
            this.lblDSSPCN.Text = "DANH SÁCH PHÂN QUYỀN";
            // 
            // UC_PhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UC_PhanQuyen";
            this.Size = new System.Drawing.Size(1600, 927);
            this.Load += new System.EventHandler(this.UC_PhanQuyen_Load);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanQuyen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPhanQuyen;
        private System.Windows.Forms.Label lblDSSPCN;
    }
}
