using AutoMapper;
using DataAccess.Context;
using DataAccess.EfModels.ProductsCommBank;
using Domain.Entities.ProductsCommBank;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
