using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EfModels
{
    public class DataEF
    {
        [JsonProperty("products")]
        public List<ProductEF> Products { get; set; }
    }
}
