
namespace RestaurantManagement
{
    partial class frmChiTietBan
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiTietBan));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gcBan = new DevExpress.XtraGrid.GridControl();
            this.bdsBan = new System.Windows.Forms.BindingSource(this.components);
            this.gvBan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcPhong = new DevExpress.XtraGrid.GridControl();
            this.bdsPhong = new System.Windows.Forms.BindingSource(this.components);
            this.gvPhong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colmaPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltenPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsCTBan = new System.Windows.Forms.BindingSource(this.components);
            this.gcCTBan = new DevExpress.XtraGrid.GridControl();
            this.gvCTBan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btn_Them = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Xoa = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Reload = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Thoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btn_CapNhat = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Luu = new DevExpress.XtraBars.BarButtonItem();
            this.btn_PhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.colmaBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltenBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsoGhe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmaphong1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltenphong1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmaban1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltenban1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsoGhe1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTBan)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gcBan);
            this.panel1.Controls.Add(this.gcPhong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 754);
            this.panel1.TabIndex = 0;
            // 
            // gcBan
            // 
            this.gcBan.DataSource = this.bdsBan;
            this.gcBan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gcBan.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcBan.Location = new System.Drawing.Point(0, 393);
            this.gcBan.MainView = this.gvBan;
            this.gcBan.Margin = new System.Windows.Forms.Padding(4);
            this.gcBan.Name = "gcBan";
            this.gcBan.Size = new System.Drawing.Size(827, 361);
            this.gcBan.TabIndex = 1;
            this.gcBan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBan});
            // 
            // bdsBan
            // 
            this.bdsBan.DataSource = typeof(RestaurantManagement.Model.BanModel);
            // 
            // gvBan
            // 
            this.gvBan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmaBan,
            this.coltenBan,
            this.colsoGhe});
            this.gvBan.DetailHeight = 437;
            this.gvBan.GridControl = this.gcBan;
            this.gvBan.Name = "gvBan";
            this.gvBan.OptionsBehavior.Editable = false;
            this.gvBan.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvBan_RowClick);
            // 
            // gcPhong
            // 
            this.gcPhong.DataSource = this.bdsPhong;
            this.gcPhong.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcPhong.Location = new System.Drawing.Point(0, 0);
            this.gcPhong.MainView = this.gvPhong;
            this.gcPhong.Margin = new System.Windows.Forms.Padding(4);
            this.gcPhong.Name = "gcPhong";
            this.gcPhong.Size = new System.Drawing.Size(827, 385);
            this.gcPhong.TabIndex = 0;
            this.gcPhong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPhong});
            // 
            // bdsPhong
            // 
            this.bdsPhong.DataSource = typeof(RestaurantManagement.Model.PhongModel);
            // 
            // gvPhong
            // 
            this.gvPhong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmaPhong,
            this.coltenPhong});
            this.gvPhong.DetailHeight = 437;
            this.gvPhong.GridControl = this.gcPhong;
            this.gvPhong.Name = "gvPhong";
            this.gvPhong.OptionsBehavior.Editable = false;
            this.gvPhong.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvPhong_RowClick);
            // 
            // colmaPhong
            // 
            this.colmaPhong.Caption = "MÃ PHÒNG";
            this.colmaPhong.FieldName = "maPhong";
            this.colmaPhong.MinWidth = 25;
            this.colmaPhong.Name = "colmaPhong";
            this.colmaPhong.Visible = true;
            this.colmaPhong.VisibleIndex = 0;
            this.colmaPhong.Width = 94;
            // 
            // coltenPhong
            // 
            this.coltenPhong.Caption = "TÊN PHÒNG";
            this.coltenPhong.FieldName = "tenPhong";
            this.coltenPhong.MinWidth = 25;
            this.coltenPhong.Name = "coltenPhong";
            this.coltenPhong.Visible = true;
            this.coltenPhong.VisibleIndex = 1;
            this.coltenPhong.Width = 94;
            // 
            // bdsCTBan
            // 
            this.bdsCTBan.DataSource = typeof(RestaurantManagement.Model.CTBanModel);
            // 
            // gcCTBan
            // 
            this.gcCTBan.DataSource = this.bdsCTBan;
            this.gcCTBan.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcCTBan.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5);
            this.gcCTBan.Location = new System.Drawing.Point(0, 0);
            this.gcCTBan.MainView = this.gvCTBan;
            this.gcCTBan.Margin = new System.Windows.Forms.Padding(5);
            this.gcCTBan.Name = "gcCTBan";
            this.gcCTBan.Size = new System.Drawing.Size(1001, 385);
            this.gcCTBan.TabIndex = 1;
            this.gcCTBan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCTBan});
            // 
            // gvCTBan
            // 
            this.gvCTBan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmaphong1,
            this.coltenphong1,
            this.colmaban1,
            this.coltenban1,
            this.colsoGhe1});
            this.gvCTBan.DetailHeight = 546;
            this.gvCTBan.GridControl = this.gcCTBan;
            this.gvCTBan.Name = "gvCTBan";
            this.gvCTBan.OptionsBehavior.Editable = false;
            this.gvCTBan.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvCTBan_RowClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gcCTBan);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(923, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1001, 754);
            this.panel2.TabIndex = 2;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btn_Them,
            this.btn_CapNhat,
            this.btn_Luu,
            this.btn_Xoa,
            this.btn_Reload,
            this.btn_Thoat,
            this.btn_PhucHoi});
            this.barManager1.MainMenu = this.bar1;
            this.barManager1.MaxItemId = 8;
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.FloatLocation = new System.Drawing.Point(732, 164);
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Them),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Xoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Reload),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Thoat)});
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // btn_Them
            // 
            this.btn_Them.Caption = "Thêm";
            this.btn_Them.Id = 0;
            this.btn_Them.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Them.ImageOptions.SvgImage")));
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_Them.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Them_ItemClick);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Caption = "Xóa";
            this.btn_Xoa.Id = 3;
            this.btn_Xoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Xoa.ImageOptions.SvgImage")));
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_Xoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Xoa_ItemClick);
            // 
            // btn_Reload
            // 
            this.btn_Reload.Caption = "Reload";
            this.btn_Reload.Id = 4;
            this.btn_Reload.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Reload.ImageOptions.SvgImage")));
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_Reload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Reload_ItemClick);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Caption = "Thoát";
            this.btn_Thoat.Id = 5;
            this.btn_Thoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Thoat.ImageOptions.SvgImage")));
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_Thoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Thoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1924, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 784);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1924, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 754);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1924, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 754);
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.Caption = "Cập nhật";
            this.btn_CapNhat.Id = 1;
            this.btn_CapNhat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_CapNhat.ImageOptions.SvgImage")));
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btn_Luu
            // 
            this.btn_Luu.Caption = "Lưu";
            this.btn_Luu.Enabled = false;
            this.btn_Luu.Id = 2;
            this.btn_Luu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Luu.ImageOptions.SvgImage")));
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btn_PhucHoi
            // 
            this.btn_PhucHoi.Caption = "Phục Hồi";
            this.btn_PhucHoi.Id = 6;
            this.btn_PhucHoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_PhucHoi.ImageOptions.SvgImage")));
            this.btn_PhucHoi.Name = "btn_PhucHoi";
            this.btn_PhucHoi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // colmaBan
            // 
            this.colmaBan.Caption = "MÃ BÀN";
            this.colmaBan.FieldName = "maBan";
            this.colmaBan.MinWidth = 25;
            this.colmaBan.Name = "colmaBan";
            this.colmaBan.Visible = true;
            this.colmaBan.VisibleIndex = 0;
            this.colmaBan.Width = 94;
            // 
            // coltenBan
            // 
            this.coltenBan.Caption = "TÊN BÀN";
            this.coltenBan.FieldName = "tenBan";
            this.coltenBan.MinWidth = 25;
            this.coltenBan.Name = "coltenBan";
            this.coltenBan.Visible = true;
            this.coltenBan.VisibleIndex = 1;
            this.coltenBan.Width = 94;
            // 
            // colsoGhe
            // 
            this.colsoGhe.Caption = "SỐ GHẾ";
            this.colsoGhe.FieldName = "soGhe";
            this.colsoGhe.MinWidth = 25;
            this.colsoGhe.Name = "colsoGhe";
            this.colsoGhe.Visible = true;
            this.colsoGhe.VisibleIndex = 2;
            this.colsoGhe.Width = 94;
            // 
            // colmaphong1
            // 
            this.colmaphong1.Caption = "MÃ PHÒNG";
            this.colmaphong1.FieldName = "maphong";
            this.colmaphong1.MinWidth = 25;
            this.colmaphong1.Name = "colmaphong1";
            this.colmaphong1.Visible = true;
            this.colmaphong1.VisibleIndex = 0;
            this.colmaphong1.Width = 94;
            // 
            // coltenphong1
            // 
            this.coltenphong1.Caption = "TÊN PHÒNG";
            this.coltenphong1.FieldName = "tenphong";
            this.coltenphong1.MinWidth = 25;
            this.coltenphong1.Name = "coltenphong1";
            this.coltenphong1.Visible = true;
            this.coltenphong1.VisibleIndex = 1;
            this.coltenphong1.Width = 94;
            // 
            // colmaban1
            // 
            this.colmaban1.Caption = "MÃ BÀN";
            this.colmaban1.FieldName = "maban";
            this.colmaban1.MinWidth = 25;
            this.colmaban1.Name = "colmaban1";
            this.colmaban1.Visible = true;
            this.colmaban1.VisibleIndex = 2;
            this.colmaban1.Width = 94;
            // 
            // coltenban1
            // 
            this.coltenban1.Caption = "TÊN BÀN";
            this.coltenban1.FieldName = "tenban";
            this.coltenban1.MinWidth = 25;
            this.coltenban1.Name = "coltenban1";
            this.coltenban1.Visible = true;
            this.coltenban1.VisibleIndex = 3;
            this.coltenban1.Width = 94;
            // 
            // colsoGhe1
            // 
            this.colsoGhe1.Caption = "SỐ GHẾ";
            this.colsoGhe1.FieldName = "soGhe";
            this.colsoGhe1.MinWidth = 25;
            this.colsoGhe1.Name = "colsoGhe1";
            this.colsoGhe1.Visible = true;
            this.colsoGhe1.VisibleIndex = 4;
            this.colsoGhe1.Width = 94;
            // 
            // frmChiTietBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 784);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmChiTietBan";
            this.Text = "CHI TIẾT BÀN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmChiTietBan_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTBan)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gcBan;
        private System.Windows.Forms.BindingSource bdsBan;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBan;
        private DevExpress.XtraGrid.GridControl gcPhong;
        private System.Windows.Forms.BindingSource bdsPhong;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPhong;
        private DevExpress.XtraGrid.Columns.GridColumn colmaPhong;
        private DevExpress.XtraGrid.Columns.GridColumn coltenPhong;
        private System.Windows.Forms.BindingSource bdsCTBan;
        private DevExpress.XtraGrid.GridControl gcCTBan;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCTBan;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btn_Them;
        private DevExpress.XtraBars.BarButtonItem btn_Xoa;
        private DevExpress.XtraBars.BarButtonItem btn_Reload;
        private DevExpress.XtraBars.BarButtonItem btn_Thoat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btn_CapNhat;
        private DevExpress.XtraBars.BarButtonItem btn_Luu;
        private DevExpress.XtraBars.BarButtonItem btn_PhucHoi;
        private DevExpress.XtraGrid.Columns.GridColumn colmaBan;
        private DevExpress.XtraGrid.Columns.GridColumn coltenBan;
        private DevExpress.XtraGrid.Columns.GridColumn colsoGhe;
        private DevExpress.XtraGrid.Columns.GridColumn colmaphong1;
        private DevExpress.XtraGrid.Columns.GridColumn coltenphong1;
        private DevExpress.XtraGrid.Columns.GridColumn colmaban1;
        private DevExpress.XtraGrid.Columns.GridColumn coltenban1;
        private DevExpress.XtraGrid.Columns.GridColumn colsoGhe1;
    }
}