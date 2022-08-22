using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EfModels
{
    public class ProductResponseApiEF
    {
        [JsonProperty("data")]
        public DataEF Data { get; set; }
    }
}
