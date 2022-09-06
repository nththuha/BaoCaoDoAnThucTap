using Newtonsoft.Json;
using RestaurantManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Repository
{
    class TaiKhoanRepository
    {
        public HttpClient _client;
        public HttpResponseMessage _response;


        public TaiKhoanRepository()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(Program.URL);
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<NhanVienModel> kiemTraDangNhap(TaiKhoanModel taiKhoanModel)
        {
            var taiKhoan = JsonConvert.SerializeObject(taiKhoanModel);
            var buffer = Encoding.UTF8.GetBytes(taiKhoan);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var rp = await _client.PostAsync("taikhoan", byteContent);
            var json = await rp.Content.ReadAsStringAsync();
            var nhanVien = JsonConvert.DeserializeObject<NhanVienModel>(json);

            return nhanVien;   
        }

        public async Task<TaiKhoanModel> layTaiKhoanTheoIDNV(int idnv)
        {
            _response = await _client.GetAsync("taikhoan/" + idnv);
            var json = await _response.Content.ReadAsStringAsync();
            var taiKhoan = JsonConvert.DeserializeObject<TaiKhoanModel>(json);
            return taiKhoan;
        }

        public void themTaiKhoan(TaiKhoanModel taiKhoan)
        {
            var tk = JsonConvert.SerializeObject(taiKhoan);
            var buffer = Encoding.UTF8.GetBytes(tk);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _client.PostAsync("taikhoan/them", byteContent);
        }

        public void suaTaiKhoan(TaiKhoanModel taiKhoan)
        {
            var tk = JsonConvert.SerializeObject(taiKhoan);
            var buffer = Encoding.UTF8.GetBytes(tk);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _client.PutAsync("taikhoan/sua", byteContent);
        }
    }
}
