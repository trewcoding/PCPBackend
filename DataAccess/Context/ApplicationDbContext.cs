using Microsoft.EntityFrameworkCore;
using DataAccess.EfModels.ProductsCommBank;
using DataAccess.EfModels.ProductCommBank;
using DataAccess.DTOS.ProductCommBank;
using Domain.Entities.ProductCommBank;

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
            modelBuilder.HasDefaultSchema(schema).Entity<ProductFeatureEf>().ToTable("ProductFeatures").HasKey(p => p.FeatureId);
            modelBuilder.HasDefaultSchema(schema).Entity<ProductConstraintEf>().ToTable("ProductConstraint")//.HasKey(p => p.ConstraintId);
                .HasOne(e => e.ProductDataEf)
                .WithMany(d => d.Constraints)
                .HasForeignKey(e => e.ProductDataEfProductId);
            modelBuilder.HasDefaultSchema(schema).Entity<ProductAdditionalInformationEf>().ToTable("ProductAdditionalInformation").HasKey(p => p.AdditionalInformationId);
            modelBuilder.HasDefaultSchema(schema).Entity<ProductDiscountEf>().ToTable("ProductDiscount").HasKey(p => p.DiscountId);
            modelBuilder.HasDefaultSchema(schema).Entity<ProductEligibilityEf>().ToTable("ProductEligibility").HasKey(p => p.EligibilityId);
            modelBuilder.HasDefaultSchema(schema).Entity<ProductFeeEf>().ToTable("ProductFee").HasKey(p => p.FeeId);
            modelBuilder.HasDefaultSchema(schema).Entity<ProductLendingRateEf>().ToTable("ProductLendingRates").HasKey(p => p.LendingRatesId);
            base.OnModelCreating(modelBuilder);
        }
    }
}
