using Newtonsoft.Json;

namespace ServiceLayer.DTOS.ProductCommBank
{
    public class ProductResponseApiSL
    {
        [JsonProperty("data")]
        public ProductDataSL Data { get; set; }
    }


}
