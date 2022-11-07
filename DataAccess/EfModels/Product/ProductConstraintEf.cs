namespace DataAccess.EfModels.Product
{
    public class ProductConstraintEf
    {
        public Guid ConstraintId { get; set; } = Guid.NewGuid();
        public string? ProductDataEfProductId { get; set; }
        public string? ConstraintType { get; set; }
        public string? AdditionalValue { get; set; }
        public string? AdditionalInfo { get; set; }
    }
}
