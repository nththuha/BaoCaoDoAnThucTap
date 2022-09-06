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
    public partial class frmChiTietBan : Form
    {
        Repository.PhongRepository _repositoryP = new Repository.PhongRepository();
        Repository.BanRepository _repositoryB = new Repository.BanRepository();
        Repository.CTBanRepository _repositoryCTBan = new Repository.CTBanRepository();

        String maPhong = "";
        String maBan = "";
        int soGhe = 0;
        int idCTB = -1;
        public frmChiTietBan()
        {
            InitializeComponent();
        }

        private void frmChiTietBan_Load(object sender, EventArgs e)
        {
            loadDataBan();
            loadDataPhong();
        }

        private async void loadDataBan()
        {
            try
            {
                var listB = await _repositoryB.getList();
                gcBan.DataSource = listB;
                if (listB.Count > 0)
                {
                    maBan = listB[0].maBan;
                    soGhe = listB[0].soGhe;
                }
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
                if (listP.Count > 0)
                {
                    maPhong = listP[0].maPhong;
                    loadCTBan();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi load data phòng: " + e.Message);
            }
        }

        private void gvPhong_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int num = e.RowHandle;
            maPhong = gvPhong.GetRowCellValue(num, "maPhong").ToString();
            loadCTBan();
        }

        private async void loadCTBan()
        {
            try
            {
                var listCTB = await _repositoryCTBan.layDSBanTheoPhong(maPhong);
                gcCTBan.DataSource = listCTB;
                if (listCTB.Count > 0) idCTB = listCTB[0].idCTB;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load data chi tiết bàn: " + ex.Message, "Thông báo");
            }
        }

        private void btn_Reload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadDataBan();
            loadDataPhong();
            loadCTBan();
        }

        private void btn_Thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gvBan_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int num = e.RowHandle;
            maBan = gvBan.GetRowCellValue(num, "maBan").ToString();
        }

        private void btn_Them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (maPhong.Equals(""))
            {
                MessageBox.Show("Bạn cần chọn phòng", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (maBan.Equals(""))
            {
                MessageBox.Show("Bạn cần chọn bàn", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            CTBanModel ctBan = new CTBanModel();
            ctBan.maban = maBan;
            ctBan.maphong = maPhong;
            ctBan.soGhe = soGhe;
            themCTBan(ctBan);
            loadCTBan();
        }

        private async void themCTBan(CTBanModel ctBan)
        {
            try
            {
                var check = await _repositoryCTBan.themCTBan(ctBan);
                if(check.Equals("true")) MessageBox.Show("Thêm chi tiết bàn thành công!", "Thông báo", MessageBoxButtons.OK);
                else MessageBox.Show("Thêm chi tiết bàn thất bại!", "Thông báo", MessageBoxButtons.OK);
            }
            catch(Exception e)
            {
                MessageBox.Show("Thêm chi tiết bàn thất bại\n" + e.Message, "Thông báo");
            }
        }

        private void gvCTBan_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int num = e.RowHandle;
            idCTB = int.Parse(gvCTBan.GetRowCellValue(num, "idCTB").ToString());
        }

        private void btn_Xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa phòng " + maPhong + " và bàn " + maBan + "?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                xoaCTBan();
            }    
        }

        private async void xoaCTBan()
        {
            try
            {
                var check = await _repositoryCTBan.xoaCTBan(idCTB);
                if (check.Equals("true")) MessageBox.Show("Xóa chi tiết bàn thành công!", "Thông báo", MessageBoxButtons.OK);
                else MessageBox.Show("Xóa chi tiết bàn thất bại!", "Thông báo", MessageBoxButtons.OK);
                loadCTBan();
            }
            catch(Exception e)
            {
                MessageBox.Show("Xóa chi tiết bàn thất bại\n" + e.Message, "Thông báo");
            }
        }
    }
}
