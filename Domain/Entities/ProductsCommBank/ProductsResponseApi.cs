using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.ProductsCommBank
{
    public class ProductsResponseApi
    {
        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}
