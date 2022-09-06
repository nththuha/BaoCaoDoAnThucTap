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
    public partial class frmNhanVien : Form
    {
        Repository.NhanVienRepository _repository = new Repository.NhanVienRepository();
        Repository.BoPhanRepository _repositoryBP = new Repository.BoPhanRepository();

        List<BoPhanModel> listBP;

        string button = "";

        public frmNhanVien()
        {
            InitializeComponent();
            khoiTao();
            loadComboBox();
            loadData();   
        }

        public void khoiTao()
        {
            etIDNV.Text = "";
            etHoTen.Text = "";
            etDiaChi.Text = "";
            etEmail.Text = "";
            etSDT.Text = "";
        }

        public async void loadData()
        {
            try
            {
                var listNV = await _repository.getList();
                gcNhanVien.DataSource = listNV;
                if(listNV.Count > 0) setGiaTri(0);
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi load data: " + e.Message, "Thông báo");
            }
        }

        public async void loadComboBox()
        {
            try
            {
                listBP = await _repositoryBP.getList();
                cbbMaBP.DataSource = listBP;
                cbbMaBP.DisplayMember = "maBP";
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi load data: " + e.Message, "Thông báo");
            }
        }

        private void setGiaTri(int num)
        {
            etIDNV.Text = gvNhanVien.GetRowCellValue(num, "idNV").ToString();
            etHoTen.Text = gvNhanVien.GetRowCellValue(num, "hoTen").ToString();
            etDiaChi.Text = gvNhanVien.GetRowCellValue(num, "diaChi").ToString();
            etEmail.Text = gvNhanVien.GetRowCellValue(num, "email").ToString();
            etSDT.Text = gvNhanVien.GetRowCellValue(num, "sdt").ToString();

            String temp = gvNhanVien.GetRowCellValue(num, "maBP").ToString();
            for (int i = 0; i < listBP.Count; i++)
            {
                if (listBP[i].maBP.Equals(temp))
                {
                    cbbMaBP.SelectedIndex = i;
                    break;
                }
            }

            lb_TenBP.Text = gvNhanVien.GetRowCellValue(num, "tenBP").ToString();
        }

        private void gvNhanVien_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int numrow = e.RowHandle;
            setGiaTri(numrow);
        }

        private void cbbMaBP_SelectedIndexChanged(object sender, EventArgs e)
        {
            BoPhanModel selectedItem = (BoPhanModel)cbbMaBP.SelectedItem;
            BoPhanModel bp = selectedItem;
            lb_TenBP.Text = bp.tenBP;
        }

        private void btn_Them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            khoiTao();
            button = "Them";
            btn_Them.Enabled = btn_CapNhat.Enabled = btn_Reload.Enabled = btn_Xoa.Enabled = false;
            btn_Luu.Enabled = btn_PhucHoi.Enabled = true;
            panel1.Enabled = true;
            gcNhanVien.Enabled = false;
        }

        private void btn_Reload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadData();
        }

        private void btn_CapNhat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            button = "CapNhat";
            btn_Them.Enabled = btn_CapNhat.Enabled = btn_Reload.Enabled = btn_Xoa.Enabled = false;
            btn_Luu.Enabled = btn_PhucHoi.Enabled = true;
            panel1.Enabled = true;
            gcNhanVien.Enabled = false;
        }

        private void btn_PhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsNhanVien.CancelEdit();
            btn_Reload_ItemClick(sender, e);
            gcNhanVien.Enabled = true;
            panel1.Enabled = false;

            btn_Them.Enabled = btn_Xoa.Enabled = btn_CapNhat.Enabled = btn_Thoat.Enabled = btn_Reload.Enabled = true;
            btn_PhucHoi.Enabled = btn_Luu.Enabled = false;
        }

        public async void delete(String maNV)
        {
            var check = await _repository.Delete(maNV);
            if (check.Equals("false")) MessageBox.Show("Xóa nhân viên thất bại!", "Thông báo");
            else MessageBox.Show("Xóa nhân viên thành công!", "Thông báo");
        }

        private void btn_Xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var maNV = etIDNV.Text.Trim();
            if (MessageBox.Show("Bạn có thật sự muốn xóa nhân viên " + maNV + "?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    delete(maNV);       
                    khoiTao();
                    loadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa loại món ăn thất bại!\n" + ex.Message, "Thông báo");
                }
            }
        }

        private void btn_Luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (etHoTen.Text.Trim().Equals(""))
            {
                MessageBox.Show("Họ tên không được để trống", "Thông báo", MessageBoxButtons.OK);
                etHoTen.Focus();
                return;
            }

            if (etEmail.Text.Trim().Equals(""))
            {
                MessageBox.Show("Email không được để trống", "Thông báo", MessageBoxButtons.OK);
                etEmail.Focus();
                return;
            }

            if (etDiaChi.Text.Trim().Equals(""))
            {
                MessageBox.Show("Địa chỉ không được để trống", "Thông báo", MessageBoxButtons.OK);
                etDiaChi.Focus();
                return;
            }

            if (etSDT.Text.Trim().Equals(""))
            {
                MessageBox.Show("Số điện thoại không được để trống", "Thông báo", MessageBoxButtons.OK);
                etSDT.Focus();
                return;
            }

            if (button.Equals("Them"))
            {
                NhanVienModel nhanVien = new NhanVienModel();
                nhanVien.hoTen = etHoTen.Text.Trim();
                nhanVien.email = etEmail.Text.Trim();
                nhanVien.diaChi = etDiaChi.Text.Trim();
                nhanVien.sdt = etSDT.Text.Trim();
                nhanVien.maBP = ((BoPhanModel)cbbMaBP.SelectedItem).maBP;
                try
                {
                    _repository.Add(nhanVien);
                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm nhân viên thất bại!\n" + ex.Message, "Thông báo");
                }
                btn_Them.Enabled = btn_CapNhat.Enabled = btn_Reload.Enabled = btn_Xoa.Enabled = true;
                btn_Luu.Enabled = btn_PhucHoi.Enabled = false;
                gcNhanVien.Enabled = true;
                panel1.Enabled = false;
            }
            else
            {
                NhanVienModel nhanVien = new NhanVienModel();
                nhanVien.idNV = int.Parse(etIDNV.Text.Trim());
                nhanVien.hoTen = etHoTen.Text.Trim();
                nhanVien.email = etEmail.Text.Trim();
                nhanVien.diaChi = etDiaChi.Text.Trim();
                nhanVien.sdt = etSDT.Text.Trim();
                nhanVien.maBP = ((BoPhanModel)cbbMaBP.SelectedItem).maBP;
                try
                {
                    _repository.Update(nhanVien);
                    MessageBox.Show("Cập nhật nhân viên thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cập nhật nhân viên thất bại!\n" + ex.Message, "Thông báo");
                }
                btn_Them.Enabled = btn_CapNhat.Enabled = btn_Reload.Enabled = btn_Xoa.Enabled = true;
                btn_Luu.Enabled = btn_PhucHoi.Enabled = false;
                gcNhanVien.Enabled = true;
                panel1.Enabled = false;
            }
            loadData();
        }

        private void btn_Thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
