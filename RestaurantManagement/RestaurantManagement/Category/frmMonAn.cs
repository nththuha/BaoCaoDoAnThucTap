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
    public partial class frmDishes : Form
    {
        Repository.MonAnRepository _repository = new Repository.MonAnRepository();
        Repository.LoaiMonAnRepository _repositoryLMA = new Repository.LoaiMonAnRepository();

        List<LoaiMonAnModel> listLMA = new List<LoaiMonAnModel>();

        int numrow;
        string button = "";

        public frmDishes()
        {
            InitializeComponent();
            khoiTao();
            btn_Luu.Enabled = false;
            loadComboBox();
            loadData();
        }

        public async void loadComboBox()
        {
            try
            { 
                listLMA = await _repositoryLMA.getList();
                cbb_MaLMA.DataSource = listLMA;
                cbb_MaLMA.DisplayMember = "maLMA";
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi load data: " + e.Message, "Thông báo");
            }
        }

        private void khoiTao()
        {
            txt_MaMA.Text = "";
            txt_TenMA.Text = "";
            txt_TrangThai.Text = "";
            txt_HinhAnh.Text = "";
            txt_ChuThich.Text = "";
            pbImage.LoadAsync("https://upload.wikimedia.org/wikipedia/commons/thumb/7/75/Flag_of_None_%28square%29.svg/768px-Flag_of_None_%28square%29.svg.png");
        }

        public async void loadData()
        {
            try
            {
                var listMA = await _repository.getList();
                MonAnGridControl.DataSource = listMA;
                if(listMA.Count > 0) setGiaTri(0);
            }
            catch(Exception e)
            {
                MessageBox.Show("Lỗi: " + e.Message, "Thông báo");
            }
        }

        private void setGiaTri(int num)
        {
            txt_MaMA.Text = gridViewMonAn.GetRowCellValue(num, "maMA").ToString();
            txt_TenMA.Text = gridViewMonAn.GetRowCellValue(num, "tenMA").ToString();
            txt_HinhAnh.Text = gridViewMonAn.GetRowCellValue(num, "hinhAnh").ToString();
            txt_ChuThich.Text = gridViewMonAn.GetRowCellValue(num, "chuThich").ToString();
            txt_TrangThai.Text = gridViewMonAn.GetRowCellValue(num, "trangThai").ToString();
            pbImage.LoadAsync(gridViewMonAn.GetRowCellValue(num, "hinhAnh").ToString());

            String temp = gridViewMonAn.GetRowCellValue(num, "malma").ToString();
            for (int i = 0; i < listLMA.Count; i++)
            {
                if (listLMA[i].maLMA.Equals(temp))
                {
                    cbb_MaLMA.SelectedIndex = i;
                    break;
                }
            }
        }

        private void btn_Reload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadData();
        }

        private void btn_Thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void gridViewMonAn_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            numrow = e.RowHandle;
            setGiaTri(numrow);
        }

        private void btn_Them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            button = "Them";
            khoiTao();
            btn_Them.Enabled = btn_CapNhat.Enabled = btn_Reload.Enabled = btn_Xoa.Enabled = false;
            btn_Luu.Enabled = btn_PhucHoi.Enabled = true;
            panelControl1.Enabled = false;
            panelControl2.Enabled = true;
        }

        private void btn_ChinhSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            button = "ChinhSua";
            btn_Them.Enabled = btn_CapNhat.Enabled = btn_Reload.Enabled = btn_Xoa.Enabled = false;
            btn_Luu.Enabled = btn_PhucHoi.Enabled = true;
            panelControl1.Enabled = false;
            panelControl2.Enabled = true;

            txt_MaMA.Enabled = false;
        }

        private void btn_PhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsMonAn.CancelEdit();
            btn_Reload_ItemClick(sender, e);
            panelControl1.Enabled = true;
            panelControl2.Enabled = false;

            btn_Them.Enabled = btn_Xoa.Enabled = btn_CapNhat.Enabled = btn_Thoat.Enabled = btn_Reload.Enabled = true;
            btn_PhucHoi.Enabled = btn_Luu.Enabled = false;
        }

        private void btn_Xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var maMA = txt_MaMA.Text;
            if (MessageBox.Show("Bạn có thật sự muốn xóa món ăn " + maMA + "?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                delete(maMA);
                loadData();
                khoiTao();
            }
        }

        public async void delete(String maMA)
        {
            var check = await _repository.Delete(maMA);
            if (check.Equals("false")) MessageBox.Show("Xóa món ăn thất bại!");
            else MessageBox.Show("Xóa món ăn thành công!");
        }

        private void btn_Luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txt_MaMA.Text.Trim().Equals(""))
            {
                MessageBox.Show("Mã món ăn không được để trống", "Thông báo", MessageBoxButtons.OK);
                txt_MaMA.Focus();
                return;
            }

            if (txt_TenMA.Text.Trim().Equals(""))
            {
                MessageBox.Show("Tên món ăn không được để trống", "Thông báo", MessageBoxButtons.OK);
                txt_TenMA.Focus();
                return;
            }

            if (txt_HinhAnh.Text.Trim().Equals(""))
            {
                MessageBox.Show("Hình ảnh không được để trống", "Thông báo", MessageBoxButtons.OK);
                txt_HinhAnh.Focus();
                return;
            }
            if (txt_ChuThich.Text.Trim().Equals(""))
            {
                MessageBox.Show("Chú thích không được để trống", "Thông báo", MessageBoxButtons.OK);
                txt_ChuThich.Focus();
                return;
            }
            if (txt_TrangThai.Text.Trim().Equals(""))
            {
                MessageBox.Show("Trạng thái không được để trống", "Thông báo", MessageBoxButtons.OK);
                txt_TrangThai.Focus();
                return;
            }

            if (button.Equals("Them"))
            {
                var monAn = new MonAnModel();
                monAn.maMA = txt_MaMA.Text.Trim();
                monAn.tenMA = txt_TenMA.Text.Trim();
                monAn.hinhAnh = txt_HinhAnh.Text.Trim();
                monAn.chuThich = txt_ChuThich.Text.Trim();
                monAn.trangThai = txt_TrangThai.Text.Trim();
                monAn.malma = ((LoaiMonAnModel)cbb_MaLMA.SelectedItem).maLMA;
                try
                {
                    _repository.Add(monAn);
                    MessageBox.Show("Thêm món ăn thành công!", "Thông báo"); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm món ăn thất bại!\n" + ex.Message, "Thông báo");
                }
                btn_Them.Enabled = btn_CapNhat.Enabled = btn_Reload.Enabled = btn_Xoa.Enabled = true;
                btn_Luu.Enabled = btn_PhucHoi.Enabled = false;
                panelControl1.Enabled = true;
                panelControl2.Enabled = false;
            }
            else
            {
                MonAnModel monAn = new MonAnModel();
                monAn.maMA = txt_MaMA.Text.Trim();
                monAn.tenMA = txt_TenMA.Text.Trim();
                monAn.hinhAnh = txt_HinhAnh.Text.Trim();
                monAn.chuThich = txt_ChuThich.Text.Trim();
                monAn.trangThai = txt_TrangThai.Text.Trim();
                monAn.malma = ((LoaiMonAnModel)cbb_MaLMA.SelectedItem).maLMA;
                try
                {
                    _repository.Update(monAn);
                    MessageBox.Show("Cập nhật món ăn thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cập nhật món ăn thất bại!\n" + ex.Message, "Thông báo");
                }
                btn_Them.Enabled = btn_CapNhat.Enabled = btn_Reload.Enabled = btn_Xoa.Enabled = true;
                btn_Luu.Enabled = btn_PhucHoi.Enabled = false;
                panelControl1.Enabled = true;
                panelControl2.Enabled = false;
                txt_MaMA.Enabled = true;
            }
            loadData();
        }

        private void cbb_MaLMA_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoaiMonAnModel selectedItem = (LoaiMonAnModel)cbb_MaLMA.SelectedItem;
            LoaiMonAnModel lma = selectedItem;
            lb_MaLMA.Text = lma.tenLMA;
        }
    }
}
