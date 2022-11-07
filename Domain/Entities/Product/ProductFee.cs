namespace Domain.Entities.Product
{
    public class ProductFee
    {
        public Guid FeeId { get; set; }
        public string? ProductDataEfProductId { get; set; }
        public string? Name { get; set; }
        public string? FeeType { get; set; }
        public string? Amount { get; set; }
        public string? Currency { get; set; }
        public string? AdditionalInfo { get; set; }
        public string? AdditionalValue { get; set; }
        public List<ProductDiscount>? Discounts { get; set; }
        public string? TransactionRate { get; set; }
    }
}
