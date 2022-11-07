namespace Domain.Entities.Product
{
    public class ProductEligibility
    {
        public Guid EligibilityId { get; set; }
        public string? ProductDataEfProductId { get; set; }
        public string? EligibilityType { get; set; }
        public string? AdditionalValue { get; set; }
        public string? AdditionalInfo { get; set; }
        public string? DiscountEligibilityType { get; set; }
    }
}
