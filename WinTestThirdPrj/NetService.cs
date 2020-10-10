using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WinTestThirdPrj
{
    class NetService
    {
        const string Url = "";
        private HttpClient GetClient()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            return client;
        }

        public async Task<string> GetDialogs(request_objs ReqO)
        {
            HttpClient client = GetClient();
            string result = await client.GetStringAsync(Url);
            return result;
        }

        public async Task<IEnumerable<Message>> GetMessages(request_objs ReqO)
        {
            HttpClient client = GetClient();
            string result = await client.GetStringAsync(Url);
            return JsonConvert.DeserializeObject<IEnumerable<Message>>(result);
        }

        public async void AddDialog(request_objs ReqO, string login)
        {
            HttpClient client = GetClient();
            string result = await client.GetStringAsync(Url);
        }

        public async void AddMessage(request_objs ReqO)
        {
            HttpClient client = GetClient();
            string result = await client.GetStringAsync(Url);
        }
    }

}

