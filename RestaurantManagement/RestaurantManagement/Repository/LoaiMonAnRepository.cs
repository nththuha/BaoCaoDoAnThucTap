using Newtonsoft.Json;
using RestaurantManagement.Model;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Repository
{
    class LoaiMonAnRepository
    {
        public HttpClient _client;
        public HttpResponseMessage _response;

        public LoaiMonAnRepository()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(Program.URL);
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<LoaiMonAnModel>> getList()
        {
            _response = await _client.GetAsync("loaimonan");
            var json = await _response.Content.ReadAsStringAsync();
            var listLMA = JsonConvert.DeserializeObject<List<LoaiMonAnModel>>(json);
            return listLMA;
        }

        public void Add(LoaiMonAnModel loaiMonAnModel)
        {
            var loaiMonAn = JsonConvert.SerializeObject(loaiMonAnModel);
            var buffer = Encoding.UTF8.GetBytes(loaiMonAn);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _client.PostAsync("loaimonan", byteContent);
        }

        public void Update(LoaiMonAnModel loaiMonAnModel)
        {
            var loaiMonAn = JsonConvert.SerializeObject(loaiMonAnModel);
            var buffer = Encoding.UTF8.GetBytes(loaiMonAn);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _client.PutAsync("loaimonan", byteContent);

        }

        public async Task<String> Delete(String maLMA)
        {
            _response = await _client.DeleteAsync("loaimonan/" + maLMA);
            var json = await _response.Content.ReadAsStringAsync();
            var check = JsonConvert.DeserializeObject<String>(json);
            return check;
        }
    }
}
