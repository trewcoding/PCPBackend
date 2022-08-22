using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiClients.DTOS
{
    public class DataDto
    {
        [JsonProperty("products")]
        public List<ProductDto> Products { get; set; }
    }
}
