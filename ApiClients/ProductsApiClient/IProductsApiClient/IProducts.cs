using ApiClients.DTOS;
using DataAccess.EfModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiClients.ProductsApiClient.IProductsApiClient
{
    public interface IProducts
    {
        Task<ProductResponseApi> GetProducts();
    }
}
