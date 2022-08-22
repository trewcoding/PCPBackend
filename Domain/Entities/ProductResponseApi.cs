using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ProductResponseApi
    {
        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}
