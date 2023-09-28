using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Dtos.SubscribesSocialDto
{
    public class ResultLinkedinFollowersDto
    {

            public Data data { get; set; }


        public class Data
        {
            public int followers_count { get; set; }
        }


       

    }
}
