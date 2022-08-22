using DataAccess.Context;
using DataAccess.EfModels;
using Domain.Entities;
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

        public DataAccessLayer(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;

        }
        public async Task<Guid> SaveProduct(Product product)
        {
            ProductEF productEF = await _dbContext.
        }
    }
}
