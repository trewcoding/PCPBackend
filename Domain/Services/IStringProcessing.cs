using Domain.Entities.Product;
using Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public interface IStringProcessing
    {
        Task<ProductData> StringReplaceProduct(ProductData productData);
        Task<ProductsResponseApi> StringReplaceProducts(ProductsResponseApi productData);
    }
}
