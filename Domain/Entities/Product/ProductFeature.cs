namespace Domain.Entities.Product
{
    public class ProductFeature
    {
        public Guid FeatureId { get; set; }
        public string? ProductDataEfProductId { get; set; }
        public string? FeatureType { get; set; }
        public string? AdditionalValue { get; set; }
        public string? AdditionalInfo { get; set; }
        public string? AdditionalInfoUri { get; set; }
    }
}
