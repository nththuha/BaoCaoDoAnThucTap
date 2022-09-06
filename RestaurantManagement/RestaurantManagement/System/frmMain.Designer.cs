
namespace RestaurantManagement
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_DangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btn_MonAn = new DevExpress.XtraBars.BarButtonItem();
            this.btn_LoaiMonAn = new DevExpress.XtraBars.BarButtonItem();
            this.btn_TheoDoiDonHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhongBan = new DevExpress.XtraBars.BarButtonItem();
            this.btnThayDoiGiaMon = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ChiTietBan = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ThongKe = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssl_MaNV = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_HoTen = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_Quyen = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btn_DangNhap,
            this.btn_DangXuat,
            this.btn_MonAn,
            this.btn_LoaiMonAn,
            this.btn_TheoDoiDonHang,
            this.btnPhongBan,
            this.btnThayDoiGiaMon,
            this.btnNhanVien,
            this.btnTaiKhoan,
            this.btn_ChiTietBan,
            this.btn_ThongKe});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl1.MaxItemId = 14;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage2,
            this.ribbonPage1,
            this.ribbonPage3});
            this.ribbonControl1.Size = new System.Drawing.Size(1335, 193);
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.Caption = "Login";
            this.btn_DangNhap.Id = 1;
            this.btn_DangNhap.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_DangNhap.ImageOptions.SvgImage")));
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.Caption = "Logout";
            this.btn_DangXuat.Enabled = false;
            this.btn_DangXuat.Id = 2;
            this.btn_DangXuat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_DangXuat.ImageOptions.SvgImage")));
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DangXuat_ItemClick);
            // 
            // btn_MonAn
            // 
            this.btn_MonAn.Caption = "Món ăn";
            this.btn_MonAn.Enabled = false;
            this.btn_MonAn.Id = 4;
            this.btn_MonAn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_MonAn.ImageOptions.Image")));
            this.btn_MonAn.Name = "btn_MonAn";
            this.btn_MonAn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_MonAn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // btn_LoaiMonAn
            // 
            this.btn_LoaiMonAn.Caption = "Loại món ăn";
            this.btn_LoaiMonAn.Enabled = false;
            this.btn_LoaiMonAn.Id = 5;
            this.btn_LoaiMonAn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_LoaiMonAn.ImageOptions.Image")));
            this.btn_LoaiMonAn.Name = "btn_LoaiMonAn";
            this.btn_LoaiMonAn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_LoaiMonAn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick_1);
            // 
            // btn_TheoDoiDonHang
            // 
            this.btn_TheoDoiDonHang.Caption = "Theo dõi đơn hàng";
            this.btn_TheoDoiDonHang.Enabled = false;
            this.btn_TheoDoiDonHang.Id = 6;
            this.btn_TheoDoiDonHang.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_TheoDoiDonHang.ImageOptions.SvgImage")));
            this.btn_TheoDoiDonHang.Name = "btn_TheoDoiDonHang";
            this.btn_TheoDoiDonHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_TheoDoiDonHang_ItemClick);
            // 
            // btnPhongBan
            // 
            this.btnPhongBan.Caption = "Phòng Bàn";
            this.btnPhongBan.Enabled = false;
            this.btnPhongBan.Id = 7;
            this.btnPhongBan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPhongBan.ImageOptions.Image")));
            this.btnPhongBan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPhongBan.ImageOptions.LargeImage")));
            this.btnPhongBan.Name = "btnPhongBan";
            this.btnPhongBan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhongBan_ItemClick);
            // 
            // btnThayDoiGiaMon
            // 
            this.btnThayDoiGiaMon.Caption = "Thay đổi giá món";
            this.btnThayDoiGiaMon.Enabled = false;
            this.btnThayDoiGiaMon.Id = 9;
            this.btnThayDoiGiaMon.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThayDoiGiaMon.ImageOptions.SvgImage")));
            this.btnThayDoiGiaMon.Name = "btnThayDoiGiaMon";
            this.btnThayDoiGiaMon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThayDoiGiaMon_ItemClick);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Caption = "Nhân viên";
            this.btnNhanVien.Enabled = false;
            this.btnNhanVien.Id = 10;
            this.btnNhanVien.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNhanVien.ImageOptions.SvgImage")));
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhanVien_ItemClick);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.Caption = "Tài khoản";
            this.btnTaiKhoan.Enabled = false;
            this.btnTaiKhoan.Id = 11;
            this.btnTaiKhoan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTaiKhoan.ImageOptions.SvgImage")));
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaiKhoan_ItemClick);
            // 
            // btn_ChiTietBan
            // 
            this.btn_ChiTietBan.Caption = "Chi Tiết Bàn";
            this.btn_ChiTietBan.Enabled = false;
            this.btn_ChiTietBan.Id = 12;
            this.btn_ChiTietBan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_ChiTietBan.ImageOptions.Image")));
            this.btn_ChiTietBan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_ChiTietBan.ImageOptions.LargeImage")));
            this.btn_ChiTietBan.Name = "btn_ChiTietBan";
            this.btn_ChiTietBan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_ChiTietBan_ItemClick);
            // 
            // btn_ThongKe
            // 
            this.btn_ThongKe.Caption = "Thống kê doanh thu theo tháng";
            this.btn_ThongKe.Enabled = false;
            this.btn_ThongKe.Id = 13;
            this.btn_ThongKe.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThongKe.ImageOptions.Image")));
            this.btn_ThongKe.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_ThongKe.ImageOptions.LargeImage")));
            this.btn_ThongKe.Name = "btn_ThongKe";
            this.btn_ThongKe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_ThongKe_ItemClick);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup7});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Login";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_DangNhap);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_DangXuat);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.btnTaiKhoan);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Danh mục";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_LoaiMonAn);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_MonAn);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnThayDoiGiaMon);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnPhongBan);
            this.ribbonPageGroup4.ItemLinks.Add(this.btn_ChiTietBan);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnNhanVien);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup8});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Quản lý";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_TheoDoiDonHang);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.btn_ThongKe);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssl_MaNV,
            this.tssl_HoTen,
            this.tssl_Quyen});
            this.statusStrip1.Location = new System.Drawing.Point(0, 697);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1335, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssl_MaNV
            // 
            this.tssl_MaNV.Name = "tssl_MaNV";
            this.tssl_MaNV.Size = new System.Drawing.Size(0, 16);
            // 
            // tssl_HoTen
            // 
            this.tssl_HoTen.Name = "tssl_HoTen";
            this.tssl_HoTen.Size = new System.Drawing.Size(0, 16);
            // 
            // tssl_Quyen
            // 
            this.tssl_Quyen.Name = "tssl_Quyen";
            this.tssl_Quyen.Size = new System.Drawing.Size(0, 16);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 719);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Restaurant Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        public DevExpress.XtraBars.BarButtonItem btn_DangNhap;
        public DevExpress.XtraBars.BarButtonItem btn_DangXuat;
        public DevExpress.XtraBars.BarButtonItem btn_MonAn;
        public DevExpress.XtraBars.BarButtonItem btn_LoaiMonAn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel tssl_MaNV;
        public System.Windows.Forms.ToolStripStatusLabel tssl_HoTen;
        public System.Windows.Forms.ToolStripStatusLabel tssl_Quyen;
        public DevExpress.XtraBars.BarButtonItem btn_TheoDoiDonHang;
        public DevExpress.XtraBars.BarButtonItem btnPhongBan;
        public DevExpress.XtraBars.BarButtonItem btnThayDoiGiaMon;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        public DevExpress.XtraBars.BarButtonItem btnNhanVien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        public DevExpress.XtraBars.BarButtonItem btnTaiKhoan;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        public DevExpress.XtraBars.BarButtonItem btn_ThongKe;
        public DevExpress.XtraBars.BarButtonItem btn_ChiTietBan;
    }
}

