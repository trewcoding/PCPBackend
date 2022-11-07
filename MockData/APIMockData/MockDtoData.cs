using API.DTOS.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockData.APIMockData
{
    public class MockDtoData
    {
        ProductsApi products = new ProductsApi
        {
            ProductId = "ProductId1",
            LastUpdated = DateTime.Today,
            Name = "NameOfProduct",
            Brand = "BrandOfProduct",
            BrandName = "BrandNameOfProduct",
            ProductCategory = "",
        };
    }
}
