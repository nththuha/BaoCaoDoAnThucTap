using DevExpress.XtraReports.UI;
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
    public partial class frmTheoDoiDonHang : Form
    {
        Repository.PhieuDatRepository _repositoryPD = new Repository.PhieuDatRepository();
        Repository.CTDatMonRepository _repositoryCTDM = new Repository.CTDatMonRepository();
        Repository.HoaDonRepository _repositoryHD = new Repository.HoaDonRepository();

        int num = 0;
        int numHD = 0;
        int tong = 0;

        List<PhieuDatModel> ds = new List<PhieuDatModel>();

        List<CTDatMonModel> dsCTDM = new List<CTDatMonModel>();
        public frmTheoDoiDonHang()
        {
            InitializeComponent();
            loadDataPhieuDat();
        }

        public async void loadDataPhieuDat()
        {
            try
            {
                var listPD = await _repositoryPD.getListNoHoaDon();
                gcPhieuDat.DataSource = listPD;
                if (listPD.Count > 0)
                {
                    loadDataCTDM(listPD[0].idPD);
                    num = 0;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi load data: " + e.Message, "Thông báo");
            }
        }

        public async void loadDataCTDM(int idPD)
        {
            try
            {
                var listCTDM = await _repositoryCTDM.getListTheoPhieuDat(idPD);
                dsCTDM = listCTDM;
                gcCTDM.DataSource = listCTDM;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi load data: " + e.Message, "Thông báo");
            }
        }

        private void gvPhieuDat_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            num = e.RowHandle;
            int idPD = int.Parse(gvPhieuDat.GetRowCellValue(num, "idPD").ToString());
            loadDataCTDM(idPD);
        }

        private void btn_ThemPD_Click(object sender, EventArgs e)
        {
            if(checkMonDone() == true)
            {
                int idPD = int.Parse(gvPhieuDat.GetRowCellValue(num, "idPD").ToString());
                String ngay = gvPhieuDat.GetRowCellValue(num, "ngay").ToString();
                String idnv = gvPhieuDat.GetRowCellValue(num, "idnv").ToString();

                PhieuDatModel pd = new PhieuDatModel();
                pd.idPD = idPD;
                pd.ngay = ngay;
                pd.idnv = int.Parse(idnv);

                for (int i = 0; i < ds.Count; i++)
                {
                    if (ds[i].idPD == pd.idPD)
                    {
                        MessageBox.Show("Phiếu đặt không được trùng!", "Thông báo");
                        return;
                    }
                }
                ds.Add(pd);

                List<PhieuDatModel> list = new List<PhieuDatModel>();

                for (int i = 0; i < ds.Count; i++)
                {
                    list.Add(ds[i]);
                }

                for (int i = 0; i < dsCTDM.Count; i++)
                {
                    tong += dsCTDM[i].gia;
                }

                gcHD.DataSource = list;
            }
            else MessageBox.Show("Món ăn chưa được phục vụ cho khách", "Thông báo");
        }
        
        private Boolean checkMonDone()
        {
            for(int i = 0; i < dsCTDM.Count; i++)
            {
                if (!dsCTDM[i].trangThai.Equals("done")) return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idPD = 0;
            if(gvHD.GetRowCellValue(numHD, "idPD") != null)
            {
                idPD = int.Parse(gvHD.GetRowCellValue(numHD, "idPD").ToString());
                for (int i = 0; i < ds.Count; i++)
                {
                    if (ds[i].idPD == idPD)
                    {
                        ds.Remove(ds[i]);
                    }
                }

                for (int i = 0; i < dsCTDM.Count; i++)
                {
                    tong -= dsCTDM[i].gia;
                }

                List<PhieuDatModel> list = new List<PhieuDatModel>();

                for (int i = 0; i < ds.Count; i++)
                {
                    list.Add(ds[i]);
                }

                gcHD.DataSource = list;
            }
        }

        private void gvHD_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            numHD = e.RowHandle;
        }

        private void btn_XuatHD_Click(object sender, EventArgs e)
        {
            if(ds.Count <= 0)
            {
                MessageBox.Show("Vui lòng chọn phiếu đặt!", "Thông báo");
            }
            else xuatHoaDon();
        }

        private void xuatHoaDon()
        {
            HoaDonModel hoaDon = new HoaDonModel();
            hoaDon.idnv = Program.nhanVien.idNV;

            DateTime aDate = DateTime.Now;
            String now = aDate.ToString("yyyy-MM-dd");
            String n = aDate.ToString("yy-MM-dd H m s");
            hoaDon.ngay = now;

            hoaDon.maHD = "HD" + n;

            hoaDon.trigia = tong;
            hoaDon.giaSauThue = (int)(tong * 1.1);
            hoaDon.phieudatList = ds;

            Program.hoaDon = hoaDon;

            Program.formKhachHang = new frmKhachHang();
            Program.formKhachHang.Show();
            Program.frmChinh.Enabled = false;
            
            xoaGridView();
            loadDataPhieuDat();
        }

        public void xoaGridView()
        {
            ds = new List<PhieuDatModel>();
            gcHD.DataSource = null;
            tong = 0;

            dsCTDM = new List<CTDatMonModel>();
            gcCTDM.DataSource = null;
        }
    }
}
