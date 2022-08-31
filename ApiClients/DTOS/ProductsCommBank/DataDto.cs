using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiClients.DTOS.ProductsCommBank
{
    public class DataDto
    {
        [JsonProperty("products")]
        public List<ProductDto> Products { get; set; }
    }
}
