using Domain.Entities.ProductsCommBank;

namespace DataAccess.Services
{
    public interface IDataAccessLayer
    {
        Task<string> SaveProducts(List<Products> product);
    }
}
