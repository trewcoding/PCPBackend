namespace Domain.Entities.Product
{
    public class ProductDiscount
    {
        public Guid DiscountId { get; set; }
        public string? ProductFeeEfProductId { get; set; }
        public string? Description { get; set; }
        public string? DiscountType { get; set; }
        public string? Amount { get; set; }
        public List<ProductEligibility>? Eligibility { get; set; }
    }
}
