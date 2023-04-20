using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Homework1
{
    public class Country
    {
        [JsonProperty("country")]
        public string CountryName { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }
    }
}
