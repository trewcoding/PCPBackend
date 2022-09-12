using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.DTOS.ProductsCommBank
{
    public class DataDto
    {
        [JsonProperty("products")]
        public List<ProductsDto>? Products { get; set; }
    }
}
