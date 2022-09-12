using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DTOS.ProductsCommBank
{
    public class DataSL
    {
        [JsonProperty("products")]
        public List<ProductsSL> Products { get; set; }
    }
}
