namespace QuanLiKhachSan
{
    partial class FrmQuanLiPhong
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTinhtrang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboLoaiphong = new System.Windows.Forms.ComboBox();
            this.txtGiatien = new System.Windows.Forms.TextBox();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolTimMaphong = new System.Windows.Forms.ToolStripTextBox();
            this.toolTimLP = new System.Windows.Forms.ToolStripTextBox();
            this.toolTimGia = new System.Windows.Forms.ToolStripTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.panel4.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTinhtrang);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboLoaiphong);
            this.panel1.Controls.Add(this.txtGiatien);
            this.panel1.Controls.Add(this.txtMaPhong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 85);
            this.panel1.TabIndex = 0;
            // 
            // txtTinhtrang
            // 
            this.txtTinhtrang.Location = new System.Drawing.Point(445, 54);
            this.txtTinhtrang.Name = "txtTinhtrang";
            this.txtTinhtrang.Size = new System.Drawing.Size(152, 20);
            this.txtTinhtrang.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tinh Trang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Giá tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Loại phòng";
            // 
            // cboLoaiphong
            // 
            this.cboLoaiphong.FormattingEnabled = true;
            this.cboLoaiphong.Location = new System.Drawing.Point(445, 12);
            this.cboLoaiphong.Name = "cboLoaiphong";
            this.cboLoaiphong.Size = new System.Drawing.Size(152, 21);
            this.cboLoaiphong.TabIndex = 3;
            // 
            // txtGiatien
            // 
            this.txtGiatien.Location = new System.Drawing.Point(111, 54);
            this.txtGiatien.Name = "txtGiatien";
            this.txtGiatien.Size = new System.Drawing.Size(136, 20);
            this.txtGiatien.TabIndex = 1;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(111, 12);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(136, 20);
            this.txtMaPhong.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(739, 223);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvPhong);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 89);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(739, 134);
            this.panel5.TabIndex = 3;
            // 
            // dgvPhong
            // 
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhong.Location = new System.Drawing.Point(0, 0);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.Size = new System.Drawing.Size(739, 134);
            this.dgvPhong.TabIndex = 1;
            this.dgvPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhong_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "MaPhong";
            this.Column1.HeaderText = "Mã phòng";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "MaLoaiPhong";
            this.Column2.HeaderText = "Loại phòng";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "GiaTien";
            this.Column3.HeaderText = "Giá tiền";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "TinhTrang";
            this.Column4.HeaderText = "Tình trạng";
            this.Column4.Name = "Column4";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.toolStrip1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 47);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(739, 42);
            this.panel4.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolTimMaphong,
            this.toolTimLP,
            this.toolTimGia});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(739, 42);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(28, 39);
            this.toolStripLabel1.Text = "Tìm";
            // 
            // toolTimMaphong
            // 
            this.toolTimMaphong.Name = "toolTimMaphong";
            this.toolTimMaphong.Size = new System.Drawing.Size(175, 42);

            this.toolTimMaphong.TextChanged += new System.EventHandler(this.toolTimMaphong_TextChanged);
            // 
            // toolTimLP
            // 
            this.toolTimLP.Name = "toolTimLP";
            this.toolTimLP.Size = new System.Drawing.Size(170, 42);
            this.toolTimLP.TextChanged += new System.EventHandler(this.toolTimLP_TextChanged);
            // 
            // toolTimGia
            // 
            this.toolTimGia.Name = "toolTimGia";
            this.toolTimGia.Size = new System.Drawing.Size(177, 42);
            this.toolTimGia.TextChanged += new System.EventHandler(this.toolTimGia_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnXoa);
            this.panel3.Controls.Add(this.btnSua);
            this.panel3.Controls.Add(this.btnLuu);
            this.panel3.Controls.Add(this.btnThem);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(739, 47);
            this.panel3.TabIndex = 0;
            // 
            // btnXoa
            // 
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnXoa.Location = new System.Drawing.Point(233, 0);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(79, 47);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSua.Location = new System.Drawing.Point(150, 0);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(83, 47);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLuu.Location = new System.Drawing.Point(75, 0);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 47);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnThem.Location = new System.Drawing.Point(0, 0);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 47);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // FrmQuanLiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 308);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmQuanLiPhong";
            this.Text = "FrmQuanLiPhong";
            this.Load += new System.EventHandler(this.FrmQuanLiPhong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtTinhtrang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboLoaiphong;
        private System.Windows.Forms.TextBox txtGiatien;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolTimMaphong;
        private System.Windows.Forms.ToolStripTextBox toolTimLP;
        private System.Windows.Forms.ToolStripTextBox toolTimGia;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}