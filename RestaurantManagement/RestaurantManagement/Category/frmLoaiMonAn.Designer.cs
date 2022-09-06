
namespace RestaurantManagement
{
    partial class frmTypeOfDishes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTypeOfDishes));
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gcLoaiMonAn = new DevExpress.XtraGrid.GridControl();
            this.bdsLoaiMonAn = new System.Windows.Forms.BindingSource(this.components);
            this.gvLoaiMonAn = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colmaLMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltenLMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhinhAnh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.txt_TenLMA = new DevExpress.XtraEditors.TextEdit();
            this.txt_MaLMA = new DevExpress.XtraEditors.TextEdit();
            this.txt_HinhAnh = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcLoaiMonAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLoaiMonAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLoaiMonAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenLMA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaLMA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_HinhAnh.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.barDockControlTop.Size = new System.Drawing.Size(1415, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 785);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1415, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 755);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1415, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 755);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gcLoaiMonAn);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 30);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1415, 380);
            this.panelControl1.TabIndex = 4;
            // 
            // gcLoaiMonAn
            // 
            this.gcLoaiMonAn.DataSource = this.bdsLoaiMonAn;
            this.gcLoaiMonAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcLoaiMonAn.Location = new System.Drawing.Point(2, 2);
            this.gcLoaiMonAn.MainView = this.gvLoaiMonAn;
            this.gcLoaiMonAn.MenuManager = this.barManager1;
            this.gcLoaiMonAn.Name = "gcLoaiMonAn";
            this.gcLoaiMonAn.Size = new System.Drawing.Size(1411, 376);
            this.gcLoaiMonAn.TabIndex = 0;
            this.gcLoaiMonAn.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLoaiMonAn});
            // 
            // bdsLoaiMonAn
            // 
            this.bdsLoaiMonAn.DataSource = typeof(RestaurantManagement.Model.LoaiMonAnModel);
            // 
            // gvLoaiMonAn
            // 
            this.gvLoaiMonAn.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmaLMA,
            this.coltenLMA,
            this.colhinhAnh});
            this.gvLoaiMonAn.GridControl = this.gcLoaiMonAn;
            this.gvLoaiMonAn.Name = "gvLoaiMonAn";
            this.gvLoaiMonAn.OptionsBehavior.Editable = false;
            this.gvLoaiMonAn.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewLoaiMonAn_RowClick);
            // 
            // colmaLMA
            // 
            this.colmaLMA.Caption = "MÃ LOẠI MÓN ĂN";
            this.colmaLMA.FieldName = "maLMA";
            this.colmaLMA.MinWidth = 25;
            this.colmaLMA.Name = "colmaLMA";
            this.colmaLMA.Visible = true;
            this.colmaLMA.VisibleIndex = 0;
            this.colmaLMA.Width = 94;
            // 
            // coltenLMA
            // 
            this.coltenLMA.Caption = "TÊN LOẠI MÓN ĂN";
            this.coltenLMA.FieldName = "tenLMA";
            this.coltenLMA.MinWidth = 25;
            this.coltenLMA.Name = "coltenLMA";
            this.coltenLMA.Visible = true;
            this.coltenLMA.VisibleIndex = 1;
            this.coltenLMA.Width = 94;
            // 
            // colhinhAnh
            // 
            this.colhinhAnh.Caption = "LINK HÌNH ẢNH";
            this.colhinhAnh.FieldName = "hinhAnh";
            this.colhinhAnh.MinWidth = 25;
            this.colhinhAnh.Name = "colhinhAnh";
            this.colhinhAnh.Visible = true;
            this.colhinhAnh.VisibleIndex = 2;
            this.colhinhAnh.Width = 94;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.pbImage);
            this.panelControl2.Controls.Add(this.txt_TenLMA);
            this.panelControl2.Controls.Add(this.txt_MaLMA);
            this.panelControl2.Controls.Add(this.txt_HinhAnh);
            this.panelControl2.Controls.Add(this.label4);
            this.panelControl2.Controls.Add(this.label3);
            this.panelControl2.Controls.Add(this.label2);
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Enabled = false;
            this.panelControl2.Location = new System.Drawing.Point(0, 410);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1415, 375);
            this.panelControl2.TabIndex = 5;
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(949, 27);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(354, 317);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 13;
            this.pbImage.TabStop = false;
            // 
            // txt_TenLMA
            // 
            this.txt_TenLMA.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLoaiMonAn, "tenLMA", true));
            this.txt_TenLMA.Location = new System.Drawing.Point(261, 151);
            this.txt_TenLMA.MenuManager = this.barManager1;
            this.txt_TenLMA.Name = "txt_TenLMA";
            this.txt_TenLMA.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenLMA.Properties.Appearance.Options.UseFont = true;
            this.txt_TenLMA.Size = new System.Drawing.Size(590, 32);
            this.txt_TenLMA.TabIndex = 12;
            // 
            // txt_MaLMA
            // 
            this.txt_MaLMA.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLoaiMonAn, "maLMA", true));
            this.txt_MaLMA.Location = new System.Drawing.Point(261, 86);
            this.txt_MaLMA.MenuManager = this.barManager1;
            this.txt_MaLMA.Name = "txt_MaLMA";
            this.txt_MaLMA.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaLMA.Properties.Appearance.Options.UseFont = true;
            this.txt_MaLMA.Size = new System.Drawing.Size(590, 32);
            this.txt_MaLMA.TabIndex = 10;
            // 
            // txt_HinhAnh
            // 
            this.txt_HinhAnh.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLoaiMonAn, "hinhAnh", true));
            this.txt_HinhAnh.Location = new System.Drawing.Point(261, 217);
            this.txt_HinhAnh.MenuManager = this.barManager1;
            this.txt_HinhAnh.Name = "txt_HinhAnh";
            this.txt_HinhAnh.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HinhAnh.Properties.Appearance.Options.UseFont = true;
            this.txt_HinhAnh.Size = new System.Drawing.Size(590, 32);
            this.txt_HinhAnh.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hình ảnh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên loại món ăn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã loại món ăn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ LOẠI MÓN ĂN";
            // 
            // frmTypeOfDishes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 785);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmTypeOfDishes";
            this.Text = "LOẠI MÓN ĂN";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcLoaiMonAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLoaiMonAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLoaiMonAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenLMA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaLMA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_HinhAnh.Properties)).EndInit();
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
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraBars.BarButtonItem btn_Reload;
        private DevExpress.XtraBars.BarButtonItem btn_Thoat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gcLoaiMonAn;
        private System.Windows.Forms.BindingSource bdsLoaiMonAn;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLoaiMonAn;
        private DevExpress.XtraGrid.Columns.GridColumn colmaLMA;
        private DevExpress.XtraGrid.Columns.GridColumn coltenLMA;
        private DevExpress.XtraGrid.Columns.GridColumn colhinhAnh;
        private DevExpress.XtraEditors.TextEdit txt_TenLMA;
        private DevExpress.XtraEditors.TextEdit txt_MaLMA;
        private DevExpress.XtraEditors.TextEdit txt_HinhAnh;
        private DevExpress.XtraBars.BarButtonItem btn_PhucHoi;
        private System.Windows.Forms.PictureBox pbImage;
    }
}