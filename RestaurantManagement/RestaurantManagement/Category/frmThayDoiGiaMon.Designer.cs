
namespace RestaurantManagement
{
    partial class frmThayDoiGiaMon
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
            System.Windows.Forms.Label maMALabel;
            System.Windows.Forms.Label tenMALabel;
            System.Windows.Forms.Label giaLabel;
            System.Windows.Forms.Label ngayLabel;
            this.bdsThayDoiGiaMon = new System.Windows.Forms.BindingSource(this.components);
            this.bdsMonAn = new System.Windows.Forms.BindingSource(this.components);
            this.gcMonAn = new DevExpress.XtraGrid.GridControl();
            this.gvMonAn = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colmaMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltenMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltenlma = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcThayDoiGiaMon = new DevExpress.XtraGrid.GridControl();
            this.gvThayDoiGiaMon = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colgia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colngay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmama1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhoTenNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_XacNhan = new System.Windows.Forms.Button();
            this.deNgay = new DevExpress.XtraEditors.DateEdit();
            this.seGia = new DevExpress.XtraEditors.SpinEdit();
            this.etTenMA = new DevExpress.XtraEditors.TextEdit();
            this.etMaMA = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            maMALabel = new System.Windows.Forms.Label();
            tenMALabel = new System.Windows.Forms.Label();
            giaLabel = new System.Windows.Forms.Label();
            ngayLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdsThayDoiGiaMon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMonAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMonAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcThayDoiGiaMon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvThayDoiGiaMon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etTenMA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etMaMA.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // maMALabel
            // 
            maMALabel.AutoSize = true;
            maMALabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maMALabel.Location = new System.Drawing.Point(40, 83);
            maMALabel.Name = "maMALabel";
            maMALabel.Size = new System.Drawing.Size(121, 27);
            maMALabel.TabIndex = 1;
            maMALabel.Text = "Mã món ăn";
            // 
            // tenMALabel
            // 
            tenMALabel.AutoSize = true;
            tenMALabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenMALabel.Location = new System.Drawing.Point(42, 139);
            tenMALabel.Name = "tenMALabel";
            tenMALabel.Size = new System.Drawing.Size(126, 27);
            tenMALabel.TabIndex = 3;
            tenMALabel.Text = "Tên món ăn";
            // 
            // giaLabel
            // 
            giaLabel.AutoSize = true;
            giaLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            giaLabel.Location = new System.Drawing.Point(42, 199);
            giaLabel.Name = "giaLabel";
            giaLabel.Size = new System.Drawing.Size(46, 27);
            giaLabel.TabIndex = 5;
            giaLabel.Text = "Giá";
            // 
            // ngayLabel
            // 
            ngayLabel.AutoSize = true;
            ngayLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ngayLabel.Location = new System.Drawing.Point(42, 252);
            ngayLabel.Name = "ngayLabel";
            ngayLabel.Size = new System.Drawing.Size(63, 27);
            ngayLabel.TabIndex = 7;
            ngayLabel.Text = "Ngày";
            // 
            // bdsThayDoiGiaMon
            // 
            this.bdsThayDoiGiaMon.DataSource = typeof(RestaurantManagement.Model.ThayDoiGiaMonModel);
            // 
            // bdsMonAn
            // 
            this.bdsMonAn.DataSource = typeof(RestaurantManagement.Model.MonAnModel);
            // 
            // gcMonAn
            // 
            this.gcMonAn.DataSource = this.bdsMonAn;
            this.gcMonAn.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcMonAn.Location = new System.Drawing.Point(0, 0);
            this.gcMonAn.MainView = this.gvMonAn;
            this.gcMonAn.Name = "gcMonAn";
            this.gcMonAn.Size = new System.Drawing.Size(1522, 216);
            this.gcMonAn.TabIndex = 0;
            this.gcMonAn.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMonAn});
            // 
            // gvMonAn
            // 
            this.gvMonAn.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colmaMA,
            this.coltenMA,
            this.coltenlma});
            this.gvMonAn.GridControl = this.gcMonAn;
            this.gvMonAn.Name = "gvMonAn";
            this.gvMonAn.OptionsBehavior.Editable = false;
            this.gvMonAn.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvMonAn_RowClick);
            // 
            // colmaMA
            // 
            this.colmaMA.Caption = "MÃ MÓN ĂN";
            this.colmaMA.FieldName = "maMA";
            this.colmaMA.MinWidth = 25;
            this.colmaMA.Name = "colmaMA";
            this.colmaMA.Visible = true;
            this.colmaMA.VisibleIndex = 0;
            this.colmaMA.Width = 94;
            // 
            // coltenMA
            // 
            this.coltenMA.Caption = "TÊN MÓN ĂN";
            this.coltenMA.FieldName = "tenMA";
            this.coltenMA.MinWidth = 25;
            this.coltenMA.Name = "coltenMA";
            this.coltenMA.Visible = true;
            this.coltenMA.VisibleIndex = 1;
            this.coltenMA.Width = 94;
            // 
            // coltenlma
            // 
            this.coltenlma.Caption = "TÊN LOẠI MÓN ĂN";
            this.coltenlma.FieldName = "tenlma";
            this.coltenlma.MinWidth = 25;
            this.coltenlma.Name = "coltenlma";
            this.coltenlma.Visible = true;
            this.coltenlma.VisibleIndex = 2;
            this.coltenlma.Width = 94;
            // 
            // gcThayDoiGiaMon
            // 
            this.gcThayDoiGiaMon.DataSource = this.bdsThayDoiGiaMon;
            this.gcThayDoiGiaMon.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcThayDoiGiaMon.Location = new System.Drawing.Point(0, 216);
            this.gcThayDoiGiaMon.MainView = this.gvThayDoiGiaMon;
            this.gcThayDoiGiaMon.Name = "gcThayDoiGiaMon";
            this.gcThayDoiGiaMon.Size = new System.Drawing.Size(1522, 229);
            this.gcThayDoiGiaMon.TabIndex = 1;
            this.gcThayDoiGiaMon.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvThayDoiGiaMon});
            // 
            // gvThayDoiGiaMon
            // 
            this.gvThayDoiGiaMon.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colgia,
            this.colngay,
            this.colmama1,
            this.colhoTenNV});
            this.gvThayDoiGiaMon.GridControl = this.gcThayDoiGiaMon;
            this.gvThayDoiGiaMon.Name = "gvThayDoiGiaMon";
            this.gvThayDoiGiaMon.OptionsBehavior.Editable = false;
            this.gvThayDoiGiaMon.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvThayDoiGiaMon_RowClick);
            // 
            // colgia
            // 
            this.colgia.Caption = "GIÁ";
            this.colgia.DisplayFormat.FormatString = "n0";
            this.colgia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colgia.FieldName = "gia";
            this.colgia.MinWidth = 25;
            this.colgia.Name = "colgia";
            this.colgia.Visible = true;
            this.colgia.VisibleIndex = 2;
            this.colgia.Width = 94;
            // 
            // colngay
            // 
            this.colngay.Caption = "NGÀY";
            this.colngay.FieldName = "ngay";
            this.colngay.MinWidth = 25;
            this.colngay.Name = "colngay";
            this.colngay.Visible = true;
            this.colngay.VisibleIndex = 1;
            this.colngay.Width = 94;
            // 
            // colmama1
            // 
            this.colmama1.Caption = "MÃ MÓN ĂN";
            this.colmama1.FieldName = "mama";
            this.colmama1.MinWidth = 25;
            this.colmama1.Name = "colmama1";
            this.colmama1.Visible = true;
            this.colmama1.VisibleIndex = 0;
            this.colmama1.Width = 94;
            // 
            // colhoTenNV
            // 
            this.colhoTenNV.Caption = "HỌ TÊN NHÂN VIÊN";
            this.colhoTenNV.FieldName = "hoTenNV";
            this.colhoTenNV.MinWidth = 25;
            this.colhoTenNV.Name = "colhoTenNV";
            this.colhoTenNV.Visible = true;
            this.colhoTenNV.VisibleIndex = 3;
            this.colhoTenNV.Width = 94;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_Xoa);
            this.panelControl1.Controls.Add(this.btn_XacNhan);
            this.panelControl1.Controls.Add(ngayLabel);
            this.panelControl1.Controls.Add(this.deNgay);
            this.panelControl1.Controls.Add(giaLabel);
            this.panelControl1.Controls.Add(this.seGia);
            this.panelControl1.Controls.Add(tenMALabel);
            this.panelControl1.Controls.Add(this.etTenMA);
            this.panelControl1.Controls.Add(maMALabel);
            this.panelControl1.Controls.Add(this.etMaMA);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 445);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1522, 335);
            this.panelControl1.TabIndex = 2;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(921, 83);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(118, 73);
            this.btn_Xoa.TabIndex = 10;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_XacNhan
            // 
            this.btn_XacNhan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XacNhan.Location = new System.Drawing.Point(764, 83);
            this.btn_XacNhan.Name = "btn_XacNhan";
            this.btn_XacNhan.Size = new System.Drawing.Size(118, 73);
            this.btn_XacNhan.TabIndex = 9;
            this.btn_XacNhan.Text = "Thêm";
            this.btn_XacNhan.UseVisualStyleBackColor = true;
            this.btn_XacNhan.Click += new System.EventHandler(this.btn_XacNhan_Click);
            // 
            // deNgay
            // 
            this.deNgay.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsThayDoiGiaMon, "ngay", true));
            this.deNgay.EditValue = null;
            this.deNgay.Location = new System.Drawing.Point(193, 247);
            this.deNgay.Name = "deNgay";
            this.deNgay.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deNgay.Properties.Appearance.Options.UseFont = true;
            this.deNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgay.Size = new System.Drawing.Size(477, 32);
            this.deNgay.TabIndex = 8;
            // 
            // seGia
            // 
            this.seGia.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsThayDoiGiaMon, "gia", true));
            this.seGia.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seGia.Location = new System.Drawing.Point(193, 196);
            this.seGia.Name = "seGia";
            this.seGia.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seGia.Properties.Appearance.Options.UseFont = true;
            this.seGia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seGia.Size = new System.Drawing.Size(477, 32);
            this.seGia.TabIndex = 6;
            // 
            // etTenMA
            // 
            this.etTenMA.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMonAn, "tenMA", true));
            this.etTenMA.Enabled = false;
            this.etTenMA.Location = new System.Drawing.Point(193, 136);
            this.etTenMA.Name = "etTenMA";
            this.etTenMA.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etTenMA.Properties.Appearance.Options.UseFont = true;
            this.etTenMA.Size = new System.Drawing.Size(477, 32);
            this.etTenMA.TabIndex = 4;
            // 
            // etMaMA
            // 
            this.etMaMA.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsMonAn, "maMA", true));
            this.etMaMA.Enabled = false;
            this.etMaMA.Location = new System.Drawing.Point(193, 80);
            this.etMaMA.Name = "etMaMA";
            this.etMaMA.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etMaMA.Properties.Appearance.Options.UseFont = true;
            this.etMaMA.Size = new System.Drawing.Size(477, 32);
            this.etMaMA.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ THAY ĐỔI GIÁ MÓN";
            // 
            // frmThayDoiGiaMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1522, 780);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gcThayDoiGiaMon);
            this.Controls.Add(this.gcMonAn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmThayDoiGiaMon";
            this.Text = "THAY ĐỔI GIÁ MÓN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.bdsThayDoiGiaMon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMonAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMonAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcThayDoiGiaMon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvThayDoiGiaMon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etTenMA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etMaMA.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bdsMonAn;
        private System.Windows.Forms.BindingSource bdsThayDoiGiaMon;
        private DevExpress.XtraGrid.GridControl gcMonAn;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMonAn;
        private DevExpress.XtraGrid.GridControl gcThayDoiGiaMon;
        private DevExpress.XtraGrid.Views.Grid.GridView gvThayDoiGiaMon;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_XacNhan;
        private DevExpress.XtraEditors.DateEdit deNgay;
        private DevExpress.XtraEditors.SpinEdit seGia;
        private DevExpress.XtraEditors.TextEdit etTenMA;
        private DevExpress.XtraEditors.TextEdit etMaMA;
        private DevExpress.XtraGrid.Columns.GridColumn colmaMA;
        private DevExpress.XtraGrid.Columns.GridColumn coltenMA;
        private DevExpress.XtraGrid.Columns.GridColumn coltenlma;
        private DevExpress.XtraGrid.Columns.GridColumn colgia;
        private DevExpress.XtraGrid.Columns.GridColumn colngay;
        private DevExpress.XtraGrid.Columns.GridColumn colmama1;
        private DevExpress.XtraGrid.Columns.GridColumn colhoTenNV;
        private System.Windows.Forms.Button btn_Xoa;
    }
}