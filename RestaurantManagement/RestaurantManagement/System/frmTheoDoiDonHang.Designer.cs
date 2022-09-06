
namespace RestaurantManagement
{
    partial class frmTheoDoiDonHang
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
            this.bdsPhieuDat = new System.Windows.Forms.BindingSource(this.components);
            this.bdsCTDM = new System.Windows.Forms.BindingSource(this.components);
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gcCTDM = new DevExpress.XtraGrid.GridControl();
            this.gvCTDM = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colsoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colchuThich = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltenma = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidpd1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcPhieuDat = new DevExpress.XtraGrid.GridControl();
            this.gvPhieuDat = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidPD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colngay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhoTenNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltenBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltenPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_XuatHD = new System.Windows.Forms.Button();
            this.btn_ThemPD = new System.Windows.Forms.Button();
            this.gcHD = new DevExpress.XtraGrid.GridControl();
            this.gvHD = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidPD2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colngay1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidnv1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuDat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTDM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTDM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhieuDat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhieuDat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHD)).BeginInit();
            this.SuspendLayout();
            // 
            // bdsPhieuDat
            // 
            this.bdsPhieuDat.DataSource = typeof(RestaurantManagement.Model.PhieuDatModel);
            // 
            // bdsCTDM
            // 
            this.bdsCTDM.DataSource = typeof(RestaurantManagement.Model.CTDatMonModel);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gcCTDM);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(1243, 0);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(19);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(681, 855);
            this.panelControl2.TabIndex = 1;
            // 
            // gcCTDM
            // 
            this.gcCTDM.DataSource = this.bdsCTDM;
            this.gcCTDM.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcCTDM.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(19);
            this.gcCTDM.Location = new System.Drawing.Point(2, 2);
            this.gcCTDM.MainView = this.gvCTDM;
            this.gcCTDM.Margin = new System.Windows.Forms.Padding(19);
            this.gcCTDM.Name = "gcCTDM";
            this.gcCTDM.Size = new System.Drawing.Size(677, 388);
            this.gcCTDM.TabIndex = 0;
            this.gcCTDM.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCTDM});
            // 
            // gvCTDM
            // 
            this.gvCTDM.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colsoLuong,
            this.colchuThich,
            this.coltrangThai,
            this.colgia,
            this.colmama,
            this.coltenma,
            this.colidpd1});
            this.gvCTDM.DetailHeight = 2080;
            this.gvCTDM.GridControl = this.gcCTDM;
            this.gvCTDM.Name = "gvCTDM";
            this.gvCTDM.OptionsBehavior.Editable = false;
            // 
            // colsoLuong
            // 
            this.colsoLuong.Caption = "SỐ LƯỢNG";
            this.colsoLuong.FieldName = "soLuong";
            this.colsoLuong.MinWidth = 119;
            this.colsoLuong.Name = "colsoLuong";
            this.colsoLuong.Visible = true;
            this.colsoLuong.VisibleIndex = 2;
            this.colsoLuong.Width = 444;
            // 
            // colchuThich
            // 
            this.colchuThich.Caption = "CHÚ THÍCH";
            this.colchuThich.FieldName = "chuThich";
            this.colchuThich.MinWidth = 119;
            this.colchuThich.Name = "colchuThich";
            this.colchuThich.Visible = true;
            this.colchuThich.VisibleIndex = 4;
            this.colchuThich.Width = 444;
            // 
            // coltrangThai
            // 
            this.coltrangThai.Caption = "TRẠNG THÁI";
            this.coltrangThai.FieldName = "trangThai";
            this.coltrangThai.MinWidth = 119;
            this.coltrangThai.Name = "coltrangThai";
            this.coltrangThai.Visible = true;
            this.coltrangThai.VisibleIndex = 5;
            this.coltrangThai.Width = 444;
            // 
            // colgia
            // 
            this.colgia.Caption = "GIÁ";
            this.colgia.DisplayFormat.FormatString = "n0";
            this.colgia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colgia.FieldName = "gia";
            this.colgia.MinWidth = 119;
            this.colgia.Name = "colgia";
            this.colgia.Visible = true;
            this.colgia.VisibleIndex = 3;
            this.colgia.Width = 444;
            // 
            // colmama
            // 
            this.colmama.Caption = "MÃ MÓN ĂN";
            this.colmama.FieldName = "mama";
            this.colmama.MinWidth = 119;
            this.colmama.Name = "colmama";
            this.colmama.Visible = true;
            this.colmama.VisibleIndex = 0;
            this.colmama.Width = 444;
            // 
            // coltenma
            // 
            this.coltenma.Caption = "TÊN MÓN ĂN";
            this.coltenma.FieldName = "tenma";
            this.coltenma.MinWidth = 119;
            this.coltenma.Name = "coltenma";
            this.coltenma.Visible = true;
            this.coltenma.VisibleIndex = 1;
            this.coltenma.Width = 444;
            // 
            // colidpd1
            // 
            this.colidpd1.Caption = "IDPD";
            this.colidpd1.FieldName = "idpd";
            this.colidpd1.MinWidth = 119;
            this.colidpd1.Name = "colidpd1";
            this.colidpd1.Visible = true;
            this.colidpd1.VisibleIndex = 6;
            this.colidpd1.Width = 444;
            // 
            // gcPhieuDat
            // 
            this.gcPhieuDat.DataSource = this.bdsPhieuDat;
            this.gcPhieuDat.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcPhieuDat.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(24);
            this.gcPhieuDat.Location = new System.Drawing.Point(2, 2);
            this.gcPhieuDat.MainView = this.gvPhieuDat;
            this.gcPhieuDat.Margin = new System.Windows.Forms.Padding(24);
            this.gcPhieuDat.Name = "gcPhieuDat";
            this.gcPhieuDat.Size = new System.Drawing.Size(1239, 388);
            this.gcPhieuDat.TabIndex = 0;
            this.gcPhieuDat.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPhieuDat,
            this.gridView1});
            // 
            // gvPhieuDat
            // 
            this.gvPhieuDat.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidPD,
            this.colngay,
            this.colhoTenNV,
            this.coltenBan,
            this.coltenPhong});
            this.gvPhieuDat.DetailHeight = 2600;
            this.gvPhieuDat.GridControl = this.gcPhieuDat;
            this.gvPhieuDat.Name = "gvPhieuDat";
            this.gvPhieuDat.OptionsBehavior.Editable = false;
            this.gvPhieuDat.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvPhieuDat_RowClick);
            // 
            // colidPD
            // 
            this.colidPD.Caption = "IDPD";
            this.colidPD.FieldName = "idPD";
            this.colidPD.MinWidth = 39;
            this.colidPD.Name = "colidPD";
            this.colidPD.Visible = true;
            this.colidPD.VisibleIndex = 0;
            this.colidPD.Width = 146;
            // 
            // colngay
            // 
            this.colngay.Caption = "NGÀY";
            this.colngay.FieldName = "ngay";
            this.colngay.MinWidth = 39;
            this.colngay.Name = "colngay";
            this.colngay.Visible = true;
            this.colngay.VisibleIndex = 1;
            this.colngay.Width = 146;
            // 
            // colhoTenNV
            // 
            this.colhoTenNV.Caption = "HỌ TÊN NHÂN VIÊN";
            this.colhoTenNV.FieldName = "hoTenNV";
            this.colhoTenNV.MinWidth = 39;
            this.colhoTenNV.Name = "colhoTenNV";
            this.colhoTenNV.Visible = true;
            this.colhoTenNV.VisibleIndex = 2;
            this.colhoTenNV.Width = 146;
            // 
            // coltenBan
            // 
            this.coltenBan.Caption = "TÊN BÀN";
            this.coltenBan.FieldName = "tenBan";
            this.coltenBan.MinWidth = 39;
            this.coltenBan.Name = "coltenBan";
            this.coltenBan.Visible = true;
            this.coltenBan.VisibleIndex = 3;
            this.coltenBan.Width = 146;
            // 
            // coltenPhong
            // 
            this.coltenPhong.Caption = "TÊN PHÒNG";
            this.coltenPhong.FieldName = "tenPhong";
            this.coltenPhong.MinWidth = 39;
            this.coltenPhong.Name = "coltenPhong";
            this.coltenPhong.Visible = true;
            this.coltenPhong.VisibleIndex = 4;
            this.coltenPhong.Width = 146;
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 852;
            this.gridView1.GridControl = this.gcPhieuDat;
            this.gridView1.Name = "gridView1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.button1);
            this.panelControl1.Controls.Add(this.btn_XuatHD);
            this.panelControl1.Controls.Add(this.btn_ThemPD);
            this.panelControl1.Controls.Add(this.gcHD);
            this.panelControl1.Controls.Add(this.gcPhieuDat);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(24);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1243, 855);
            this.panelControl1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tomato;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(838, 492);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 60);
            this.button1.TabIndex = 4;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_XuatHD
            // 
            this.btn_XuatHD.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XuatHD.Location = new System.Drawing.Point(919, 609);
            this.btn_XuatHD.Margin = new System.Windows.Forms.Padding(5);
            this.btn_XuatHD.Name = "btn_XuatHD";
            this.btn_XuatHD.Size = new System.Drawing.Size(248, 70);
            this.btn_XuatHD.TabIndex = 3;
            this.btn_XuatHD.Text = "Xuất hóa đơn";
            this.btn_XuatHD.UseVisualStyleBackColor = true;
            this.btn_XuatHD.Click += new System.EventHandler(this.btn_XuatHD_Click);
            // 
            // btn_ThemPD
            // 
            this.btn_ThemPD.BackColor = System.Drawing.Color.LightGreen;
            this.btn_ThemPD.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemPD.Location = new System.Drawing.Point(838, 419);
            this.btn_ThemPD.Margin = new System.Windows.Forms.Padding(5);
            this.btn_ThemPD.Name = "btn_ThemPD";
            this.btn_ThemPD.Size = new System.Drawing.Size(57, 63);
            this.btn_ThemPD.TabIndex = 2;
            this.btn_ThemPD.Text = "+";
            this.btn_ThemPD.UseVisualStyleBackColor = false;
            this.btn_ThemPD.Click += new System.EventHandler(this.btn_ThemPD_Click);
            // 
            // gcHD
            // 
            this.gcHD.DataSource = this.bdsPhieuDat;
            this.gcHD.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5);
            this.gcHD.Location = new System.Drawing.Point(59, 419);
            this.gcHD.MainView = this.gvHD;
            this.gcHD.Margin = new System.Windows.Forms.Padding(5);
            this.gcHD.Name = "gcHD";
            this.gcHD.Size = new System.Drawing.Size(769, 309);
            this.gcHD.TabIndex = 1;
            this.gcHD.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHD});
            // 
            // gvHD
            // 
            this.gvHD.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidPD2,
            this.colngay1,
            this.colidnv1});
            this.gvHD.DetailHeight = 546;
            this.gvHD.GridControl = this.gcHD;
            this.gvHD.Name = "gvHD";
            this.gvHD.OptionsBehavior.Editable = false;
            this.gvHD.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvHD_RowClick);
            // 
            // colidPD2
            // 
            this.colidPD2.Caption = "IDPD";
            this.colidPD2.FieldName = "idPD";
            this.colidPD2.MinWidth = 39;
            this.colidPD2.Name = "colidPD2";
            this.colidPD2.Visible = true;
            this.colidPD2.VisibleIndex = 0;
            this.colidPD2.Width = 146;
            // 
            // colngay1
            // 
            this.colngay1.Caption = "NGÀY";
            this.colngay1.FieldName = "ngay";
            this.colngay1.MinWidth = 39;
            this.colngay1.Name = "colngay1";
            this.colngay1.Visible = true;
            this.colngay1.VisibleIndex = 1;
            this.colngay1.Width = 146;
            // 
            // colidnv1
            // 
            this.colidnv1.Caption = "IDNV";
            this.colidnv1.FieldName = "idnv";
            this.colidnv1.MinWidth = 39;
            this.colidnv1.Name = "colidnv1";
            this.colidnv1.Visible = true;
            this.colidnv1.VisibleIndex = 2;
            this.colidnv1.Width = 146;
            // 
            // frmTheoDoiDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 855);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmTheoDoiDonHang";
            this.Text = "THEO DÕI ĐƠN HÀNG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuDat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCTDM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTDM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhieuDat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhieuDat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bdsPhieuDat;
        private System.Windows.Forms.BindingSource bdsCTDM;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gcCTDM;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCTDM;
        private DevExpress.XtraGrid.Columns.GridColumn colsoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colchuThich;
        private DevExpress.XtraGrid.Columns.GridColumn coltrangThai;
        private DevExpress.XtraGrid.Columns.GridColumn colgia;
        private DevExpress.XtraGrid.Columns.GridColumn colmama;
        private DevExpress.XtraGrid.Columns.GridColumn coltenma;
        private DevExpress.XtraGrid.Columns.GridColumn colidpd1;
        private DevExpress.XtraGrid.GridControl gcPhieuDat;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPhieuDat;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gcHD;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHD;
        private System.Windows.Forms.Button btn_XuatHD;
        private System.Windows.Forms.Button btn_ThemPD;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraGrid.Columns.GridColumn colidPD2;
        private DevExpress.XtraGrid.Columns.GridColumn colngay1;
        private DevExpress.XtraGrid.Columns.GridColumn colidnv1;
        private DevExpress.XtraGrid.Columns.GridColumn colidPD;
        private DevExpress.XtraGrid.Columns.GridColumn colngay;
        private DevExpress.XtraGrid.Columns.GridColumn colhoTenNV;
        private DevExpress.XtraGrid.Columns.GridColumn coltenBan;
        private DevExpress.XtraGrid.Columns.GridColumn coltenPhong;
    }
}