namespace QuanLiKhachSan
{
    partial class FrmSuaHoaDonDV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSuaHoaDonDV));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.lsvDSDichVuPhong = new System.Windows.Forms.ListView();
            this.TenDVu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DonGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ThanhTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnHoanTat = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenDV = new System.Windows.Forms.TextBox();
            this.lsvDSDichVu = new System.Windows.Forms.ListView();
            this.TenDV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DonG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.txtTimDichVu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.lsvDSDichVuPhong);
            this.splitContainerControl1.Panel1.Controls.Add(this.panel4);
            this.splitContainerControl1.Panel1.Controls.Add(this.panel3);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.lsvDSDichVu);
            this.splitContainerControl1.Panel2.Controls.Add(this.btnTimKiem);
            this.splitContainerControl1.Panel2.Controls.Add(this.txtTimDichVu);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(711, 377);
            this.splitContainerControl1.SplitterPosition = 437;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // lsvDSDichVuPhong
            // 
            this.lsvDSDichVuPhong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TenDVu,
            this.SoLuong,
            this.DonGia,
            this.ThanhTien});
            this.lsvDSDichVuPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvDSDichVuPhong.FullRowSelect = true;
            this.lsvDSDichVuPhong.GridLines = true;
            this.lsvDSDichVuPhong.Location = new System.Drawing.Point(0, 117);
            this.lsvDSDichVuPhong.MultiSelect = false;
            this.lsvDSDichVuPhong.Name = "lsvDSDichVuPhong";
            this.lsvDSDichVuPhong.Size = new System.Drawing.Size(437, 260);
            this.lsvDSDichVuPhong.TabIndex = 3;
            this.lsvDSDichVuPhong.UseCompatibleStateImageBehavior = false;
            this.lsvDSDichVuPhong.View = System.Windows.Forms.View.Details;
            this.lsvDSDichVuPhong.Click += new System.EventHandler(this.lsvDSDichVuPhong_Click);
            // 
            // TenDVu
            // 
            this.TenDVu.Text = "Tên Dịch Vụ";
            this.TenDVu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TenDVu.Width = 127;
            // 
            // SoLuong
            // 
            this.SoLuong.Text = "Số lượng";
            this.SoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SoLuong.Width = 95;
            // 
            // DonGia
            // 
            this.DonGia.Text = "Đơn giá";
            this.DonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DonGia.Width = 97;
            // 
            // ThanhTien
            // 
            this.ThanhTien.Text = "Thành Tiền";
            this.ThanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ThanhTien.Width = 113;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnHoanTat);
            this.panel4.Controls.Add(this.btnLuu);
            this.panel4.Controls.Add(this.btnSua);
            this.panel4.Controls.Add(this.btnXoa);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 79);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(437, 38);
            this.panel4.TabIndex = 2;
            // 
            // btnHoanTat
            // 
            this.btnHoanTat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnHoanTat.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHoanTat.Image = ((System.Drawing.Image)(resources.GetObject("btnHoanTat.Image")));
            this.btnHoanTat.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnHoanTat.Location = new System.Drawing.Point(326, 0);
            this.btnHoanTat.Name = "btnHoanTat";
            this.btnHoanTat.Size = new System.Drawing.Size(110, 38);
            this.btnHoanTat.TabIndex = 3;
            this.btnHoanTat.ToolTip = "Hoàn Tất";
            this.btnHoanTat.Click += new System.EventHandler(this.btnHoanTat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnLuu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnLuu.Location = new System.Drawing.Point(218, 0);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(108, 38);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.ToolTip = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnSua.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnSua.Location = new System.Drawing.Point(108, 0);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(110, 38);
            this.btnSua.TabIndex = 1;
            this.btnSua.ToolTip = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnXoa.Location = new System.Drawing.Point(0, 0);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(108, 38);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.ToolTip = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtDonGia);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.cboNhanVien);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnThem);
            this.panel3.Controls.Add(this.txtSoLuong);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtTenDV);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(437, 79);
            this.panel3.TabIndex = 1;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(319, 46);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(101, 21);
            this.txtDonGia.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Đơn Giá";
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(94, 46);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(138, 21);
            this.cboNhanVien.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên Nhân Viên";
            // 
            // btnThem
            // 
            this.btnThem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnThem.Location = new System.Drawing.Point(377, 10);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(43, 23);
            this.btnThem.TabIndex = 4;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(319, 12);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(52, 21);
            this.txtSoLuong.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số lượng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dịch Vụ";
            // 
            // txtTenDV
            // 
            this.txtTenDV.Location = new System.Drawing.Point(94, 12);
            this.txtTenDV.Name = "txtTenDV";
            this.txtTenDV.Size = new System.Drawing.Size(138, 21);
            this.txtTenDV.TabIndex = 0;
            // 
            // lsvDSDichVu
            // 
            this.lsvDSDichVu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TenDV,
            this.DonG});
            this.lsvDSDichVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvDSDichVu.FullRowSelect = true;
            this.lsvDSDichVu.Location = new System.Drawing.Point(0, 62);
            this.lsvDSDichVu.MultiSelect = false;
            this.lsvDSDichVu.Name = "lsvDSDichVu";
            this.lsvDSDichVu.Size = new System.Drawing.Size(269, 315);
            this.lsvDSDichVu.TabIndex = 5;
            this.lsvDSDichVu.UseCompatibleStateImageBehavior = false;
            this.lsvDSDichVu.View = System.Windows.Forms.View.Details;
            this.lsvDSDichVu.Click += new System.EventHandler(this.lsvDSDichVu_Click);
            // 
            // TenDV
            // 
            this.TenDV.Text = "Dịch Vụ";
            this.TenDV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TenDV.Width = 151;
            // 
            // DonG
            // 
            this.DonG.Text = "Đơn Giá";
            this.DonG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DonG.Width = 114;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnTimKiem.Location = new System.Drawing.Point(0, 30);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(269, 32);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimDichVu
            // 
            this.txtTimDichVu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtTimDichVu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTimDichVu.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTimDichVu.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimDichVu.Location = new System.Drawing.Point(0, 0);
            this.txtTimDichVu.Name = "txtTimDichVu";
            this.txtTimDichVu.Size = new System.Drawing.Size(269, 30);
            this.txtTimDichVu.TabIndex = 3;
            this.txtTimDichVu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyTimKiem_Click);
            // 
            // FrmSuaHoaDonDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 377);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "FrmSuaHoaDonDV";
            this.Text = "FrmSuaHoaDonDV";
            this.Load += new System.EventHandler(this.FrmSuaHoaDonDV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.ListView lsvDSDichVuPhong;
        private System.Windows.Forms.ColumnHeader TenDVu;
        private System.Windows.Forms.ColumnHeader SoLuong;
        private System.Windows.Forms.ColumnHeader DonGia;
        private System.Windows.Forms.ColumnHeader ThanhTien;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenDV;
        private System.Windows.Forms.ListView lsvDSDichVu;
        private System.Windows.Forms.ColumnHeader TenDV;
        private System.Windows.Forms.ColumnHeader DonG;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private System.Windows.Forms.TextBox txtTimDichVu;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btnHoanTat;


    }
}