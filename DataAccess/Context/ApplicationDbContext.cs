using Microsoft.EntityFrameworkCore;
using DataAccess.EfModels.ProductsCommBank;
using DataAccess.EfModels.ProductCommBank;

namespace DataAccess.Context
{
    public class ApplicationDbContext : DbContext
    {
        private const string schema = "dbo";
        public virtual DbSet<ProductsEF> ProductsDataSet { get; set; }
        public virtual DbSet<ProductDataEf> ProductDataSet { get; set; }
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema(schema).Entity<ProductsEF>().ToTable("Products").HasKey(p => p.ProductId);
            modelBuilder.HasDefaultSchema(schema).Entity<ProductDataEf>().ToTable("Product").HasKey(p => p.ProductId);
            base.OnModelCreating(modelBuilder);
        }
    }
}
