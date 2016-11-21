namespace QuanLiKhachSan.Quan_Li_Khach
{
    partial class KhachHangListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhachHangListView));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiThemKH = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSuaKH = new DevExpress.XtraBars.BarButtonItem();
            this.bbiXoaKH = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gcListKhachHang = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HoTenKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcListKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.bbiThemKH,
            this.bbiSuaKH,
            this.bbiXoaKH});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(900, 144);
            // 
            // bbiThemKH
            // 
            this.bbiThemKH.Caption = "Thêm Khách Hàng";
            this.bbiThemKH.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiThemKH.Glyph")));
            this.bbiThemKH.Id = 1;
            this.bbiThemKH.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiThemKH.LargeGlyph")));
            this.bbiThemKH.Name = "bbiThemKH";
            this.bbiThemKH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiThemKH_ItemClick);
            // 
            // bbiSuaKH
            // 
            this.bbiSuaKH.Caption = "Sửa Khách hHàng";
            this.bbiSuaKH.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiSuaKH.Glyph")));
            this.bbiSuaKH.Id = 2;
            this.bbiSuaKH.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiSuaKH.LargeGlyph")));
            this.bbiSuaKH.Name = "bbiSuaKH";
            this.bbiSuaKH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSuaKH_ItemClick);
            // 
            // bbiXoaKH
            // 
            this.bbiXoaKH.Caption = "Xóa Khách Hàng";
            this.bbiXoaKH.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiXoaKH.Glyph")));
            this.bbiXoaKH.Id = 3;
            this.bbiXoaKH.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiXoaKH.LargeGlyph")));
            this.bbiXoaKH.Name = "bbiXoaKH";
            this.bbiXoaKH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiXoaKH_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Khách Hàng";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiThemKH);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiSuaKH);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiXoaKH);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Thao Tác";
            // 
            // gcListKhachHang
            // 
            this.gcListKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcListKhachHang.Location = new System.Drawing.Point(0, 144);
            this.gcListKhachHang.MainView = this.gridView1;
            this.gcListKhachHang.MenuManager = this.ribbonControl1;
            this.gcListKhachHang.Name = "gcListKhachHang";
            this.gcListKhachHang.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1});
            this.gcListKhachHang.Size = new System.Drawing.Size(900, 427);
            this.gcListKhachHang.TabIndex = 1;
            this.gcListKhachHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaKH,
            this.HoTenKH,
            this.DiaChi,
            this.DienThoai,
            this.GioiTinh,
            this.CMND});
            this.gridView1.GridControl = this.gcListKhachHang;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsSelection.CheckBoxSelectorColumnWidth = 35;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView1_SelectionChanged);
            // 
            // MaKH
            // 
            this.MaKH.Caption = "gridColumn1";
            this.MaKH.FieldName = "MaKH";
            this.MaKH.Name = "MaKH";
            // 
            // HoTenKH
            // 
            this.HoTenKH.Caption = "Họ Tên";
            this.HoTenKH.FieldName = "HoTenKH";
            this.HoTenKH.Name = "HoTenKH";
            this.HoTenKH.Visible = true;
            this.HoTenKH.VisibleIndex = 1;
            this.HoTenKH.Width = 207;
            // 
            // DiaChi
            // 
            this.DiaChi.Caption = "Địa Chỉ";
            this.DiaChi.FieldName = "DiaChi";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Visible = true;
            this.DiaChi.VisibleIndex = 3;
            this.DiaChi.Width = 225;
            // 
            // DienThoai
            // 
            this.DienThoai.Caption = "Điện Thoại";
            this.DienThoai.FieldName = "DienThoai";
            this.DienThoai.Name = "DienThoai";
            this.DienThoai.Visible = true;
            this.DienThoai.VisibleIndex = 4;
            this.DienThoai.Width = 150;
            // 
            // GioiTinh
            // 
            this.GioiTinh.Caption = "Giới Tính";
            this.GioiTinh.ColumnEdit = this.repositoryItemComboBox1;
            this.GioiTinh.FieldName = "GioiTinh";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Visible = true;
            this.GioiTinh.VisibleIndex = 2;
            this.GioiTinh.Width = 121;
            // 
            // CMND
            // 
            this.CMND.Caption = "CMND";
            this.CMND.FieldName = "CMND";
            this.CMND.Name = "CMND";
            this.CMND.Visible = true;
            this.CMND.VisibleIndex = 5;
            this.CMND.Width = 179;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // KhachHangListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 571);
            this.Controls.Add(this.gcListKhachHang);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "KhachHangListView";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Khách Hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcListKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bbiThemKH;
        private DevExpress.XtraBars.BarButtonItem bbiSuaKH;
        private DevExpress.XtraBars.BarButtonItem bbiXoaKH;
        private DevExpress.XtraGrid.GridControl gcListKhachHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaKH;
        private DevExpress.XtraGrid.Columns.GridColumn HoTenKH;
        private DevExpress.XtraGrid.Columns.GridColumn DiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn DienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn GioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn CMND;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
    }
}