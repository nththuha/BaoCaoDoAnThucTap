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
    class MonAnRepository
    {
        public HttpClient _client;
        public HttpResponseMessage _response;

        public MonAnRepository()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(Program.URL);
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<MonAnModel>> getList()
        {
            _response = await _client.GetAsync("monan");
            var json = await _response.Content.ReadAsStringAsync();
            var listMA = JsonConvert.DeserializeObject<List<MonAnModel>>(json);
            return listMA;
        }

        public void Add(MonAnModel monAnModel)
        {
            var monAn = JsonConvert.SerializeObject(monAnModel);
            var buffer = Encoding.UTF8.GetBytes(monAn);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _client.PostAsync("monan", byteContent);
        }

        public void Update(MonAnModel monAnModel)
        {
            var monAn = JsonConvert.SerializeObject(monAnModel);
            var buffer = Encoding.UTF8.GetBytes(monAn);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _client.PutAsync("monan", byteContent);
        }

        public async Task<String> Delete(String maLMA)
        {
            _response = await _client.DeleteAsync("monan/" + maLMA);
            var json = await _response.Content.ReadAsStringAsync();
            var check = JsonConvert.DeserializeObject<String>(json);
            return check;
        }
    }
}
