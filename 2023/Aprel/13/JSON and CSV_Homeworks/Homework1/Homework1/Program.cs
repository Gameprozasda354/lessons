using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;
using System.Net.Http;

namespace Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var client = new WebClient();
            //string json = client.DownloadString("https://api.first.org/data/v1/countries");
            //var apiJson = JsonConvert.DeserializeObject<ApiJson>(json);
            //client.Dispose();
            using (var client = new WebClient())
            {
                string json = client.DownloadString("https://api.first.org/data/v1/countries");
                var apiJson = JsonConvert.DeserializeObject<ApiJson>(json);
                List<Country> countries = new List<Country>(apiJson.Data.Values);
            }
        }
    }
}
