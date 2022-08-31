using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.ProductsCommBank
{
    public class Data
    {
        [JsonProperty("products")]
        public List<Products> Products { get; set; }
    }
}
