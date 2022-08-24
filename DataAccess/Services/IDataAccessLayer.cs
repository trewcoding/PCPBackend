using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public interface IDataAccessLayer
    {
        Task<string> SaveProduct(List<Product> product);
    }
}
