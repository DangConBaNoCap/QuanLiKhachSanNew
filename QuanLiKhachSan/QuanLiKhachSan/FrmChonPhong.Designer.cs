namespace QuanLiKhachSan
{
    partial class FrmChonPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChonPhong));
            this.clbBan = new System.Windows.Forms.CheckedListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXacNhan = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clbBan
            // 
            this.clbBan.Dock = System.Windows.Forms.DockStyle.Top;
            this.clbBan.FormattingEnabled = true;
            this.clbBan.Location = new System.Drawing.Point(0, 0);
            this.clbBan.Name = "clbBan";
            this.clbBan.Size = new System.Drawing.Size(288, 259);
            this.clbBan.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXacNhan);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 259);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 43);
            this.panel1.TabIndex = 2;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnXacNhan.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnXacNhan.Image = ((System.Drawing.Image)(resources.GetObject("btnXacNhan.Image")));
            this.btnXacNhan.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnXacNhan.Location = new System.Drawing.Point(213, 0);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(75, 43);
            this.btnXacNhan.TabIndex = 1;
            this.btnXacNhan.ToolTip = "Xác nhận";
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnHuy.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnHuy.Location = new System.Drawing.Point(0, 0);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 43);
            this.btnHuy.TabIndex = 0;
            this.btnHuy.ToolTip = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // FrmChonPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 302);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.clbBan);
            this.Name = "FrmChonPhong";
            this.Text = "FrmChonPhong";
            this.Load += new System.EventHandler(this.FrmChonPhong_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbBan;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnXacNhan;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
    }
}