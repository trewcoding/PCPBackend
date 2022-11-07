using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.DTOS.Products
{
    public class DataApi
    {
        [JsonProperty("products")]
        public List<ProductsApi> Products { get; set; }
    }
}
