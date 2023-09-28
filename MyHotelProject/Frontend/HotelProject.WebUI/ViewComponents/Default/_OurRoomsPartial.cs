using HotelProject.WebUI.Dtos.RoomDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
namespace HotelProject.WebUI.ViewComponents.Default
{
    public class _OurRoomsPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _OurRoomsPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient(); // istemci client oluştur.
            var responseMessage = await client.GetAsync("http://localhost:36900/api/Rooms"); // adrese istekte bulunduk.
            if (responseMessage.IsSuccessStatusCode) // 200lerde durum kodu gelirse (başarılıysa)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync(); // gelen veriyi değişkene atadık.

                //bu değişkendeki veriyi de tabloda gösterebileceğimiz formata dönüştürdük
                var values = JsonConvert.DeserializeObject<List<ResultRoomDto>>(jsonData);
                return View(values);
            }
            return View();
        }    }
}
