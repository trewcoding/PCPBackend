namespace DataAccess.EfModels.Product
{
    public class ProductDiscountEf
    {
        public Guid DiscountId { get; set; } = Guid.NewGuid();
        public Guid? ProductFeeEfFeeId { get; set; }
        public string? Description { get; set; }
        public string? DiscountType { get; set; }
        public string? Amount { get; set; }
        public List<ProductEligibilityEf>? Eligibility { get; set; }
    }
}
