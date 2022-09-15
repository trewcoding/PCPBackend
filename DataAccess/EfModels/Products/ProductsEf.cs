namespace DataAccess.EfModels.Products
{
    public class ProductsEf
    {
        public string? ProductId { get; set; }
        public DateTime LastUpdated { get; set; }
        public string? Name { get; set; }
        public string? Brand { get; set; }
        public string? BrandName { get; set; }
        public string? ProductCategory { get; set; }
    }
}
