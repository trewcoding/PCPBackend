using Microsoft.EntityFrameworkCore;
using DataAccess.EfModels.ProductsCommBank;
using DataAccess.EfModels.ProductCommBank;

namespace DataAccess.Context
{
    public class ApplicationDbContext : DbContext
    {
        private const string schema = "dbo";
        public virtual DbSet<ProductsEF> ProductsDataSet { get; set; }
        public virtual DbSet<ProductDataEfs> ProductDataSet { get; set; }
        public virtual DbSet<ProductFeatureEf> ProductFeatureDataSet { get; set; }
        public virtual DbSet<ProductConstraintEf> ProductConstraintDataSet { get; set; }
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema(schema).Entity<ProductsEF>().ToTable("Products").HasKey(p => p.ProductId);
            modelBuilder.HasDefaultSchema(schema).Entity<ProductDataEfs>().ToTable("Product").HasKey(p => p.ProductId);
            modelBuilder.HasDefaultSchema(schema).Entity<ProductFeatureEf>().ToTable("ProductFeatures").HasKey(p => p.FeatureId);
            modelBuilder.HasDefaultSchema(schema).Entity<ProductConstraintEf>().ToTable("ProductConstraint").HasKey(p => p.ConstraintId);
            base.OnModelCreating(modelBuilder);
        }
    }
}
