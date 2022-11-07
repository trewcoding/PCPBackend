namespace Domain.Entities.Product
{
   public class ProductConstraint
    {
        public Guid ConstraintId { get; set; }
        public string? ProductDataEfProductId { get; set; }
        public string ConstraintType { get; set; } = null!;
        public string? AdditionalValue { get; set; }
        public string? AdditionalInfo { get; set; }
    }
}
