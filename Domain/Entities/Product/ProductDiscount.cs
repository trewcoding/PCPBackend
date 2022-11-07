namespace Domain.Entities.Product
{
    public class ProductDiscount
    {
        public Guid DiscountId { get; set; }
        public Guid ProductFeeEfFeeId { get; set; }
        public string? Description { get; set; }
        public string DiscountType { get; set; } = null!;
        public string? Amount { get; set; }
        public List<ProductEligibility>? Eligibility { get; set; }
    }
}
