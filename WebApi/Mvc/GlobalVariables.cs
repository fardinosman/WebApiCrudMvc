using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace Mvc
{
    public class GlobalVariables
    {
        public static HttpClient WebApiClient = new HttpClient();

          static GlobalVariables()
        {
            //in real exsample we have something like "http://exsample.com/api"
            WebApiClient.BaseAddress = new Uri("https://localhost:44302/api/");
            WebApiClient.DefaultRequestHeaders.Clear();

            WebApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}