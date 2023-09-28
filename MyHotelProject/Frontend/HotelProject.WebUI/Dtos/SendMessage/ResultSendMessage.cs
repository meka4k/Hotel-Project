using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Dtos.SendMessage
{
    public class ResultSendMessage
    {
        public int SendMessageId { get; set; }
        public string RecieverName { get; set; }
        public string RecieverMail { get; set; }
        public string SenderName { get; set; }
        public string SenderMail { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
    }
}
