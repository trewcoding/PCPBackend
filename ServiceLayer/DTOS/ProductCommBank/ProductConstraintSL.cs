﻿using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServiceLayer.DTOS.ProductCommBank
{
    public class ProductConstraintSL
    {
        [Key]
        [JsonProperty("constraintId")]
        public Guid ConstraintId { get; set; }
        [ForeignKey("productDataEfProductId")]
        [JsonProperty("productDataEfProductId")]
        public virtual string ProductDataEfProductId { get; set; }
        [JsonProperty("constraintType")]
        public string ConstraintType { get; set; }

        [JsonProperty("additionalValue")]
        public string AdditionalValue { get; set; }

        [JsonProperty("additionalInfo")]
        public string AdditionalInfo { get; set; }

        public virtual ProductDataSL ProductDataDto { get; set; }
    }
}
