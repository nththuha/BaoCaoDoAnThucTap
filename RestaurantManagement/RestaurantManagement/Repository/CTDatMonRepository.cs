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
    class CTDatMonRepository
    {
        public HttpClient _client;
        public HttpResponseMessage _response;

        public CTDatMonRepository()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(Program.URL);
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<CTDatMonModel>> getListTheoPhieuDat(int idPD)
        {
            _response = await _client.GetAsync("ctdatmon/" + idPD);
            var json = await _response.Content.ReadAsStringAsync();
            var listCTDM = JsonConvert.DeserializeObject<List<CTDatMonModel>>(json);
            return listCTDM;
        }
    }
}
