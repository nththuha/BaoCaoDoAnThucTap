
namespace RestaurantManagement
{
    partial class frmPhongBan
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
            System.Windows.Forms.Label maPhongLabel;
            System.Windows.Forms.Label tenPhongLabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhongBan));
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelPhong = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TenPhong = new DevExpress.XtraEditors.TextEdit();
            this.bdsPhong = new System.Windows.Forms.BindingSource(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btn_Them = new DevExpress.XtraBars.BarButtonItem();
            this.btn_CapNhat = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Luu = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Xoa = new DevExpress.XtraBars.BarButtonItem();
            this.btn_PhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Reload = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Thoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.txt_MaPhong = new DevExpress.XtraEditors.TextEdit();
            this.gcPhong = new DevExpress.XtraGrid.GridControl();
            this.gvPhong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colmaPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltenPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsBan = new System.Windows.Forms.BindingSource(this.components);
            this.gcBan = new DevExpress.XtraGrid.GridControl();
            this.gvBan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colmaBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltenBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsoGhe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelBan = new System.Windows.Forms.Panel();
            this.seSoGhe = new DevExpress.XtraEditors.SpinEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MaBan = new DevExpress.XtraEditors.TextEdit();
            this.txt_TenBan = new DevExpress.XtraEditors.TextEdit();
            this.panel3 = new System.Windows.Forms.Panel();
            maPhongLabel = new System.Windows.Forms.Label();
            tenPhongLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenPhong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaPhong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seSoGhe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaBan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenBan.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // maPhongLabel
            // 
            maPhongLabel.AutoSize = true;
            maPhongLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maPhongLabel.Location = new System.Drawing.Point(30, 88);
            maPhongLabel.Name = "maPhongLabel";
            maPhongLabel.Size = new System.Drawing.Size(109, 27);
            maPhongLabel.TabIndex = 0;
            maPhongLabel.Text = "Mã phòng";
            // 
            // tenPhongLabel
            // 
            tenPhongLabel.AutoSize = true;
            tenPhongLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenPhongLabel.Location = new System.Drawing.Point(30, 157);
            tenPhongLabel.Name = "tenPhongLabel";
            tenPhongLabel.Size = new System.Drawing.Size(114, 27);
            tenPhongLabel.TabIndex = 2;
            tenPhongLabel.Text = "Tên phòng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(46, 157);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(90, 27);
            label3.TabIndex = 8;
            label3.Text = "Tên bàn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(46, 88);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(85, 27);
            label4.TabIndex = 6;
            label4.Text = "Mã bàn";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(46, 225);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(76, 27);
            label5.TabIndex = 11;
            label5.Text = "Số ghế";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelPhong);
            this.panel1.Controls.Add(this.gcPhong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(949, 728);
            this.panel1.TabIndex = 0;
            // 
            // panelPhong
            // 
            this.panelPhong.Controls.Add(this.label2);
            this.panelPhong.Controls.Add(tenPhongLabel);
            this.panelPhong.Controls.Add(this.txt_TenPhong);
            this.panelPhong.Controls.Add(maPhongLabel);
            this.panelPhong.Controls.Add(this.txt_MaPhong);
            this.panelPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPhong.Enabled = false;
            this.panelPhong.Location = new System.Drawing.Point(0, 348);
            this.panelPhong.Name = "panelPhong";
            this.panelPhong.Size = new System.Drawing.Size(949, 380);
            this.panelPhong.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "QUẢN LÝ PHÒNG";
            // 
            // txt_TenPhong
            // 
            this.txt_TenPhong.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPhong, "tenPhong", true));
            this.txt_TenPhong.Location = new System.Drawing.Point(180, 154);
            this.txt_TenPhong.MenuManager = this.barManager1;
            this.txt_TenPhong.Name = "txt_TenPhong";
            this.txt_TenPhong.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenPhong.Properties.Appearance.Options.UseFont = true;
            this.txt_TenPhong.Size = new System.Drawing.Size(367, 32);
            this.txt_TenPhong.TabIndex = 3;
            // 
            // bdsPhong
            // 
            this.bdsPhong.DataSource = typeof(RestaurantManagement.Model.PhongModel);
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_CapNhat),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Luu),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Xoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_PhucHoi),
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
            // btn_CapNhat
            // 
            this.btn_CapNhat.Caption = "Cập nhật";
            this.btn_CapNhat.Id = 1;
            this.btn_CapNhat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_CapNhat.ImageOptions.SvgImage")));
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_CapNhat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_CapNhat_ItemClick);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Caption = "Lưu";
            this.btn_Luu.Enabled = false;
            this.btn_Luu.Id = 2;
            this.btn_Luu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Luu.ImageOptions.SvgImage")));
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_Luu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Luu_ItemClick);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Caption = "Xóa";
            this.btn_Xoa.Id = 3;
            this.btn_Xoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Xoa.ImageOptions.SvgImage")));
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_Xoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Xoa_ItemClick_1);
            // 
            // btn_PhucHoi
            // 
            this.btn_PhucHoi.Caption = "Phục Hồi";
            this.btn_PhucHoi.Id = 6;
            this.btn_PhucHoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_PhucHoi.ImageOptions.SvgImage")));
            this.btn_PhucHoi.Name = "btn_PhucHoi";
            this.btn_PhucHoi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_PhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_PhucHoi_ItemClick);
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
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 758);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1924, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 728);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1924, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 728);
            // 
            // txt_MaPhong
            // 
            this.txt_MaPhong.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPhong, "maPhong", true));
            this.txt_MaPhong.Location = new System.Drawing.Point(180, 85);
            this.txt_MaPhong.MenuManager = this.barManager1;
            this.txt_MaPhong.Name = "txt_MaPhong";
            this.txt_MaPhong.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaPhong.Properties.Appearance.Options.UseFont = true;
            this.txt_MaPhong.Size = new System.Drawing.Size(367, 32);
            this.txt_MaPhong.TabIndex = 1;
            // 
            // gcPhong
            // 
            this.gcPhong.DataSource = this.bdsPhong;
            this.gcPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcPhong.Location = new System.Drawing.Point(0, 0);
            this.gcPhong.MainView = this.gvPhong;
            this.gcPhong.MenuManager = this.barManager1;
            this.gcPhong.Name = "gcPhong";
            this.gcPhong.Size = new System.Drawing.Size(949, 348);
            this.gcPhong.TabIndex = 0;
            this.gcPhong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPhong});
            // 
            // gvPhong
            // 
            this.gvPhong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmaPhong,
            this.coltenPhong});
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
            // bdsBan
            // 
            this.bdsBan.DataSource = typeof(RestaurantManagement.Model.BanModel);
            // 
            // gcBan
            // 
            this.gcBan.DataSource = this.bdsBan;
            this.gcBan.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcBan.Location = new System.Drawing.Point(0, 0);
            this.gcBan.MainView = this.gvBan;
            this.gcBan.MenuManager = this.barManager1;
            this.gcBan.Name = "gcBan";
            this.gcBan.Size = new System.Drawing.Size(975, 348);
            this.gcBan.TabIndex = 0;
            this.gcBan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBan,
            this.gridView1});
            // 
            // gvBan
            // 
            this.gvBan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmaBan,
            this.coltenBan,
            this.colsoGhe});
            this.gvBan.GridControl = this.gcBan;
            this.gvBan.Name = "gvBan";
            this.gvBan.OptionsBehavior.Editable = false;
            this.gvBan.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvBan_RowClick);
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
            // gridView1
            // 
            this.gridView1.GridControl = this.gcBan;
            this.gridView1.Name = "gridView1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelBan);
            this.panel2.Controls.Add(this.gcBan);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(949, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(975, 728);
            this.panel2.TabIndex = 1;
            // 
            // panelBan
            // 
            this.panelBan.Controls.Add(this.seSoGhe);
            this.panelBan.Controls.Add(label5);
            this.panelBan.Controls.Add(this.label1);
            this.panelBan.Controls.Add(this.txt_MaBan);
            this.panelBan.Controls.Add(label3);
            this.panelBan.Controls.Add(label4);
            this.panelBan.Controls.Add(this.txt_TenBan);
            this.panelBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBan.Enabled = false;
            this.panelBan.Location = new System.Drawing.Point(0, 348);
            this.panelBan.Name = "panelBan";
            this.panelBan.Size = new System.Drawing.Size(975, 380);
            this.panelBan.TabIndex = 1;
            // 
            // seSoGhe
            // 
            this.seSoGhe.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsBan, "soGhe", true));
            this.seSoGhe.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seSoGhe.Location = new System.Drawing.Point(173, 222);
            this.seSoGhe.MenuManager = this.barManager1;
            this.seSoGhe.Name = "seSoGhe";
            this.seSoGhe.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seSoGhe.Properties.Appearance.Options.UseFont = true;
            this.seSoGhe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seSoGhe.Size = new System.Drawing.Size(459, 32);
            this.seSoGhe.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "QUẢN LÝ BÀN";
            // 
            // txt_MaBan
            // 
            this.txt_MaBan.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPhong, "maPhong", true));
            this.txt_MaBan.Location = new System.Drawing.Point(173, 85);
            this.txt_MaBan.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaBan.MenuManager = this.barManager1;
            this.txt_MaBan.Name = "txt_MaBan";
            this.txt_MaBan.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaBan.Properties.Appearance.Options.UseFont = true;
            this.txt_MaBan.Size = new System.Drawing.Size(459, 32);
            this.txt_MaBan.TabIndex = 7;
            // 
            // txt_TenBan
            // 
            this.txt_TenBan.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPhong, "tenPhong", true));
            this.txt_TenBan.Location = new System.Drawing.Point(173, 154);
            this.txt_TenBan.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenBan.MenuManager = this.barManager1;
            this.txt_TenBan.Name = "txt_TenBan";
            this.txt_TenBan.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenBan.Properties.Appearance.Options.UseFont = true;
            this.txt_TenBan.Size = new System.Drawing.Size(459, 32);
            this.txt_TenBan.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(949, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(0, 728);
            this.panel3.TabIndex = 11;
            // 
            // frmPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1924, 758);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmPhongBan";
            this.Text = "PHÒNG - BÀN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panelPhong.ResumeLayout(false);
            this.panelPhong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenPhong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaPhong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panelBan.ResumeLayout(false);
            this.panelBan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seSoGhe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaBan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenBan.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Bar bar2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btn_Them;
        private DevExpress.XtraBars.BarButtonItem btn_CapNhat;
        private DevExpress.XtraBars.BarButtonItem btn_Luu;
        private DevExpress.XtraBars.BarButtonItem btn_Xoa;
        private DevExpress.XtraBars.BarButtonItem btn_PhucHoi;
        private DevExpress.XtraBars.BarButtonItem btn_Reload;
        private DevExpress.XtraBars.BarButtonItem btn_Thoat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gcPhong;
        private System.Windows.Forms.BindingSource bdsPhong;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPhong;
        private DevExpress.XtraGrid.Columns.GridColumn colmaPhong;
        private DevExpress.XtraGrid.Columns.GridColumn coltenPhong;
        private System.Windows.Forms.BindingSource bdsBan;
        private System.Windows.Forms.Panel panelPhong;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txt_TenPhong;
        private DevExpress.XtraEditors.TextEdit txt_MaPhong;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gcBan;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelBan;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txt_MaBan;
        private DevExpress.XtraEditors.TextEdit txt_TenBan;
        private DevExpress.XtraEditors.SpinEdit seSoGhe;
        private DevExpress.XtraGrid.Columns.GridColumn colmaBan;
        private DevExpress.XtraGrid.Columns.GridColumn coltenBan;
        private DevExpress.XtraGrid.Columns.GridColumn colsoGhe;
    }
}