using System;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace TelegramBot
{
    class Controlls
    {
        string BaseUrl = @"https://api.telegram.org/bot" + Config.get_token() + "/";
        public static void SSL()
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }

        //base REQ methods 
        string create_requst(string url)
        {
            try
            {
                WebClient client = new WebClient();
                var result = client.DownloadString(url);
                return result;
            }
            catch (Exception ex)
            {  
                Console.WriteLine(ex.Message);
                throw ex;
            }
           
        }

        public void Decision(string ans, int chatid)
        {
            switch (ans)
            {
                case "/start":
                    show_menu(chatid);
                    break;
                case "درباره ما":
                    AboutUS(chatid);
                    break;
                case "تست دوم":
                    break;
                case "نمایش محصولات":
                    show_product(chatid);
                    break;
            }
        }

        #region ResponseFuctions
        public void show_menu(int chatid)
        {
            /*
             * raplay keyboard 
             */
            //string reply_keyboard_markup = "{" +
            //   "\"keyboard\":" +
            //   "[" +
            //   "[  \"نمایش محصولات\"  ]" +
            //   "],\"resize_keyboard\":true" +
            //   "}";

            var reply_keyboard_markup = new
            {
                keyboard = new JArray(
                    new JArray("نمایش محصولات "),
                     new JArray("درباره ما  ")
                    ),
                resize_keyboard = true
            };

            string _reply_keyboard_markup = JsonConvert.SerializeObject(reply_keyboard_markup);

            string message = "شرکت فنی تخصصی رادشید   ";
            string Chatid = chatid.ToString();
            string url = String.Format(this.BaseUrl + "sendMessage?text={0}&chat_id={1}&reply_markup={2}", message, Chatid, _reply_keyboard_markup);
            create_requst(url);
        }

        public void show_product(int chat_id)
        {
            if (Product_list.list.Count > 0)
            {
                foreach (Product _product in Product_list.list)
                {
                    string message = _product.name;
                    string Chatid = chat_id.ToString();
                    string url = String.Format(this.BaseUrl + "sendMessage?text={0}&chat_id={1}", message, Chatid);
                    create_requst(url);
                }
            }
            else
            {
                string message = "محصولی در دسترس نیست";
                string Chatid = chat_id.ToString();
                string url = String.Format(this.BaseUrl + "sendMessage?text={0}&chat_id={1}", message, Chatid);
                create_requst(url);
            }
        }

        public void AboutUS(int chat_id)
        {
            string message = "تولید شده توسط علی در شرکت راشید ";
            string Chatid = chat_id.ToString();
            string url = String.Format(this.BaseUrl + "sendMessage?text={0}&chat_id={1}", message, Chatid);
            create_requst(url);
        }
        #endregion

        public T_result get_update()
        {
            string url = this.BaseUrl + "getupdates";
            string responce = create_requst(url);
            T_result update_list = JsonConvert.DeserializeObject<T_result>(responce);
            return update_list;
        }

        public T_result get_update(string offset)
        {
            string url = string.Format(this.BaseUrl + "getupdates?offset={0}", offset);
            string responce = create_requst(url);
            T_result update_list = JsonConvert.DeserializeObject<T_result>(responce);
            return update_list;
        }
        //save latest index of array 
        public void save_index(T_result UpdateList)
        {
            int index = UpdateList.result.Count;
            List<Update> _update = UpdateList.result;
            string update_id = (_update[index - 1].update_id + 1).ToString();
            File.WriteAllText("index", update_id);
        }

        public string read_index()
        {
            string index = File.ReadAllText("index");
            return index;
        }

        public void responce(T_result t_Result)
        {
            foreach (var item in t_Result.result)
            {
                message msg = item.message;
                User from = msg.from;
                string msgtext = msg.text;
                int user_id = from.id;
                Decision(msgtext, user_id);
            }
        }

    }
}
