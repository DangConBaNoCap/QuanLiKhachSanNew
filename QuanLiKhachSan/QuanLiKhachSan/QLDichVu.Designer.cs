namespace QuanLiKhachSan
{
    partial class QLDichVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLDichVu));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiThemKH = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSuaKH = new DevExpress.XtraBars.BarButtonItem();
            this.bbiXoaKH = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.grdDV = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDV)).BeginInit();
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
            this.ribbonControl1.Size = new System.Drawing.Size(699, 142);
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // bbiThemKH
            // 
            this.bbiThemKH.Caption = "Thêm Dịch Vụ";
            this.bbiThemKH.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiThemKH.Glyph")));
            this.bbiThemKH.Id = 1;
            this.bbiThemKH.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiThemKH.LargeGlyph")));
            this.bbiThemKH.Name = "bbiThemKH";
            this.bbiThemKH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiThemKH_ItemClick);
            // 
            // bbiSuaKH
            // 
            this.bbiSuaKH.Caption = "Sửa Dịch Vụ";
            this.bbiSuaKH.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiSuaKH.Glyph")));
            this.bbiSuaKH.Id = 2;
            this.bbiSuaKH.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiSuaKH.LargeGlyph")));
            this.bbiSuaKH.Name = "bbiSuaKH";
            this.bbiSuaKH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSuaKH_ItemClick);
            // 
            // bbiXoaKH
            // 
            this.bbiXoaKH.Caption = "Xóa";
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
            this.ribbonPage1.Text = "Dịch Vụ";
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
            // grdDV
            // 
            this.grdDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDV.Location = new System.Drawing.Point(0, 142);
            this.grdDV.MainView = this.gridView1;
            this.grdDV.MenuManager = this.ribbonControl1;
            this.grdDV.Name = "grdDV";
            this.grdDV.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1});
            this.grdDV.Size = new System.Drawing.Size(699, 215);
            this.grdDV.TabIndex = 2;
            this.grdDV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grdDV.Click += new System.EventHandler(this.QLDichVu_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaDV,
            this.TenDV,
            this.GiaDV});
            this.gridView1.GridControl = this.grdDV;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsSelection.CheckBoxSelectorColumnWidth = 35;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // MaDV
            // 
            this.MaDV.Caption = "Mã Dịch Vụ";
            this.MaDV.FieldName = "MaDV";
            this.MaDV.Name = "MaDV";
            this.MaDV.Visible = true;
            this.MaDV.VisibleIndex = 1;
            // 
            // TenDV
            // 
            this.TenDV.Caption = "Dịch Vụ";
            this.TenDV.FieldName = "TenDV";
            this.TenDV.Name = "TenDV";
            this.TenDV.Visible = true;
            this.TenDV.VisibleIndex = 2;
            this.TenDV.Width = 207;
            // 
            // GiaDV
            // 
            this.GiaDV.Caption = "Giá Dịch Vụ";
            this.GiaDV.FieldName = "GiaDV";
            this.GiaDV.Name = "GiaDV";
            this.GiaDV.Visible = true;
            this.GiaDV.VisibleIndex = 3;
            this.GiaDV.Width = 225;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemComboBox1.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // QLDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 357);
            this.Controls.Add(this.grdDV);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "QLDichVu";
            this.Text = "Quản Lí Dịch Vụ";
            this.Load += new System.EventHandler(this.QLDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem bbiThemKH;
        private DevExpress.XtraBars.BarButtonItem bbiSuaKH;
        private DevExpress.XtraBars.BarButtonItem bbiXoaKH;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl grdDV;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaDV;
        private DevExpress.XtraGrid.Columns.GridColumn TenDV;
        private DevExpress.XtraGrid.Columns.GridColumn GiaDV;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
    }
}