using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RestaurantManagement
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                Program.formDangNhap = new frmDangNhap();
                Program.formDangNhap.MdiParent = this;
                Program.formDangNhap.Show();
            }
        }

        private void barButtonItem3_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmTypeOfDishes));
            if (frm != null) frm.Activate();
            else
            {
                Program.formTypeOfDishes = new frmTypeOfDishes();
                Program.formTypeOfDishes.MdiParent = this;
                Program.formTypeOfDishes.Show();
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDishes));
            if (frm != null) frm.Activate();
            else
            {
                Program.formDishes = new frmDishes();
                Program.formDishes.MdiParent = this;
                Program.formDishes.Show();
            }
        }

        private void btn_DangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                btn_DangNhap.Enabled = true;
                btn_DangXuat.Enabled = btn_LoaiMonAn.Enabled = btn_MonAn.Enabled = btn_TheoDoiDonHang.Enabled = btnPhongBan.Enabled = btnThayDoiGiaMon.Enabled = btnNhanVien.Enabled = btnTaiKhoan.Enabled = btn_ChiTietBan.Enabled = btn_ThongKe.Enabled = false;

                Form frm = this.CheckExists(typeof(frmTypeOfDishes));
                if (frm != null) frm.Close();

                frm = this.CheckExists(typeof(frmDishes));
                if (frm != null) frm.Close();

                frm = this.CheckExists(typeof(frmTheoDoiDonHang));
                if (frm != null) frm.Close();

                frm = this.CheckExists(typeof(frmThayDoiGiaMon));
                if (frm != null) frm.Close();

                frm = this.CheckExists(typeof(frmPhongBan));
                if (frm != null) frm.Close();

                frm = this.CheckExists(typeof(frmNhanVien));
                if (frm != null) frm.Close();

                frm = this.CheckExists(typeof(frmTaiKhoan));
                if (frm != null) frm.Close();

                frm = this.CheckExists(typeof(frmChiTietBan));
                if (frm != null) frm.Close();

                frm = this.CheckExists(typeof(frmThongKe));
                if (frm != null) frm.Close();

                tssl_MaNV.Text = tssl_HoTen.Text = tssl_Quyen.Text = "";
            }
        }

        private void btn_TheoDoiDonHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmTheoDoiDonHang));
            if (frm != null) frm.Activate();
            else
            {
                Program.formTheoDoiDonHang = new frmTheoDoiDonHang();
                Program.formTheoDoiDonHang.MdiParent = this;
                Program.formTheoDoiDonHang.Show();
            }
        }

        private void btnPhongBan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmPhongBan));
            if (frm != null) frm.Activate();
            else
            {
                Program.formPhongBan = new frmPhongBan();
                Program.formPhongBan.MdiParent = this;
                Program.formPhongBan.Show();
            }
        }

        private void btnThayDoiGiaMon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmThayDoiGiaMon));
            if (frm != null) frm.Activate();
            else
            {
                Program.formThayDoiGiaMon = new frmThayDoiGiaMon();
                Program.formThayDoiGiaMon.MdiParent = this;
                Program.formThayDoiGiaMon.Show();
            }
        }

        private void btnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmNhanVien));
            if (frm != null) frm.Activate();
            else
            {
                Program.formNhanVien = new frmNhanVien();
                Program.formNhanVien.MdiParent = this;
                Program.formNhanVien.Show();
            }
        }

        private void btnTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmTaiKhoan));
            if (frm != null) frm.Activate();
            else
            {
                Program.formTaiKhoan = new frmTaiKhoan();
                Program.formTaiKhoan.MdiParent = this;
                Program.formTaiKhoan.Show();
            }
        }

        private void btn_ChiTietBan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmChiTietBan));
            if (frm != null) frm.Activate();
            else
            {
                Program.formChiTietBan = new frmChiTietBan();
                Program.formChiTietBan.MdiParent = this;
                Program.formChiTietBan.Show();
            }
        }

        private void btn_ThongKe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmThongKe));
            if (frm != null) frm.Activate();
            else
            {
                Program.formThongKe = new frmThongKe();
                Program.formThongKe.MdiParent = this;
                Program.formThongKe.Show();
            }
        }
    }
}
