using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace app_buldstory.Services
{
    public static class HttpService
    {
        public static HttpClient client; 

        public static HttpClient GetInstance()
        {
            if(client == null)
            {
                client = new HttpClient();
            }
            return client;
        }

    }
}
