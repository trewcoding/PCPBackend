using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.ProductsCommBank
{
    public class Products
    {
        [JsonProperty("productId")]
        public string ProductId { get; set; }

        [JsonProperty("lastUpdated")]
        public DateTime LastUpdated { get; set; }

    }
}
