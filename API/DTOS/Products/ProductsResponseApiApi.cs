using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.DTOS.Products
{
    public class ProductsResponseApiApi
    {
        [JsonProperty("data")]
        public DataApi Data { get; set; }

    }
}
