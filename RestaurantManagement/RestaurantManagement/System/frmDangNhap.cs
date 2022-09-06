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
    public partial class frmDangNhap : Form
    {
        Repository.TaiKhoanRepository _repository = new Repository.TaiKhoanRepository();

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String maTK = txt_TK.Text.Trim();
            String matKhau = txt_MK.Text.Trim();

            if (maTK.Equals(""))
            {
                MessageBox.Show("Mã tài khoản không được để trống!", "Thông báo");
                return;
            }
            if (matKhau.Equals(""))
            {
                MessageBox.Show("Mật khẩu không được để trống!", "Thông báo");
                return;
            }

            TaiKhoanModel taiKhoan = new TaiKhoanModel();
            taiKhoan.maTK = maTK;
            taiKhoan.matKhau = matKhau;
            kiemTraDangNhap(taiKhoan);
        }

        private async void kiemTraDangNhap(TaiKhoanModel taiKhoan)
        {
            var nhanVien = new NhanVienModel();
            try
            {
                nhanVien = await _repository.kiemTraDangNhap(taiKhoan);
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kiểm tra đăng nhập: " + e.Message, "Thông báo");
                return;
            }
            if (nhanVien == null)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Thông báo");
            }
            else
            {
                if (nhanVien.tenBP == "Admin")
                {
                    Program.frmChinh.btn_DangNhap.Enabled = false;
                    Program.frmChinh.btn_DangXuat.Enabled = Program.frmChinh.btn_LoaiMonAn.Enabled = Program.frmChinh.btn_MonAn.Enabled = Program.frmChinh.btn_TheoDoiDonHang.Enabled = Program.frmChinh.btnThayDoiGiaMon.Enabled = Program.frmChinh.btnPhongBan.Enabled = Program.frmChinh.btnNhanVien.Enabled = Program.frmChinh.btnTaiKhoan.Enabled = Program.frmChinh.btn_ChiTietBan.Enabled = Program.frmChinh.btn_ThongKe.Enabled = true;
                    Program.frmChinh.tssl_MaNV.Text = "Mã nhân viên: " + nhanVien.idNV;
                    Program.frmChinh.tssl_HoTen.Text = "Họ tên: " + nhanVien.hoTen;
                    Program.frmChinh.tssl_Quyen.Text = "Bộ phận " + nhanVien.tenBP;
                    Program.nhanVien = nhanVien;
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Bạn không phải Admin nên không thể đăng nhập!", "Thông báo");
                }
            }

        }
    }
}
