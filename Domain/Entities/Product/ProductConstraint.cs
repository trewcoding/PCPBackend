namespace Domain.Entities.Product
{
   public class ProductConstraint
    {
        public Guid ConstraintId { get; set; }
        public virtual string? ProductDataEfProductId { get; set; }
        public string? ConstraintType { get; set; }
        public string? AdditionalValue { get; set; }
        public string? AdditionalInfo { get; set; }
    }
}
