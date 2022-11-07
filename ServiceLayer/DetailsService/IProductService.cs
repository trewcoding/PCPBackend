using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTOS.Product;
using ServiceLayer.DTOS.Products;

namespace ServiceLayer.DetailsService
{
    public interface IProductService
    {
        Task SaveProductAsync(string productId, string bank);
        Task<List<string>> SaveProductsExternalCall(string bank);
        Task<ProductDataSl> GetProductDetails(string productId);
        Task<List<ProductsSl>> GetAllProducts();
    }
}
