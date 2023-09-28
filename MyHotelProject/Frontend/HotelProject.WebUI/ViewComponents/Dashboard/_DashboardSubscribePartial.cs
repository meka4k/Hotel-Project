using HotelProject.WebUI.Dtos.SubscribesDto;
using HotelProject.WebUI.Dtos.SubscribesSocialDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace HotelProject.WebUI.ViewComponents.Dashboard
{
    public class _DashboardSubscribePartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://instagram-profile1.p.rapidapi.com/getprofile/meka.4k"),
                Headers =
    {
        { "X-RapidAPI-Key", "3613fe7b65msh52cd8a29c6891cap127cb5jsnd6c43ce9351f" },
        { "X-RapidAPI-Host", "instagram-profile1.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                ResultInstagramFollowersDto followersDto = JsonConvert.DeserializeObject<ResultInstagramFollowersDto>(body);
                ViewBag.v1 = followersDto.followers;
                ViewBag.v2 = followersDto.following;


                var client2 = new HttpClient();
                var request2 = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://twitter32.p.rapidapi.com/getProfile?username=nike"),
                    Headers =
    {
        { "X-RapidAPI-Key", "3613fe7b65msh52cd8a29c6891cap127cb5jsnd6c43ce9351f" },
        { "X-RapidAPI-Host", "twitter32.p.rapidapi.com" },
    },
                };
                using (var response2 = await client2.SendAsync(request2))
                {
                    response2.EnsureSuccessStatusCode();
                    var body2 = await response2.Content.ReadAsStringAsync();
                    ResultTwitterFollower twitterFollower = JsonConvert.DeserializeObject<ResultTwitterFollower>(body2);
                    ViewBag.v3 = twitterFollower.data.user_info.followers_count;
                    ViewBag.v4 = twitterFollower.data.user_info.friends_count;
                }


                var client3 = new HttpClient();
                var request3 = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://fresh-linkedin-profile-data.p.rapidapi.com/get-linkedin-profile?linkedin_url=https%3A%2F%2Fwww.linkedin.com%2Fin%2Fmehmet-karakuss%2F"),
                    Headers =
    {
        { "X-RapidAPI-Key", "3613fe7b65msh52cd8a29c6891cap127cb5jsnd6c43ce9351f" },
        { "X-RapidAPI-Host", "fresh-linkedin-profile-data.p.rapidapi.com" },
    },
                };
                using (var response3 = await client3.SendAsync(request3))
                {
                    response3.EnsureSuccessStatusCode();
                    var body3 = await response3.Content.ReadAsStringAsync();
                    ResultLinkedinFollowersDto resultLinkedin = JsonConvert.DeserializeObject<ResultLinkedinFollowersDto>(body3);
                    ViewBag.v5 = resultLinkedin.data.followers_count;
                }
            }
            return View();
        }
    }
}
