
namespace RestaurantManagement
{
    partial class frmTaiKhoan
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
            System.Windows.Forms.Label maTKLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaiKhoan));
            this.bdsNhanVien = new System.Windows.Forms.BindingSource(this.components);
            this.bdsTaiKhoan = new System.Windows.Forms.BindingSource(this.components);
            this.gcNhanVien = new DevExpress.XtraGrid.GridControl();
            this.gvNhanVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colemail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltaiKhoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltenBP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsdt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btn_Them = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Reset = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Reload = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Thoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btn_Luu = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Xoa = new DevExpress.XtraBars.BarButtonItem();
            this.btn_PhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MaTK = new DevExpress.XtraEditors.TextEdit();
            maTKLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaTK.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // maTKLabel
            // 
            maTKLabel.AutoSize = true;
            maTKLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maTKLabel.Location = new System.Drawing.Point(47, 84);
            maTKLabel.Name = "maTKLabel";
            maTKLabel.Size = new System.Drawing.Size(139, 27);
            maTKLabel.TabIndex = 0;
            maTKLabel.Text = "Mã tài khoản";
            // 
            // bdsNhanVien
            // 
            this.bdsNhanVien.DataSource = typeof(RestaurantManagement.Model.NhanVienModel);
            // 
            // bdsTaiKhoan
            // 
            this.bdsTaiKhoan.DataSource = typeof(RestaurantManagement.Model.TaiKhoanModel);
            // 
            // gcNhanVien
            // 
            this.gcNhanVien.DataSource = this.bdsNhanVien;
            this.gcNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcNhanVien.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(12);
            this.gcNhanVien.Location = new System.Drawing.Point(0, 30);
            this.gcNhanVien.MainView = this.gvNhanVien;
            this.gcNhanVien.Margin = new System.Windows.Forms.Padding(12);
            this.gcNhanVien.Name = "gcNhanVien";
            this.gcNhanVien.Size = new System.Drawing.Size(1407, 410);
            this.gcNhanVien.TabIndex = 0;
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
            this.coltaiKhoan,
            this.coltenBP,
            this.colsdt});
            this.gvNhanVien.DetailHeight = 1331;
            this.gvNhanVien.GridControl = this.gcNhanVien;
            this.gvNhanVien.Name = "gvNhanVien";
            this.gvNhanVien.OptionsBehavior.Editable = false;
            this.gvNhanVien.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvNhanVien_RowClick);
            // 
            // colidNV
            // 
            this.colidNV.Caption = "IDNV";
            this.colidNV.FieldName = "idNV";
            this.colidNV.MinWidth = 76;
            this.colidNV.Name = "colidNV";
            this.colidNV.Visible = true;
            this.colidNV.VisibleIndex = 0;
            this.colidNV.Width = 284;
            // 
            // colhoTen
            // 
            this.colhoTen.Caption = "HỌ TÊN";
            this.colhoTen.FieldName = "hoTen";
            this.colhoTen.MinWidth = 76;
            this.colhoTen.Name = "colhoTen";
            this.colhoTen.Visible = true;
            this.colhoTen.VisibleIndex = 1;
            this.colhoTen.Width = 284;
            // 
            // coldiaChi
            // 
            this.coldiaChi.Caption = "ĐỊA CHỈ";
            this.coldiaChi.FieldName = "diaChi";
            this.coldiaChi.MinWidth = 76;
            this.coldiaChi.Name = "coldiaChi";
            this.coldiaChi.Visible = true;
            this.coldiaChi.VisibleIndex = 3;
            this.coldiaChi.Width = 284;
            // 
            // colemail
            // 
            this.colemail.Caption = "EMAIL";
            this.colemail.FieldName = "email";
            this.colemail.MinWidth = 76;
            this.colemail.Name = "colemail";
            this.colemail.Visible = true;
            this.colemail.VisibleIndex = 4;
            this.colemail.Width = 284;
            // 
            // coltaiKhoan
            // 
            this.coltaiKhoan.Caption = "TÀI KHOẢN";
            this.coltaiKhoan.FieldName = "taiKhoan";
            this.coltaiKhoan.MinWidth = 76;
            this.coltaiKhoan.Name = "coltaiKhoan";
            this.coltaiKhoan.Visible = true;
            this.coltaiKhoan.VisibleIndex = 2;
            this.coltaiKhoan.Width = 284;
            // 
            // coltenBP
            // 
            this.coltenBP.Caption = "TÊN BỘ PHẬN";
            this.coltenBP.FieldName = "tenBP";
            this.coltenBP.MinWidth = 76;
            this.coltenBP.Name = "coltenBP";
            this.coltenBP.Visible = true;
            this.coltenBP.VisibleIndex = 6;
            this.coltenBP.Width = 284;
            // 
            // colsdt
            // 
            this.colsdt.Caption = "SDT";
            this.colsdt.FieldName = "sdt";
            this.colsdt.MinWidth = 76;
            this.colsdt.Name = "colsdt";
            this.colsdt.Visible = true;
            this.colsdt.VisibleIndex = 5;
            this.colsdt.Width = 284;
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
            this.btn_Reset,
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
            this.bar2.FloatLocation = new System.Drawing.Point(95, 210);
            this.bar2.FloatSize = new System.Drawing.Size(633, 32);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Them),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Reset),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Reload),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Thoat)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btn_Them
            // 
            this.btn_Them.Caption = "Tạo tài khoản";
            this.btn_Them.Enabled = false;
            this.btn_Them.Id = 0;
            this.btn_Them.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Them.ImageOptions.SvgImage")));
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_Them.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Them_ItemClick);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Caption = "Reset mật khẩu";
            this.btn_Reset.Enabled = false;
            this.btn_Reset.Id = 1;
            this.btn_Reset.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Reset.ImageOptions.SvgImage")));
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_Reset.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_CapNhat_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1407, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 738);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1407, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 708);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1407, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 708);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(maTKLabel);
            this.panel1.Controls.Add(this.txt_MaTK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 440);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1407, 298);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "THÊM TÀI KHOẢN";
            // 
            // txt_MaTK
            // 
            this.txt_MaTK.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTaiKhoan, "maTK", true));
            this.txt_MaTK.Location = new System.Drawing.Point(235, 81);
            this.txt_MaTK.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaTK.MenuManager = this.barManager1;
            this.txt_MaTK.Name = "txt_MaTK";
            this.txt_MaTK.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaTK.Properties.Appearance.Options.UseFont = true;
            this.txt_MaTK.Size = new System.Drawing.Size(476, 32);
            this.txt_MaTK.TabIndex = 1;
            // 
            // frmTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 738);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gcNhanVien);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmTaiKhoan";
            this.Text = "TÀI KHOẢN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaTK.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bdsNhanVien;
        private System.Windows.Forms.BindingSource bdsTaiKhoan;
        private DevExpress.XtraGrid.GridControl gcNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn colidNV;
        private DevExpress.XtraGrid.Columns.GridColumn colhoTen;
        private DevExpress.XtraGrid.Columns.GridColumn coldiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colemail;
        private DevExpress.XtraGrid.Columns.GridColumn coltaiKhoan;
        private DevExpress.XtraGrid.Columns.GridColumn coltenBP;
        private DevExpress.XtraGrid.Columns.GridColumn colsdt;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btn_Them;
        private DevExpress.XtraBars.BarButtonItem btn_Reset;
        private DevExpress.XtraBars.BarButtonItem btn_Luu;
        private DevExpress.XtraBars.BarButtonItem btn_Xoa;
        private DevExpress.XtraBars.BarButtonItem btn_PhucHoi;
        private DevExpress.XtraBars.BarButtonItem btn_Reload;
        private DevExpress.XtraBars.BarButtonItem btn_Thoat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txt_MaTK;
    }
}