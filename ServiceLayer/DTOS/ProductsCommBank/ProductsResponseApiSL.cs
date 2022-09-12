using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DTOS.ProductsCommBank
{
    public class ProductsResponseApiSL
    {
        [JsonProperty("data")]
        public DataSL Data { get; set; }

    }
}
