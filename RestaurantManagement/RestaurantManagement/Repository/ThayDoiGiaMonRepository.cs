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
    class ThayDoiGiaMonRepository
    {
        public HttpClient _client;
        public HttpResponseMessage _response;

        public ThayDoiGiaMonRepository()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(Program.URL);

        }

        public async Task<List<ThayDoiGiaMonModel>> getList(String maMA)
        {
            _response = await _client.GetAsync("thaydoigiamon/" + maMA);
            var json = await _response.Content.ReadAsStringAsync();
            var listTDGM = JsonConvert.DeserializeObject<List<ThayDoiGiaMonModel>>(json);
            return listTDGM;
        }

        public async Task<ThayDoiGiaMonModel> Add(ThayDoiGiaMonModel thayDoiGiaMonModel)
        {
            var thaydoigiamon = JsonConvert.SerializeObject(thayDoiGiaMonModel);
            var buffer = Encoding.UTF8.GetBytes(thaydoigiamon);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _response = await _client.PostAsync("thaydoigiamon", byteContent);
            var json = await _response.Content.ReadAsStringAsync();
            ThayDoiGiaMonModel TDGM = JsonConvert.DeserializeObject<ThayDoiGiaMonModel>(json);
            return TDGM;
        }

        public async Task<ThayDoiGiaMonModel> Update(ThayDoiGiaMonModel thayDoiGiaMonModel)
        {
            var thaydoigiamon = JsonConvert.SerializeObject(thayDoiGiaMonModel);
            var buffer = Encoding.UTF8.GetBytes(thaydoigiamon);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            _response = await _client.PutAsync("thaydoigiamon", byteContent);
            var json = await _response.Content.ReadAsStringAsync();
            ThayDoiGiaMonModel TDGM = JsonConvert.DeserializeObject<ThayDoiGiaMonModel>(json);
            return TDGM;
        }

        public async Task<String> Delete(int idGM)
        {
            _response = await _client.DeleteAsync("thaydoigiamon/" + idGM);
            var json = await _response.Content.ReadAsStringAsync();
            var check = JsonConvert.DeserializeObject<String>(json);
            return check;
        }
    }
}
