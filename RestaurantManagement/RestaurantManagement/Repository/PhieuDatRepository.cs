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
    class PhieuDatRepository
    {
        public HttpClient _client;
        public HttpResponseMessage _response;

        public PhieuDatRepository()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(Program.URL);
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<PhieuDatModel>> getListNoHoaDon()
        {
            _response = await _client.GetAsync("phieudat");
            var json = await _response.Content.ReadAsStringAsync();
            var listPD = JsonConvert.DeserializeObject<List<PhieuDatModel>>(json);
            return listPD;
        }

        public void Add(PhieuDatModel phieuDatModel)
        {
            var phieudat = JsonConvert.SerializeObject(phieuDatModel);
            var buffer = Encoding.UTF8.GetBytes(phieudat);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _client.PostAsync("phieudat", byteContent);
        }

        public void Update(PhieuDatModel phieuDatModel)
        {
            var phieudat = JsonConvert.SerializeObject(phieuDatModel);
            var buffer = Encoding.UTF8.GetBytes(phieudat);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _client.PutAsync("phieudat", byteContent);

        }
    }
}
