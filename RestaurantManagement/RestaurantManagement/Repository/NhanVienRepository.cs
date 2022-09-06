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
    class NhanVienRepository
    {
        public HttpClient _client;
        public HttpResponseMessage _response;

        public NhanVienRepository()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(Program.URL);
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<NhanVienModel>> getList()
        {
            _response = await _client.GetAsync("nhanvien");
            var json = await _response.Content.ReadAsStringAsync();
            var listNV = JsonConvert.DeserializeObject<List<NhanVienModel>>(json);
            return listNV;
        }

        public void Add(NhanVienModel nhanVienModel)
        {
            var nhanVien = JsonConvert.SerializeObject(nhanVienModel);
            var buffer = Encoding.UTF8.GetBytes(nhanVien);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _client.PostAsync("nhanvien", byteContent);
        }

        public void Update(NhanVienModel nhanVienModel)
        {
            var nhanvien = JsonConvert.SerializeObject(nhanVienModel);
            var buffer = Encoding.UTF8.GetBytes(nhanvien);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _client.PutAsync("nhanvien", byteContent);
        }

        public async Task<String> Delete(String maNV)
        {
            _response = await _client.DeleteAsync("nhanvien/" + maNV);
            var json = await _response.Content.ReadAsStringAsync();
            var check = JsonConvert.DeserializeObject<String>(json);
            return check;
        }
    }
}
