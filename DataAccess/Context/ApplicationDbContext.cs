using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.EfModels;

namespace DataAccess.Context
{
    public class ApplicationDbContext : DbContext
    {
        private const string schema = "dbo";
        public virtual DbSet<ProductEF> ProductsDataSet { get; set; }
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema(schema).Entity<ProductEF>().ToTable("Products").HasKey(p => p.ProductId);
            base.OnModelCreating(modelBuilder);
        }
    }
}
