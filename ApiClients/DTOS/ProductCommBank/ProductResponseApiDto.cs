using Newtonsoft.Json;

namespace ApiClients.DTOS.ProductCommBank
{
    public class ProductResponseApiDto
    {
        [JsonProperty("data")]
        public ProductDataDto Data { get; set; }
    }


}
