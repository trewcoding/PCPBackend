namespace DataAccess.EfModels.Product
{
    public class ProductFeeEf
    {
        public Guid FeeId { get; set; } = Guid.NewGuid();
        public string? ProductDataEfProductId { get; set; }
        public string? Name { get; set; }
        public string? FeeType { get; set; }
        public string? Amount { get; set; }
        public string? Currency { get; set; }
        public string? AdditionalInfo { get; set; }
        public string? AdditionalValue { get; set; }
        public List<ProductDiscountEf>? Discounts { get; set; }
        public string? TransactionRate { get; set; }
    }
}
