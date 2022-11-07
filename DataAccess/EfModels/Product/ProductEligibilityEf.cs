namespace DataAccess.EfModels.Product
{
    public class ProductEligibilityEf
    {
        public Guid EligibilityId { get; set; } = Guid.NewGuid();
        public string? ProductDataEfProductId { get; set; }
        public Guid? ProductDiscountEfDiscountId { get; set; }
        public string EligibilityType { get; set; }
        public string? AdditionalValue { get; set; }
        public string? AdditionalInfo { get; set; }
        public string? DiscountEligibilityType { get; set; }
    }
}
