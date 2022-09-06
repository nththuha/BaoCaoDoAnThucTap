using DevExpress.Skins;
using DevExpress.UserSkins;
using RestaurantManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RestaurantManagement
{
    static class Program
    {
        public static frmMain frmChinh;

        public static frmDishes formDishes;
        public static frmDangNhap formDangNhap;
        public static frmTheoDoiDonHang formTheoDoiDonHang;
        public static frmThayDoiGiaMon formThayDoiGiaMon;
        public static frmPhongBan formPhongBan;
        public static frmNhanVien formNhanVien;
        public static frmTaiKhoan formTaiKhoan;
        public static frmKhachHang formKhachHang;
        public static frmChiTietBan formChiTietBan;
        public static frmThongKe formThongKe;
        public static mesPhongBan mesPhongBan;

        public static String URL = "https://api-restaurantmanagement.herokuapp.com/api/";
        public static String maLMA = "";
        internal static frmTypeOfDishes formTypeOfDishes;

        public static NhanVienModel nhanVien;
        public static HoaDonModel hoaDon;

        public static String luaChonPB = "";
        public static String actionPB = "";

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmChinh = new frmMain();
            Application.Run(frmChinh);
        }
    }
}
