using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Dtos.SubscribesSocialDto
{
    public class ResultTwitterFollower
    {
            public Data data { get; set; }
        public class Data
        {
            public User_Info user_info { get; set; }
        }

        public class User_Info
        {

            public int followers_count { get; set; }
            public int friends_count { get; set; }
        
        }

    }
}
