using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServiceLayer.DTOS.Product
{
    public class ProductConstraintSl
    {
        public Guid ConstraintId { get; set; }
        public string ProductDataEfProductId { get; set; }
        public string? ConstraintType { get; set; }
        public string? AdditionalValue { get; set; }
        public string? AdditionalInfo { get; set; }
    }
}
