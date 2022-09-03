using AutoMapper;
using DataAccess.Context;
using DataAccess.EfModels.ProductCommBank;
using DataAccess.EfModels.ProductsCommBank;
using Domain.Entities.ProductCommBank;
using Domain.Entities.ProductsCommBank;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Services
{
    public class DataAccessLayer : IDataAccessLayer
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public DataAccessLayer(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<string> SaveProducts(List<Products> products)
        {
            foreach (var item in products)
            {
                var product = await  _dbContext.ProductsDataSet.FirstOrDefaultAsync(x => x.ProductId.Equals(item.ProductId));
                if (product == null)
                {
                    var mappedValue = _mapper.Map<ProductsEF>(item);
                    _dbContext.ProductsDataSet.Add(mappedValue);
                }
                else
                {
                    product.Brand = item.Brand;
                }
            }
            await _dbContext.SaveChangesAsync();
            return String.Empty;
        }
        
        public async Task<string> SaveProduct(ProductData productData)
        {
            var product = await _dbContext.ProductDataSet.FirstOrDefaultAsync(x => x.ProductId.Equals(productData.ProductId));
            if (product == null)
            {
                var mappedValue = _mapper.Map<ProductDataEfs>(productData);
                _dbContext.ProductDataSet.Add(mappedValue);
            }
            await _dbContext.SaveChangesAsync();
            return String.Empty;
        }
        //public async Task<string> SaveProductFeature(List<ProductFeature> productFeature)
        //{
        //    foreach (var item in productFeature)
        //    {
        //        //var product = await _dbContext.ProductFeatureDataSet.FirstOrDefaultAsync(x => x.ProductIdForeginKey == productData.ProductId);
        //        string product = null;
        //        if (product == null)
        //        {
                    
        //            var mappedFeature = _mapper.Map<ProductFeatureEf>(item);
        //            _dbContext.ProductFeatureDataSet.Add(mappedFeature);
        //        }
        //    }
            
        //    await _dbContext.SaveChangesAsync();
        //    return String.Empty;
        //}
        //public async Task<string> SaveProductConstraint(List<ProductConstraint> productConstraints)
        //{
        //    if (productConstraints != null)
        //        {
        //        foreach (var item in productConstraints)
        //        {
        //            //var product = await _dbContext.ProductFeatureDataSet.FirstOrDefaultAsync(x => x.ProductIdForeginKey == productData.ProductId);
        //            string product = null;
        //            if (product == null)
        //            {

        //                var mappedConstraint = _mapper.Map<ProductConstraintEf>(item);
        //                _dbContext.ProductConstraintDataSet.Add(mappedConstraint);
        //            }
        //        }
        //    }
        //    await _dbContext.SaveChangesAsync();
        //    return String.Empty;
        //}

    }
}
