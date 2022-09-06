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
    public partial class frmThongKe : Form
    {
        Repository.ThongKeRepository _repositoryTK = new Repository.ThongKeRepository();
        public frmThongKe()
        {
            InitializeComponent();
            this.deNgayBD.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.deNgayBD.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deNgayBD.Properties.EditFormat.FormatString = "dd-MM-yyyy";
            this.deNgayBD.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deNgayBD.Properties.Mask.EditMask = "dd-MM-yyyy";

            this.deNgayKT.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.deNgayKT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deNgayKT.Properties.EditFormat.FormatString = "dd-MM-yyyy";
            this.deNgayKT.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deNgayKT.Properties.Mask.EditMask = "dd-MM-yyyy";
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            if (deNgayBD.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ngày bắt đầu không được để trống!", "Thông báo");
                return;
            }
            if (deNgayKT.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ngày bắt đầu không được để trống!", "Thông báo");
                return;
            }

            String ngayBD = deNgayBD.DateTime.ToString("yyyy-MM-dd");
            String ngayKT = deNgayKT.DateTime.ToString("yyyy-MM-dd");
            ThongKeModel thongKe = new ThongKeModel();
            thongKe.ngayBD = ngayBD;
            thongKe.ngayKT = ngayKT;
            thongKeDoanhThu(thongKe);
        }

        private async void thongKeDoanhThu(ThongKeModel thongKe)
        {
            try
            {
                List<ThongKeModel> list = await _repositoryTK.getThongKe(thongKe);
                rpThongKe rp = new rpThongKe();

                DataSet ds = new DataSet();

                rp.lb_NgayBD.Text = "Ngày bắt đầu: " + thongKe.ngayBD.Substring(8, 2) + "/" + thongKe.ngayBD.Substring(5, 2) + "/" + thongKe.ngayBD.Substring(0, 4);
                rp.lb_NgayKT.Text = "Ngày kết thúc: " + thongKe.ngayKT.Substring(8, 2) + "/" + thongKe.ngayKT.Substring(5, 2) + "/" + thongKe.ngayKT.Substring(0, 4);
                rp.lb_NhanVien.Text = "Nhập viên lập phiếu: " + Program.nhanVien.hoTen;

                DateTime aDate = DateTime.Now;
                String y = aDate.ToString("yyyy");
                String m = aDate.ToString("MM");
                String d = aDate.ToString("dd");
                rp.lb_TPHCM.Text = "TPHCM, ngày " + d + " tháng " + m + " năm " + y;

                DataTable dt = new DataTable();
                dt.TableName = "ThongKe";
                dt.Columns.Add("thang", typeof(String));
                dt.Columns.Add("doanhThu", typeof(String));
                ds.Tables.Add(dt);

                int tong = 0;

                foreach (ThongKeModel i in list)
                {
                    tong += i.doanhThu;
                    var doanhThu = (i.doanhThu == 0) ? "0 VND" : String.Format("{0:0,0 VND}", i.doanhThu);
                    var thang = i.thang + "/" + i.nam;
                    ds.Tables["ThongKe"].Rows.Add(new Object[] { thang, doanhThu });
                }
                var t = String.Format("{0:0,0 VND}", tong);
                rp.lb_Tong.Text = "Tổng cộng: " + t;

                rp.DataSource = ds;

                ReportPrintTool print = new ReportPrintTool(rp);
                print.ShowPreviewDialog();
            }
            catch(Exception e)
            {
                MessageBox.Show("Không lập được thống kê!\n" + e, "Thông báo");
            }
        }
    }
}
