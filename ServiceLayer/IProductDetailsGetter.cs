using Domain.Entities.ProductsCommBank;

namespace ServiceLayer
{
    public interface IProductDetailsGetter
    {
        Task<string> GetProductDetailsAsync(List<Products> product, string bank);
    }
}
