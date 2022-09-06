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
    class HoaDonRepository
    {
        public HttpClient _client;
        public HttpResponseMessage _response;

        public HoaDonRepository()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(Program.URL);
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<HDModel> Add(HoaDonModel hoaDon)
        {
            var hd = JsonConvert.SerializeObject(hoaDon);
            var buffer = Encoding.UTF8.GetBytes(hd);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _response = await _client.PostAsync("hoadon", byteContent);
            var json = await _response.Content.ReadAsStringAsync();
            var hoadon = JsonConvert.DeserializeObject<HDModel>(json);
            return hoadon;
        }
    }
}
