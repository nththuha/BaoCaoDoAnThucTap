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
    public partial class frmKhachHang : Form
    {
        HoaDonModel hoaDon;

        Repository.HoaDonRepository _repositoryHD = new Repository.HoaDonRepository();

        public frmKhachHang()
        {
            InitializeComponent();
            this.hoaDon = Program.hoaDon;
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            if(!txt_HoTenKH.Text.Trim().Equals(""))
            {
                hoaDon.hotenkh = txt_HoTenKH.Text.Trim();
            }
            if (!txt_MST.Text.Trim().Equals(""))
            {
                hoaDon.masothue = txt_MST.Text.Trim();
            }
            themHD();
        }

        private async void themHD()
        {
            HDModel saveHD = await _repositoryHD.Add(hoaDon);
            if (saveHD.maHD == null)
            {
                MessageBox.Show("Thêm hóa đơn thất bại!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Thêm hóa đơn thành công!", "Thông báo");

                rpHoaDon rp = new rpHoaDon();

                DataSet ds = new DataSet();

                var triGia = String.Format("{0:0,0 VND}", saveHD.trigia);
                var thue = String.Format("{0:0,0 VND}", saveHD.giaSauThue - saveHD.trigia);
                var giaSauThue = String.Format("{0:0,0 VND}", saveHD.giaSauThue);

                rp.lb_Gia.Text = triGia.ToString();
                rp.lb_Thue.Text = thue.ToString();
                rp.lb_GiaSauThue.Text = giaSauThue.ToString();
                rp.lb_GiaChu.Text = "Tiền chữ: " + saveHD.giaChu;
                rp.lbMaHD.Text = "Mã hóa đơn: " + saveHD.maHD;
                rp.lbNgay.Text = "Ngày: " + saveHD.ngay.Substring(8, 2) + "/" + saveHD.ngay.Substring(5, 2) + "/" + saveHD.ngay.Substring(0, 4);
                rp.lbMaST.Text = "Mã số thuế: " + saveHD.masothue;
                rp.lbKH.Text = "Khách hàng: " + saveHD.hotenkh;
                rp.lbNV.Text = "Nhân viên: " + saveHD.hoTenNV;

                DataTable dt = new DataTable();
                dt.TableName = "CTDatMon";
                dt.Columns.Add("tenma", typeof(String));
                dt.Columns.Add("soLuong", typeof(int));
                dt.Columns.Add("giaTungMon", typeof(String));
                dt.Columns.Add("gia", typeof(String));
                ds.Tables.Add(dt);

                List<CTDatMonModel> ct = saveHD.ctDatMonList;
                foreach (CTDatMonModel i in ct)
                {
                    var giaTungMon = String.Format("{0:0,0}", i.giaTungMon);
                    var gia = String.Format("{0:0,0}", i.gia);
                    ds.Tables["CTDatMon"].Rows.Add(new Object[] { i.tenma, i.soLuong, giaTungMon, gia });
                }

                rp.DataSource = ds;

                this.Close();
                ReportPrintTool print = new ReportPrintTool(rp);
                print.ShowPreviewDialog();
            }
        }

        private void frmKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.frmChinh.Enabled = true;
            Program.formTheoDoiDonHang.xoaGridView();
            Program.formTheoDoiDonHang.loadDataPhieuDat();
        }
    }
}
