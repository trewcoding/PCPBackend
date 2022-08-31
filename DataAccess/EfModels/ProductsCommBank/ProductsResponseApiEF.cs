using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EfModels.ProductsCommBank
{
    public class ProductsResponseApiEF
    {
        [JsonProperty("data")]
        public DataEF Data { get; set; }
    }
}
