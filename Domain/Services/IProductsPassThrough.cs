using DataAccess.EfModels.Products;
using Domain.Entities.Product;
using Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public interface IProductsPassThrough
    {
        Task<List<string>> SaveProductsPassThrough(ProductsResponseApi products);
        Task SaveProductPassThrough(ProductData product);
        Task<ProductData> GetProductDetailsPassThrough(string productId);
        Task<List<Products>> GetAllProductsPassThrough();
    }
}
