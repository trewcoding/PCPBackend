using Newtonsoft.Json;

namespace ApiCients.DTOS.ProductCommBank
{
    public class ProductResponseApiDto
    {
        [JsonProperty("data")]
        public ProductDataDto Data { get; set; }
    }


}
