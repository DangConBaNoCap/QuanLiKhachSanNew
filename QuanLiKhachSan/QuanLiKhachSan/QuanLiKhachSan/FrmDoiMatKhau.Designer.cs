namespace QuanLiKhachSan
{
    partial class FrmDoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoiMatKhau));
            this.lbKT = new System.Windows.Forms.Label();
            this.btnXacNhan = new DevExpress.XtraEditors.SimpleButton();
            this.txtNhapLaiMatKhau = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMatKhauCu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenTaiKhoan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // lbKT
            // 
            this.lbKT.AutoSize = true;
            this.lbKT.ForeColor = System.Drawing.Color.Red;
            this.lbKT.Location = new System.Drawing.Point(140, 214);
            this.lbKT.Name = "lbKT";
            this.lbKT.Size = new System.Drawing.Size(0, 13);
            this.lbKT.TabIndex = 19;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnXacNhan.Image = ((System.Drawing.Image)(resources.GetObject("btnXacNhan.Image")));
            this.btnXacNhan.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnXacNhan.Location = new System.Drawing.Point(47, 230);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(116, 39);
            this.btnXacNhan.TabIndex = 18;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // txtNhapLaiMatKhau
            // 
            this.txtNhapLaiMatKhau.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapLaiMatKhau.Location = new System.Drawing.Point(130, 178);
            this.txtNhapLaiMatKhau.Name = "txtNhapLaiMatKhau";
            this.txtNhapLaiMatKhau.Size = new System.Drawing.Size(185, 25);
            this.txtNhapLaiMatKhau.TabIndex = 17;
            this.txtNhapLaiMatKhau.UseSystemPasswordChar = true;
            this.txtNhapLaiMatKhau.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNhapLaiMatKhau_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nhập lại mật khẩu";
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhauMoi.Location = new System.Drawing.Point(130, 132);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.Size = new System.Drawing.Size(185, 25);
            this.txtMatKhauMoi.TabIndex = 15;
            this.txtMatKhauMoi.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mật khẩu mới";
            // 
            // txtMatKhauCu
            // 
            this.txtMatKhauCu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhauCu.Location = new System.Drawing.Point(130, 84);
            this.txtMatKhauCu.Name = "txtMatKhauCu";
            this.txtMatKhauCu.Size = new System.Drawing.Size(185, 25);
            this.txtMatKhauCu.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mật khẩu cũ";
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(130, 38);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.ReadOnly = true;
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(185, 25);
            this.txtTenTaiKhoan.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tên tài khoản : ";
            // 
            // btnThoat
            // 
            this.btnThoat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnThoat.Location = new System.Drawing.Point(182, 230);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(116, 39);
            this.btnThoat.TabIndex = 20;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FrmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 298);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lbKT);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.txtNhapLaiMatKhau);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMatKhauMoi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMatKhauCu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenTaiKhoan);
            this.Controls.Add(this.label1);
            this.Name = "FrmDoiMatKhau";
            this.Text = "FrmDoiMatKhau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbKT;
        private DevExpress.XtraEditors.SimpleButton btnXacNhan;
        private System.Windows.Forms.TextBox txtNhapLaiMatKhau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMatKhauCu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenTaiKhoan;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
    }
}