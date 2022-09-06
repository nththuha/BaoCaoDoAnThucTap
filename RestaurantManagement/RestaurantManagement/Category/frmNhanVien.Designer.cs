
namespace RestaurantManagement
{
    partial class frmNhanVien
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
            System.Windows.Forms.Label hoTenLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label diaChiLabel;
            System.Windows.Forms.Label sdtLabel;
            System.Windows.Forms.Label maBPLabel;
            System.Windows.Forms.Label idNVLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
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
            this.bdsNhanVien = new System.Windows.Forms.BindingSource(this.components);
            this.gcNhanVien = new DevExpress.XtraGrid.GridControl();
            this.gvNhanVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colemail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmaBP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltenBP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsdt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.etHoTen = new DevExpress.XtraEditors.TextEdit();
            this.etEmail = new DevExpress.XtraEditors.TextEdit();
            this.etDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.etIDNV = new DevExpress.XtraEditors.TextEdit();
            this.lb_TenBP = new System.Windows.Forms.Label();
            this.cbbMaBP = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.etSDT = new DevExpress.XtraEditors.TextEdit();
            hoTenLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            diaChiLabel = new System.Windows.Forms.Label();
            sdtLabel = new System.Windows.Forms.Label();
            maBPLabel = new System.Windows.Forms.Label();
            idNVLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etHoTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etDiaChi.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.etIDNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etSDT.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // hoTenLabel
            // 
            hoTenLabel.AutoSize = true;
            hoTenLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hoTenLabel.Location = new System.Drawing.Point(52, 113);
            hoTenLabel.Name = "hoTenLabel";
            hoTenLabel.Size = new System.Drawing.Size(77, 27);
            hoTenLabel.TabIndex = 2;
            hoTenLabel.Text = "Họ tên";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.Location = new System.Drawing.Point(52, 164);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(68, 27);
            emailLabel.TabIndex = 4;
            emailLabel.Text = "Email";
            // 
            // diaChiLabel
            // 
            diaChiLabel.AutoSize = true;
            diaChiLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            diaChiLabel.Location = new System.Drawing.Point(52, 213);
            diaChiLabel.Name = "diaChiLabel";
            diaChiLabel.Size = new System.Drawing.Size(81, 27);
            diaChiLabel.TabIndex = 6;
            diaChiLabel.Text = "Địa chỉ";
            // 
            // sdtLabel
            // 
            sdtLabel.AutoSize = true;
            sdtLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sdtLabel.Location = new System.Drawing.Point(52, 264);
            sdtLabel.Name = "sdtLabel";
            sdtLabel.Size = new System.Drawing.Size(55, 27);
            sdtLabel.TabIndex = 8;
            sdtLabel.Text = "SDT";
            // 
            // maBPLabel
            // 
            maBPLabel.AutoSize = true;
            maBPLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maBPLabel.Location = new System.Drawing.Point(52, 321);
            maBPLabel.Name = "maBPLabel";
            maBPLabel.Size = new System.Drawing.Size(127, 27);
            maBPLabel.TabIndex = 10;
            maBPLabel.Text = "Mã bộ phận";
            // 
            // idNVLabel
            // 
            idNVLabel.AutoSize = true;
            idNVLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idNVLabel.Location = new System.Drawing.Point(52, 62);
            idNVLabel.Name = "idNVLabel";
            idNVLabel.Size = new System.Drawing.Size(70, 27);
            idNVLabel.TabIndex = 14;
            idNVLabel.Text = "IDNV";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
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
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Them),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_CapNhat),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Luu),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Xoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_PhucHoi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Reload),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Thoat)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
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
            this.btn_Xoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Xoa_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1488, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 755);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1488, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 725);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1488, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 725);
            // 
            // bdsNhanVien
            // 
            this.bdsNhanVien.DataSource = typeof(RestaurantManagement.Model.NhanVienModel);
            // 
            // gcNhanVien
            // 
            this.gcNhanVien.DataSource = this.bdsNhanVien;
            this.gcNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcNhanVien.Location = new System.Drawing.Point(0, 30);
            this.gcNhanVien.MainView = this.gvNhanVien;
            this.gcNhanVien.MenuManager = this.barManager1;
            this.gcNhanVien.Name = "gcNhanVien";
            this.gcNhanVien.Size = new System.Drawing.Size(1488, 347);
            this.gcNhanVien.TabIndex = 5;
            this.gcNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNhanVien});
            // 
            // gvNhanVien
            // 
            this.gvNhanVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidNV,
            this.colhoTen,
            this.coldiaChi,
            this.colemail,
            this.colmaBP,
            this.coltenBP,
            this.colsdt});
            this.gvNhanVien.GridControl = this.gcNhanVien;
            this.gvNhanVien.Name = "gvNhanVien";
            this.gvNhanVien.OptionsBehavior.Editable = false;
            this.gvNhanVien.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvNhanVien_RowClick);
            // 
            // colidNV
            // 
            this.colidNV.Caption = "IDNV";
            this.colidNV.FieldName = "idNV";
            this.colidNV.MinWidth = 25;
            this.colidNV.Name = "colidNV";
            this.colidNV.Visible = true;
            this.colidNV.VisibleIndex = 0;
            this.colidNV.Width = 94;
            // 
            // colhoTen
            // 
            this.colhoTen.Caption = "HỌ TÊN";
            this.colhoTen.FieldName = "hoTen";
            this.colhoTen.MinWidth = 25;
            this.colhoTen.Name = "colhoTen";
            this.colhoTen.Visible = true;
            this.colhoTen.VisibleIndex = 1;
            this.colhoTen.Width = 94;
            // 
            // coldiaChi
            // 
            this.coldiaChi.Caption = "ĐỊA CHỈ";
            this.coldiaChi.FieldName = "diaChi";
            this.coldiaChi.MinWidth = 25;
            this.coldiaChi.Name = "coldiaChi";
            this.coldiaChi.Visible = true;
            this.coldiaChi.VisibleIndex = 2;
            this.coldiaChi.Width = 94;
            // 
            // colemail
            // 
            this.colemail.Caption = "EMAIL";
            this.colemail.FieldName = "email";
            this.colemail.MinWidth = 25;
            this.colemail.Name = "colemail";
            this.colemail.Visible = true;
            this.colemail.VisibleIndex = 3;
            this.colemail.Width = 94;
            // 
            // colmaBP
            // 
            this.colmaBP.Caption = "MÃ BỘ PHẬN";
            this.colmaBP.FieldName = "maBP";
            this.colmaBP.MinWidth = 25;
            this.colmaBP.Name = "colmaBP";
            this.colmaBP.Visible = true;
            this.colmaBP.VisibleIndex = 5;
            this.colmaBP.Width = 94;
            // 
            // coltenBP
            // 
            this.coltenBP.Caption = "TÊN BỘ PHẬN";
            this.coltenBP.FieldName = "tenBP";
            this.coltenBP.MinWidth = 25;
            this.coltenBP.Name = "coltenBP";
            this.coltenBP.Visible = true;
            this.coltenBP.VisibleIndex = 6;
            this.coltenBP.Width = 94;
            // 
            // colsdt
            // 
            this.colsdt.Caption = "SDT";
            this.colsdt.FieldName = "sdt";
            this.colsdt.MinWidth = 25;
            this.colsdt.Name = "colsdt";
            this.colsdt.Visible = true;
            this.colsdt.VisibleIndex = 4;
            this.colsdt.Width = 94;
            // 
            // etHoTen
            // 
            this.etHoTen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNhanVien, "hoTen", true));
            this.etHoTen.Location = new System.Drawing.Point(206, 110);
            this.etHoTen.MenuManager = this.barManager1;
            this.etHoTen.Name = "etHoTen";
            this.etHoTen.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etHoTen.Properties.Appearance.Options.UseFont = true;
            this.etHoTen.Size = new System.Drawing.Size(505, 32);
            this.etHoTen.TabIndex = 3;
            // 
            // etEmail
            // 
            this.etEmail.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNhanVien, "email", true));
            this.etEmail.Location = new System.Drawing.Point(206, 161);
            this.etEmail.MenuManager = this.barManager1;
            this.etEmail.Name = "etEmail";
            this.etEmail.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etEmail.Properties.Appearance.Options.UseFont = true;
            this.etEmail.Size = new System.Drawing.Size(505, 32);
            this.etEmail.TabIndex = 5;
            // 
            // etDiaChi
            // 
            this.etDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNhanVien, "diaChi", true));
            this.etDiaChi.Location = new System.Drawing.Point(206, 210);
            this.etDiaChi.MenuManager = this.barManager1;
            this.etDiaChi.Name = "etDiaChi";
            this.etDiaChi.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etDiaChi.Properties.Appearance.Options.UseFont = true;
            this.etDiaChi.Size = new System.Drawing.Size(505, 32);
            this.etDiaChi.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(idNVLabel);
            this.panel1.Controls.Add(this.etIDNV);
            this.panel1.Controls.Add(this.lb_TenBP);
            this.panel1.Controls.Add(this.cbbMaBP);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(maBPLabel);
            this.panel1.Controls.Add(sdtLabel);
            this.panel1.Controls.Add(this.etSDT);
            this.panel1.Controls.Add(diaChiLabel);
            this.panel1.Controls.Add(this.etDiaChi);
            this.panel1.Controls.Add(emailLabel);
            this.panel1.Controls.Add(this.etEmail);
            this.panel1.Controls.Add(hoTenLabel);
            this.panel1.Controls.Add(this.etHoTen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(0, 377);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1488, 378);
            this.panel1.TabIndex = 10;
            // 
            // etIDNV
            // 
            this.etIDNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNhanVien, "idNV", true));
            this.etIDNV.Enabled = false;
            this.etIDNV.Location = new System.Drawing.Point(206, 59);
            this.etIDNV.MenuManager = this.barManager1;
            this.etIDNV.Name = "etIDNV";
            this.etIDNV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etIDNV.Properties.Appearance.Options.UseFont = true;
            this.etIDNV.Size = new System.Drawing.Size(505, 32);
            this.etIDNV.TabIndex = 15;
            // 
            // lb_TenBP
            // 
            this.lb_TenBP.AutoSize = true;
            this.lb_TenBP.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenBP.Location = new System.Drawing.Point(774, 321);
            this.lb_TenBP.Name = "lb_TenBP";
            this.lb_TenBP.Size = new System.Drawing.Size(132, 27);
            this.lb_TenBP.TabIndex = 14;
            this.lb_TenBP.Text = "Tên bộ phận";
            // 
            // cbbMaBP
            // 
            this.cbbMaBP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNhanVien, "maBP", true));
            this.cbbMaBP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaBP.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaBP.FormattingEnabled = true;
            this.cbbMaBP.Location = new System.Drawing.Point(206, 318);
            this.cbbMaBP.Name = "cbbMaBP";
            this.cbbMaBP.Size = new System.Drawing.Size(505, 34);
            this.cbbMaBP.TabIndex = 13;
            this.cbbMaBP.SelectedIndexChanged += new System.EventHandler(this.cbbMaBP_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 26);
            this.label1.TabIndex = 12;
            this.label1.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // etSDT
            // 
            this.etSDT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNhanVien, "sdt", true));
            this.etSDT.Location = new System.Drawing.Point(206, 261);
            this.etSDT.MenuManager = this.barManager1;
            this.etSDT.Name = "etSDT";
            this.etSDT.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etSDT.Properties.Appearance.Options.UseFont = true;
            this.etSDT.Size = new System.Drawing.Size(505, 32);
            this.etSDT.TabIndex = 9;
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1488, 755);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gcNhanVien);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmNhanVien";
            this.Text = "NHÂN VIÊN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etHoTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etDiaChi.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.etIDNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etSDT.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
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
        private DevExpress.XtraGrid.GridControl gcNhanVien;
        private System.Windows.Forms.BindingSource bdsNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn colidNV;
        private DevExpress.XtraGrid.Columns.GridColumn colhoTen;
        private DevExpress.XtraGrid.Columns.GridColumn coldiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colemail;
        private DevExpress.XtraGrid.Columns.GridColumn colmaBP;
        private DevExpress.XtraGrid.Columns.GridColumn coltenBP;
        private DevExpress.XtraGrid.Columns.GridColumn colsdt;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit etSDT;
        private DevExpress.XtraEditors.TextEdit etDiaChi;
        private DevExpress.XtraEditors.TextEdit etEmail;
        private DevExpress.XtraEditors.TextEdit etHoTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_TenBP;
        private System.Windows.Forms.ComboBox cbbMaBP;
        private DevExpress.XtraEditors.TextEdit etIDNV;
    }
}