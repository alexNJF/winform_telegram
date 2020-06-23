using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramBot
{
    class message
    {
        public int message_id { get; set; }
         public string date { get; set; }
         public string  text { get; set; }

         public User from;
         public Chat chat;

    }
}
