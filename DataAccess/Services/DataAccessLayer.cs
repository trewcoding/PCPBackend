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
        public async Task<string> SaveProduct(List<Product> products)
        {
            //productEF =  _dbContext.ProductsDataSet.in(x=>x.ProductId.Equals())
            // ProductEF productEF = null;

            //if (productEF != null)
            //{
            //    throw new Exception();
            //}
            foreach (var item in products)
            {
                var product = await  _dbContext.ProductsDataSet.FirstOrDefaultAsync(x => x.ProductId.Equals(item.ProductId));
                if (product == null)
                {
                    var mappedValue = _mapper.Map<ProductEF>(item);
                    _dbContext.ProductsDataSet.Add(mappedValue);
                }
                else
                {
                    product.Brand = item.Brand;
                }
            }
           
            await _dbContext.SaveChangesAsync();
            //return mappedValue.ProductId;
            return String.Empty;
            
        }
    }
}
