using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.DTOS.ProductsCommBank
{
    public class ProductsResponseApiDto
    {
        [JsonProperty("data")]
        public DataDto? Data { get; set; }

    }
}
