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
    public partial class frmThayDoiGiaMon : Form
    {
        Repository.MonAnRepository _repositoryMA = new Repository.MonAnRepository();
        Repository.ThayDoiGiaMonRepository _repositoryTDGM = new Repository.ThayDoiGiaMonRepository();

        ThayDoiGiaMonModel temp = new ThayDoiGiaMonModel();

        int num = 0;
        String maMA = "";

        public frmThayDoiGiaMon()
        {
            InitializeComponent();
            loadDataMonAn();
            this.deNgay.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.deNgay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deNgay.Properties.EditFormat.FormatString = "dd-MM-yyyy";
            this.deNgay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deNgay.Properties.Mask.EditMask = "dd-MM-yyyy";
        }

        public async void loadDataMonAn()
        {
            try
            {
                var listMA = await _repositoryMA.getList();
                gcMonAn.DataSource = listMA;
                if (listMA.Count > 0) setGiaTriMonAn(0);
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi load data: " + e.Message, "Thông báo");
            }
        }

        public async void loadDataThayDoiGiaMon(String maMA)
        {
            try
            {
                var listTDGM = await _repositoryTDGM.getList(maMA);
                for(int i = 0; i < listTDGM.Count; i++)
                {
                    listTDGM[i].ngay = listTDGM[i].ngay.Substring(8, 2) + "-" + listTDGM[i].ngay.Substring(5, 2) + "-" + listTDGM[i].ngay.Substring(0, 4);
                }
                gcThayDoiGiaMon.DataSource = listTDGM;
                if (listTDGM.Count > 0) setGiaTriThayDoiGiaMon(0);
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi load data: " + e.Message, "Thông báo");
            }
        }

        private void setGiaTriMonAn(int num)
        {
            maMA = gvMonAn.GetRowCellValue(num, "maMA").ToString();
            loadDataThayDoiGiaMon(maMA);
            etMaMA.Text = gvMonAn.GetRowCellValue(num, "maMA").ToString();
            etTenMA.Text = gvMonAn.GetRowCellValue(num, "tenMA").ToString();
        }

        private void gvMonAn_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int num = e.RowHandle;
            setGiaTriMonAn(num);
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            if (etMaMA.Text.Trim().Equals(""))
            {
                MessageBox.Show("Mã món ăn không được để trống!", "Thông báo");
                etMaMA.Focus();
                return;
            }

            if (etTenMA.Text.Trim().Equals(""))
            {
                MessageBox.Show("Tên món ăn không được để trống!", "Thông báo");
                etMaMA.Focus();
                return;
            }

            int tam = int.Parse(seGia.Text.Trim());
            if (tam <= 0)
            {
                MessageBox.Show("Giá không hợp lệ!", "Thông báo");
                etMaMA.Focus();
                return;
            }

            if (deNgay.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ngày không được để trống!", "Thông báo");
                return;
            }

            DateTime aDate = DateTime.Now;
            String now = aDate.ToString("yyyy-MM-dd");
            String ngay = deNgay.DateTime.ToString("yyyy-MM-dd");

            if (now.CompareTo(ngay) > 0)
            {
                MessageBox.Show("Ngày phải lớn hơn ngày hiện tại", "Thông báo");
                return;
            }

            temp.mama = etMaMA.Text.Trim();
            temp.idnv = Program.nhanVien.idNV;
            temp.gia = tam;
            temp.ngay = ngay;

            ThayDoi();
        }

        public async void ThayDoi()
        {
            ThayDoiGiaMonModel k = await _repositoryTDGM.Add(temp);
            if (k.mama == null) MessageBox.Show("Thay đổi giá món ăn thất bại!", "Thông báo");
            else MessageBox.Show("Thay đổi giá món ăn thành công!", "Thông báo");

            loadDataThayDoiGiaMon(temp.mama);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            DateTime aDate = DateTime.Now;
            String now = aDate.ToString("yyyy-MM-dd");
            String ngay = gvThayDoiGiaMon.GetRowCellValue(num, "ngay").ToString();
            ngay = ngay.Substring(6, 4) + "-" + ngay.Substring(3, 2) + "-" + ngay.Substring(0, 2);
            if (now.CompareTo(ngay) > 0)
            {
                MessageBox.Show("Không được phép xóa giá món!", "Thông báo");
                return;
            }
            int idGM = int.Parse(gvThayDoiGiaMon.GetRowCellValue(num, "idGM").ToString());
            _ = xoaGiaMonAsync(idGM);
        }

        private async Task xoaGiaMonAsync(int idGM)
        {
            var check = await _repositoryTDGM.Delete(idGM);
            if (check.Equals("false")) MessageBox.Show("Xóa giá món thất bại!");
            else MessageBox.Show("Xóa giá món thành công!");
            loadDataThayDoiGiaMon(maMA);
        }

        private void setGiaTriThayDoiGiaMon(int num)
        {
            seGia.Text = gvThayDoiGiaMon.GetRowCellValue(num, "gia").ToString();
            deNgay.Text = gvThayDoiGiaMon.GetRowCellValue(num, "ngay").ToString();
        }

        private void gvThayDoiGiaMon_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            num = e.RowHandle;
            setGiaTriThayDoiGiaMon(num);
        }
    }
}
