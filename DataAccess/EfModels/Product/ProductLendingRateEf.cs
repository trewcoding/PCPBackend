namespace DataAccess.EfModels.Product
{
    public class ProductLendingRateEf
    {
        public Guid LendingRatesId { get; set; }
        public string ProductDataEfProductId { get; set; }
        public string LendingRateType { get; set; }
        public string Rate { get; set; }
        public string CalculationFrequency { get; set; }
        public string AdditionalInfo { get; set; }
    }
}
