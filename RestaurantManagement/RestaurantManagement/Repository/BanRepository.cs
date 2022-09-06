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
    class BanRepository
    {
        public HttpClient _client;
        public HttpResponseMessage _response;

        public BanRepository()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(Program.URL);
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<BanModel>> getList()
        {
            _response = await _client.GetAsync("ban");
            var json = await _response.Content.ReadAsStringAsync();
            var listB = JsonConvert.DeserializeObject<List<BanModel>>(json);
            return listB;
        }

        public void themBan(BanModel ban)
        {
            var b = JsonConvert.SerializeObject(ban);
            var buffer = Encoding.UTF8.GetBytes(b);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _client.PostAsync("ban", byteContent);
        }

        public void suaBan(BanModel ban)
        {
            var b = JsonConvert.SerializeObject(ban);
            var buffer = Encoding.UTF8.GetBytes(b);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _client.PutAsync("ban", byteContent);
        }

        public async Task<String> xoaBan(String maBan)
        {
            _response = await _client.DeleteAsync("ban/" + maBan);
            var json = await _response.Content.ReadAsStringAsync();
            var check = JsonConvert.DeserializeObject<String>(json);
            return check;
        }
    }
}
