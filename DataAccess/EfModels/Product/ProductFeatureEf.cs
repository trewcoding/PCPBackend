namespace DataAccess.EfModels.Product
{
    public class ProductFeatureEf
    { 
        public Guid FeatureId { get; set; } = Guid.NewGuid();
        public string? ProductDataEfProductId { get; set; }
        public string? FeatureType { get; set; }
        public string? AdditionalValue { get; set; }
        public string? AdditionalInfo { get; set; }
        public string? AdditionalInfoUri { get; set; }
    }
}
