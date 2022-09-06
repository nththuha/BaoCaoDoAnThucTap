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
    public partial class frmPhongBan : Form
    {
        Repository.PhongRepository _repositoryP = new Repository.PhongRepository();
        Repository.BanRepository _repositoryB = new Repository.BanRepository();

        String vitri = "";

        public frmPhongBan()
        {
            InitializeComponent();
            khoiTaoPhong();
            khoiTaoBan();
            loadDataPhong();
            loadDataBan();
        }

        private void khoiTaoBan()
        {
            txt_MaBan.Text = "";
            txt_TenBan.Text = "";
            seSoGhe.Text = "0";
        }

        private void khoiTaoPhong()
        {
            txt_MaPhong.Text = "";
            txt_TenPhong.Text = "";
        }

        private async void loadDataBan()
        {
            try
            {
                var listB = await _repositoryB.getList();
                gcBan.DataSource = listB;
                if (listB.Count > 0) setGiaTriBan(0);
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi load data bàn: " + e.Message);
            }
        }

        public async void loadDataPhong()
        {
            try
            {
                var listP = await _repositoryP.getList();
                gcPhong.DataSource = listP;
                if (listP.Count > 0) setGiaTriPhong(0);
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi load data phòng: " + e.Message);
            }
        }
        private void setGiaTriPhong(int num)
        {
            txt_MaPhong.Text = gvPhong.GetRowCellValue(num, "maPhong").ToString();
            txt_TenPhong.Text = gvPhong.GetRowCellValue(num, "tenPhong").ToString();
        }

        private void setGiaTriBan(int num)
        {
            txt_MaBan.Text = gvBan.GetRowCellValue(num, "maBan").ToString();
            txt_TenBan.Text = gvBan.GetRowCellValue(num, "tenBan").ToString();
            seSoGhe.Text = gvBan.GetRowCellValue(num, "soGhe").ToString();
        }
        private void gvPhong_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int numrow = e.RowHandle;
            setGiaTriPhong(numrow);
        }

        private void gvBan_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int numrow = e.RowHandle;
            setGiaTriBan(numrow);
        }

        private void btn_Thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btn_Them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = "Them";
            Program.actionPB = "Thêm";
            Program.mesPhongBan = new mesPhongBan();
            Program.mesPhongBan.Show();
            Program.frmChinh.Enabled = false;
        }

        public void themPhongBan()
        {
            if (Program.luaChonPB.Equals("Phòng"))
            {
                khoiTaoPhong();
                gcPhong.Enabled = gcBan.Enabled = panelBan.Enabled = false;
                panelPhong.Enabled = true;
                btn_Them.Enabled = btn_CapNhat.Enabled = btn_Reload.Enabled = btn_Xoa.Enabled = false;
                btn_Luu.Enabled = btn_PhucHoi.Enabled = true;
            }
            else if (Program.luaChonPB.Equals("Bàn"))
            {
                khoiTaoBan();
                gcBan.Enabled = gcPhong.Enabled = panelPhong.Enabled = false;
                panelBan.Enabled = true;
                btn_Them.Enabled = btn_CapNhat.Enabled = btn_Reload.Enabled = btn_Xoa.Enabled = false;
                btn_Luu.Enabled = btn_PhucHoi.Enabled = true;
            }
        }

        private void btn_CapNhat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = "ChinhSua";
            Program.actionPB = "Chỉnh Sửa";
            Program.mesPhongBan = new mesPhongBan();
            Program.mesPhongBan.lb_Tittle.Text = "Bạn muốn chỉnh sửa phòng hay bàn?";
            Program.mesPhongBan.Show();
            Program.frmChinh.Enabled = false;
        }

        public void chinhSuaPhongBan()
        {
            if (Program.luaChonPB.Equals("Phòng"))
            {
                gcPhong.Enabled = gcBan.Enabled = panelBan.Enabled = false;
                panelPhong.Enabled = true;
                btn_Them.Enabled = btn_CapNhat.Enabled = btn_Reload.Enabled = btn_Xoa.Enabled = false;
                btn_Luu.Enabled = btn_PhucHoi.Enabled = true;
                txt_MaPhong.Enabled = false;
            }
            else if (Program.luaChonPB.Equals("Bàn"))
            {
                gcBan.Enabled = gcPhong.Enabled = panelPhong.Enabled = false;
                panelBan.Enabled = true;
                btn_Them.Enabled = btn_CapNhat.Enabled = btn_Reload.Enabled = btn_Xoa.Enabled = false;
                btn_Luu.Enabled = btn_PhucHoi.Enabled = true;
                txt_MaBan.Enabled = false;
            }
        }

        private void btn_PhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsBan.CancelEdit();
            bdsPhong.CancelEdit();
            loadDataBan();
            loadDataPhong();
            gcPhong.Enabled = gcBan.Enabled = true;
            panelPhong.Enabled = panelBan.Enabled = false;

            btn_Them.Enabled = btn_Xoa.Enabled = btn_CapNhat.Enabled = btn_Thoat.Enabled = btn_Reload.Enabled = true;
            btn_PhucHoi.Enabled = btn_Luu.Enabled = false;
        }

        private void btn_Reload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadDataPhong();
            loadDataBan();
        }

        private void btn_Xoa_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.actionPB = "Xóa";
            Program.mesPhongBan = new mesPhongBan();
            Program.mesPhongBan.lb_Tittle.Text = "Bạn muốn xóa phòng hay bàn?";
            Program.mesPhongBan.Show();
            Program.frmChinh.Enabled = false;
        }

        public void xoaPhongBan()
        {
            if (Program.luaChonPB.Equals("Phòng"))
            {
                var maPhong = txt_MaPhong.Text.Trim();
                if (MessageBox.Show("Bạn có thật sự muốn xóa phòng " + maPhong + "?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    xoaPhong(maPhong);
                    khoiTaoPhong();
                    loadDataPhong();
                }
            }
            else if (Program.luaChonPB.Equals("Bàn"))
            {
                var maBan = txt_MaBan.Text.Trim();
                if (MessageBox.Show("Bạn có thật sự muốn xóa bàn " + maBan + "?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    xoaBan(maBan);
                    khoiTaoBan();
                    loadDataBan();
                }
            }
        }

        private async void xoaPhong(String maPhong)
        {
            var check = await _repositoryP.xoaPhong(maPhong);
            if (check.Equals("false")) MessageBox.Show("Xóa phòng thất bại!", "Thông báo");
            else MessageBox.Show("Xóa phòng thành công!", "Thông báo");
        }

        private async void xoaBan(String maBan)
        {
            var check = await _repositoryB.xoaBan(maBan);
            if (check.Equals("false")) MessageBox.Show("Xóa bàn thất bại!", "Thông báo");
            else MessageBox.Show("Xóa bàn thành công!", "Thông báo");
        }

        private void btn_Luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.luaChonPB.Equals("Phòng"))
            {
                if (txt_MaPhong.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Mã phòng không được để trống", "Thông báo", MessageBoxButtons.OK);
                    txt_MaPhong.Focus();
                    return;
                }
                if (txt_TenPhong.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Tên phòng không được để trống", "Thông báo", MessageBoxButtons.OK);
                    txt_TenPhong.Focus();
                    return;
                }
                if (vitri.Equals("Them"))
                {
                    PhongModel phong = new PhongModel();
                    phong.maPhong = txt_MaPhong.Text.Trim();
                    phong.tenPhong = txt_TenPhong.Text.Trim();
                    try
                    {
                        _repositoryP.themPhong(phong);
                        MessageBox.Show("Thêm phòng thành công!", "Thông báo");
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Thêm phòng thất bại!\n" + ex.Message, "Thông báo");
                    }
                }
                else if (vitri.Equals("ChinhSua"))
                {
                    PhongModel phong = new PhongModel();
                    phong.maPhong = txt_MaPhong.Text.Trim();
                    phong.tenPhong = txt_TenPhong.Text.Trim();
                    try
                    {
                        _repositoryP.suaPhong(phong);
                        MessageBox.Show("Cập nhật phòng thành công!", "Thông báo");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Cập nhật phòng thất bại!\n" + ex.Message, "Thông báo");
                    }
                    txt_MaPhong.Enabled = true;
                }
                btn_Them.Enabled = btn_CapNhat.Enabled = btn_Reload.Enabled = btn_Xoa.Enabled = true;
                btn_Luu.Enabled = btn_PhucHoi.Enabled = false;
                gcPhong.Enabled = gcBan.Enabled = true;
                panelPhong.Enabled = panelBan.Enabled = false;
            }
            else if (Program.luaChonPB.Equals("Bàn"))
            {
                if (txt_MaBan.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Mã bàn không được để trống", "Thông báo", MessageBoxButtons.OK);
                    txt_MaBan.Focus();
                    return;
                }
                if (txt_TenBan.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Tên bàn không được để trống", "Thông báo", MessageBoxButtons.OK);
                    txt_TenBan.Focus();
                    return;
                }
                int tam = int.Parse(seSoGhe.Text.Trim());
                if (tam < 0)
                {
                    MessageBox.Show("Số lượng không hợp lý", "Thông báo", MessageBoxButtons.OK);
                    txt_TenBan.Focus();
                    return;
                }
                if (vitri.Equals("Them"))
                {
                    BanModel ban = new BanModel();
                    ban.maBan = txt_MaBan.Text.Trim();
                    ban.tenBan = txt_TenBan.Text.Trim();
                    ban.soGhe = tam;
                    try
                    {
                        _repositoryB.themBan(ban);
                        MessageBox.Show("Thêm bàn thành công!", "Thông báo");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thêm bàn thất bại!\n" + ex.Message, "Thông báo");
                    }
                }
                else if (vitri.Equals("ChinhSua"))
                {
                    BanModel ban = new BanModel();
                    ban.maBan = txt_MaBan.Text.Trim();
                    ban.tenBan = txt_TenBan.Text.Trim();
                    ban.soGhe = tam;
                    try
                    {
                        _repositoryB.suaBan(ban);
                        MessageBox.Show("Cập nhật bàn thành công!", "Thông báo");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Cập nhật bàn thất bại!\n" + ex.Message, "Thông báo");
                    }
                    txt_MaBan.Enabled = true;
                }
                btn_Them.Enabled = btn_CapNhat.Enabled = btn_Reload.Enabled = btn_Xoa.Enabled = true;
                btn_Luu.Enabled = btn_PhucHoi.Enabled = false;
                gcPhong.Enabled = gcBan.Enabled = true;
                panelPhong.Enabled = panelBan.Enabled = false;
            }
            loadDataBan();
            loadDataPhong();
        }
    }
}
