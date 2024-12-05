using System.Drawing;
namespace GUI.UserControls
{
    public partial class UC_ComponentSP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_ComponentSP));
            this.imgSp = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.mauSp = new System.Windows.Forms.Label();
            this.btnViewDetails = new Guna.UI2.WinForms.Guna2CircleButton();
            this.giaBanSP = new System.Windows.Forms.Label();
            this.tenSP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgSp)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgSp
            // 
            this.imgSp.BackColor = System.Drawing.Color.Transparent;
            this.imgSp.FillColor = System.Drawing.Color.Transparent;
            this.imgSp.Image = ((System.Drawing.Image)(resources.GetObject("imgSp.Image")));
            this.imgSp.ImageRotate = 0F;
            this.imgSp.Location = new System.Drawing.Point(0, 0);
            this.imgSp.Name = "imgSp";
            this.imgSp.Size = new System.Drawing.Size(101, 100);
            this.imgSp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSp.TabIndex = 0;
            this.imgSp.TabStop = false;
            this.imgSp.UseTransparentBackground = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.Controls.Add(this.btnViewDetails);
            this.guna2Panel1.Controls.Add(this.mauSp);
            this.guna2Panel1.Controls.Add(this.giaBanSP);
            this.guna2Panel1.Controls.Add(this.tenSP);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(17)))), ((int)(((byte)(132)))));
            this.guna2Panel1.Location = new System.Drawing.Point(40, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(180, 100);
            this.guna2Panel1.TabIndex = 1;
            // 
            // mauSp
            // 
            this.mauSp.AutoSize = true;
            this.mauSp.BackColor = System.Drawing.Color.Transparent;
            this.mauSp.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mauSp.ForeColor = System.Drawing.Color.White;
            this.mauSp.Location = new System.Drawing.Point(61, 67);
            this.mauSp.Name = "mauSp";
            this.mauSp.Size = new System.Drawing.Size(89, 17);
            this.mauSp.TabIndex = 3;
            this.mauSp.Text = "3 Màu, 4 Size";
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.BackColor = System.Drawing.Color.Transparent;
            this.btnViewDetails.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewDetails.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewDetails.FillColor = System.Drawing.Color.White;
            this.btnViewDetails.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnViewDetails.ForeColor = System.Drawing.Color.White;
            this.btnViewDetails.Image = ((System.Drawing.Image)(resources.GetObject("btnViewDetails.Image")));
            this.btnViewDetails.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnViewDetails.ImageOffset = new System.Drawing.Point(-5, 0);
            this.btnViewDetails.ImageSize = new System.Drawing.Size(15, 15);
            this.btnViewDetails.Location = new System.Drawing.Point(145, 62);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnViewDetails.Size = new System.Drawing.Size(25, 25);
            this.btnViewDetails.TabIndex = 2;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // giaBanSP
            // 
            this.giaBanSP.AutoSize = true;
            this.giaBanSP.BackColor = System.Drawing.Color.Transparent;
            this.giaBanSP.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giaBanSP.ForeColor = System.Drawing.Color.White;
            this.giaBanSP.Location = new System.Drawing.Point(61, 40);
            this.giaBanSP.Name = "giaBanSP";
            this.giaBanSP.Size = new System.Drawing.Size(87, 17);
            this.giaBanSP.TabIndex = 1;
            this.giaBanSP.Text = "800.000 VNĐ";
            this.giaBanSP.Click += new System.EventHandler(this.label1_Click);
            // 
            // tenSP
            // 
            this.tenSP.AutoSize = true;
            this.tenSP.BackColor = System.Drawing.Color.Transparent;
            this.tenSP.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenSP.ForeColor = System.Drawing.Color.White;
            this.tenSP.Location = new System.Drawing.Point(61, 12);
            this.tenSP.Name = "tenSP";
            this.tenSP.Size = new System.Drawing.Size(142, 18);
            this.tenSP.TabIndex = 0;
            this.tenSP.Text = "Giày Jordan One";
            this.tenSP.Click += new System.EventHandler(this.tenSp_Click);
            // 
            // UC_ComponentSP
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.imgSp);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "UC_ComponentSP";
            this.Size = new System.Drawing.Size(220, 100);
            ((System.ComponentModel.ISupportInitialize)(this.imgSp)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox imgSp;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label tenSP;
        private Guna.UI2.WinForms.Guna2CircleButton btnViewDetails;
        private System.Windows.Forms.Label giaBanSP;
        private System.Windows.Forms.Label mauSp;
    }
}
