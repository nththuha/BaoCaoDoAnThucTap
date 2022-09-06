using RestaurantManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagement
{
    public partial class frmTypeOfDishes : Form
    {
        Repository.LoaiMonAnRepository _repository = new Repository.LoaiMonAnRepository();
        int numrow;
        string button = "";

        public frmTypeOfDishes()
        {
            InitializeComponent();
            khoiTao();
            btn_Luu.Enabled = false;
            loadData();
            gvLoaiMonAn.SelectRow(0);
        }

        public void khoiTao()
        {
            txt_MaLMA.Text = "";
            txt_TenLMA.Text = "";
            txt_HinhAnh.Text = "";
            pbImage.LoadAsync("https://upload.wikimedia.org/wikipedia/commons/thumb/7/75/Flag_of_None_%28square%29.svg/768px-Flag_of_None_%28square%29.svg.png");
        }

        public async void loadData()
        {
            try
            {
                var listLMA = await _repository.getList();
                gcLoaiMonAn.DataSource = listLMA;
                if(listLMA.Count > 0) setGiaTri(0);
            }
            catch(Exception e)
            {
                MessageBox.Show("Lỗi load data: " + e.Message, "Thông báo");
            }
        }

        private void setGiaTri(int num)
        {
            txt_MaLMA.Text = gvLoaiMonAn.GetRowCellValue(num, "maLMA").ToString();
            txt_TenLMA.Text = gvLoaiMonAn.GetRowCellValue(num, "tenLMA").ToString();
            txt_HinhAnh.Text = gvLoaiMonAn.GetRowCellValue(num, "hinhAnh").ToString();
            pbImage.LoadAsync(gvLoaiMonAn.GetRowCellValue(num, "hinhAnh").ToString());
        }

        private void btn_Thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void gridViewLoaiMonAn_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            numrow = e.RowHandle;
            setGiaTri(numrow);
        }

        private void btn_Them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            khoiTao();
            button = "Them";
            btn_Them.Enabled = btn_CapNhat.Enabled = btn_Reload.Enabled = btn_Xoa.Enabled = false;
            btn_Luu.Enabled = btn_PhucHoi.Enabled = true;
            panelControl1.Enabled = false;
            panelControl2.Enabled = true;
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
            panelControl1.Enabled = false;
            panelControl2.Enabled = true;
            txt_MaLMA.Enabled = false;
        }

        private void btn_PhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsLoaiMonAn.CancelEdit();
            btn_Reload_ItemClick(sender, e);
            panelControl1.Enabled = true;
            panelControl2.Enabled = false;

            btn_Them.Enabled = btn_Xoa.Enabled = btn_CapNhat.Enabled = btn_Thoat.Enabled = btn_Reload.Enabled = true;
            btn_PhucHoi.Enabled = btn_Luu.Enabled = false;
        }

        private void btn_Luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txt_MaLMA.Text.Trim().Equals(""))
            {
                MessageBox.Show("Mã loại món ăn không được để trống", "Thông báo", MessageBoxButtons.OK);
                txt_MaLMA.Focus();
                return;
            }

            if (txt_TenLMA.Text.Trim().Equals(""))
            {
                MessageBox.Show("Tên loại món ăn không được để trống", "Thông báo", MessageBoxButtons.OK);
                txt_TenLMA.Focus();
                return;
            }

            if (txt_HinhAnh.Text.Trim().Equals(""))
            {
                MessageBox.Show("Hình ảnh không được để trống", "Thông báo", MessageBoxButtons.OK);
                txt_HinhAnh.Focus();
                return;
            }

            if (button.Equals("Them"))
            {
                LoaiMonAnModel loaiMonAn = new LoaiMonAnModel();
                loaiMonAn.maLMA = txt_MaLMA.Text.Trim();
                loaiMonAn.tenLMA = txt_TenLMA.Text.Trim();
                loaiMonAn.hinhAnh = txt_HinhAnh.Text.Trim();
                try
                {
                    _repository.Add(loaiMonAn);
                    MessageBox.Show("Thêm loại món ăn thành công!");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Thêm loại món ăn thất bại!\n" + ex.Message, "Thông báo");
                }
                btn_Them.Enabled = btn_CapNhat.Enabled = btn_Reload.Enabled = btn_Xoa.Enabled = true;
                btn_Luu.Enabled = btn_PhucHoi.Enabled = false;
                panelControl1.Enabled = true;
                panelControl2.Enabled = false;
            }
            else
            {
                LoaiMonAnModel loaiMonAn = new LoaiMonAnModel();
                loaiMonAn.maLMA = txt_MaLMA.Text.Trim();
                loaiMonAn.tenLMA = txt_TenLMA.Text.Trim();
                loaiMonAn.hinhAnh = txt_HinhAnh.Text.Trim();
                try
                {
                    _repository.Update(loaiMonAn);
                    MessageBox.Show("Cập nhật loại món ăn thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cập nhật loại món ăn thất bại!\n" + ex.Message, "Thông báo");
                }
                btn_Them.Enabled = btn_CapNhat.Enabled = btn_Reload.Enabled = btn_Xoa.Enabled = true;
                btn_Luu.Enabled = btn_PhucHoi.Enabled = false;
                panelControl1.Enabled = true;
                panelControl2.Enabled = false;
                txt_MaLMA.Enabled = true;
            }
            loadData();
        }

        private void btn_Xoa_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var maLMA = txt_MaLMA.Text;
            if (MessageBox.Show("Bạn có thật sự muốn xóa loại món ăn " + maLMA + "?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    delete(maLMA);
                    khoiTao();
                    loadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa loại món ăn thất bại!\n" + ex.Message, "Thông báo");
                }
            }
        }

        public async void delete(String maLMA)
        {
            var check = await _repository.Delete(maLMA);
            if(check.Equals("false")) MessageBox.Show("Xóa loại món ăn thất bại!");
            else MessageBox.Show("Xóa loại món ăn thành công!");
        }
    }
}
