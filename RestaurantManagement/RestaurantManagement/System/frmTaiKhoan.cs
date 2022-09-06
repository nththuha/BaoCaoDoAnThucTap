using RestaurantManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagement
{
    public partial class frmTaiKhoan : Form
    {
        Repository.NhanVienRepository _repositoryNV = new Repository.NhanVienRepository();
        Repository.TaiKhoanRepository _repositoryTK = new Repository.TaiKhoanRepository();

        int numrow = -1;

        public frmTaiKhoan()
        {
            InitializeComponent();
            khoiTao();
            btn_Luu.Enabled = btn_Them.Enabled = btn_Reset.Enabled = false;
            loadListNVAsync();
            panel1.Enabled = false;
        }

        private async void loadListNVAsync()
        {
            try
            {
                var listNV = await _repositoryNV.getList();
                gcNhanVien.DataSource = listNV;
                if(listNV.Count > 0) layTaiKhoanTheoIDNV(listNV[0].idNV);
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi: " + e.Message, "Thông báo");
            }
        }

        private void khoiTao()
        {
            txt_MaTK.Text = "";
        }

        private void gvNhanVien_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            numrow = e.RowHandle;
            int idnv = int.Parse(gvNhanVien.GetRowCellValue(numrow, "idNV").ToString());
            layTaiKhoanTheoIDNV(idnv);
        }

        private async void layTaiKhoanTheoIDNV(int idnv)
        {
            try
            {
                TaiKhoanModel tk = await _repositoryTK.layTaiKhoanTheoIDNV(idnv);
                if(tk.maTK != null)
                {
                    txt_MaTK.Text = tk.maTK;
                    btn_Them.Enabled = false;
                    btn_Reset.Enabled = true;
                    panel1.Enabled = false;
                }
                else
                {
                    txt_MaTK.Text = "";
                    btn_Them.Enabled = true;
                    btn_Reset.Enabled = false;
                    panel1.Enabled = true;
                    khoiTao();
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Lỗi: " + e.Message, "Thông báo");
            }
        }

        private void btn_Reload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadListNVAsync();
        }

        private void btn_Thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btn_PhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsNhanVien.CancelEdit();
            btn_Reload_ItemClick(sender, e);
            gcNhanVien.Enabled = true;
            panel1.Enabled = false;

            btn_Thoat.Enabled = btn_Reload.Enabled = true;
            btn_PhucHoi.Enabled = btn_Luu.Enabled = btn_Them.Enabled = btn_Reset.Enabled = false;
        }

        private void btn_Them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txt_MaTK.Text.Trim().Equals(""))
            {
                MessageBox.Show("Mã tài khoản không được để trống", "Thông báo", MessageBoxButtons.OK);
                txt_MaTK.Focus();
                return;
            }

            String matKhau = laySoNgauNhien();
            String tenTK = txt_MaTK.Text;
            int idNV = int.Parse(gvNhanVien.GetRowCellValue(numrow, "idNV").ToString());
            TaiKhoanModel tk = new TaiKhoanModel();
            tk.maTK = tenTK;
            tk.matKhau = matKhau;
            tk.idnv = idNV;
            _repositoryTK.themTaiKhoan(tk);
            MessageBox.Show("Tạo tài khoản thành công!\nTài khoản: " + tenTK + "\nMật khẩu: " + matKhau, "Thông báo");
            loadListNVAsync();
        }

        private void btn_CapNhat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String matKhau = laySoNgauNhien();
            String tenTK = txt_MaTK.Text;
            int idNV = int.Parse(gvNhanVien.GetRowCellValue(numrow, "idNV").ToString());
            TaiKhoanModel tk = new TaiKhoanModel();
            tk.maTK = tenTK;
            tk.matKhau = matKhau;
            tk.idnv = idNV;
            _repositoryTK.suaTaiKhoan(tk);
            MessageBox.Show("Reset mật khẩu thành công!\nTài khoản: " + tenTK + "\nMật khẩu mới: " + matKhau, "Thông báo");
            loadListNVAsync();
        }

        private void btn_Luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txt_MaTK.Text.Trim().Equals(""))
            {
                MessageBox.Show("Mã tài khoản không được để trống", "Thông báo", MessageBoxButtons.OK);
                txt_MaTK.Focus();
                return;
            }
            
            loadListNVAsync();
        }

        private String laySoNgauNhien()
        {
            String so = "";
            Random rd = new Random();
            so = rd.Next(100000, 999999).ToString();
            return so;
        }
    }
}
