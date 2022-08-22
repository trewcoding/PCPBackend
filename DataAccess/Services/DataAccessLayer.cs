using AutoMapper;
using DataAccess.Context;
using DataAccess.EfModels;
using Domain.Entities;
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
        public async Task<Guid> SaveProduct(Product product)
        {
            ProductEF productEF = await _dbContext.ProductsDataSet.SingleOrDefaultAsync(p => p.ProductId == product.ProductId);
            if (productEF != null)
            {
                throw new Exception();
            }
            return _mapper.Map<Product>(productEF);
            
        }
    }
}
