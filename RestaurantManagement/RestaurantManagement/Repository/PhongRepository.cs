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
    class PhongRepository
    {
        public HttpClient _client;
        public HttpResponseMessage _response;

        public PhongRepository()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(Program.URL);
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<PhongModel>> getList()
        {
            _response = await _client.GetAsync("phong");
            var json = await _response.Content.ReadAsStringAsync();
            var listP = JsonConvert.DeserializeObject<List<PhongModel>>(json);
            return listP;
        }

        public void themPhong(PhongModel phong)
        {
            var p = JsonConvert.SerializeObject(phong);
            var buffer = Encoding.UTF8.GetBytes(p);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _client.PostAsync("phong", byteContent);
        }

        public void suaPhong(PhongModel phong)
        {
            var p = JsonConvert.SerializeObject(phong);
            var buffer = Encoding.UTF8.GetBytes(p);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _client.PutAsync("phong", byteContent);
        }

        public async Task<String> xoaPhong(String maPhong)
        {
            _response = await _client.DeleteAsync("phong/" + maPhong);
            var json = await _response.Content.ReadAsStringAsync();
            var check = JsonConvert.DeserializeObject<String>(json);
            return check;
        }
    }
}
