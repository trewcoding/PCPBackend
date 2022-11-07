using Domain.Entities.Product;
using Domain.Entities.Products;
using ServiceLayer.DTOS.Product;
using ServiceLayer.DTOS.Products;

namespace ServiceLayer.UnitTests.MockData
{
    public class MockDtoData
    {
        public static ProductData productData()
        {

            ProductConstraint productConstraint = new ProductConstraint()
            {
                ConstraintId = Guid.Empty,
                ProductDataEfProductId = "ProductId1",
                ConstraintType = "ConstraintType",
                AdditionalValue = "ConstraintValue",
                AdditionalInfo = "ConstraintInfo",
            };
            ProductFeature productFeature = new ProductFeature()
            {
                FeatureId = Guid.Empty,
                ProductDataEfProductId = "ProductId1",
                FeatureType = "FeatureType",
                AdditionalValue = "AdditionalValue",
                AdditionalInfo = "AdditionalInfo",
                AdditionalInfoUri = "AdditionalInfoUri",
            };
            ProductLendingRate productLendingRate = new ProductLendingRate()
            {
                LendingRatesId = Guid.Empty,
                ProductDataEfProductId = "ProductDataEfProductId",
                LendingRateType = "LendingRateType",
                Rate = "Rate",
                CalculationFrequency = "CalculationFrequency",
                AdditionalInfo = "AdditionalInfo",
            };
            ProductEligibility productEligibility = new ProductEligibility()
            {
                EligibilityId = Guid.Empty,
                ProductDataEfProductId = "ProductDataEfProductId",
                EligibilityType = "EligibilityType",
                AdditionalValue = "AdditionalValue",
                AdditionalInfo = "AdditionalInfo",
                DiscountEligibilityType = "DiscountEligibilityType",
            };
            ProductDiscount productDiscount = new ProductDiscount()
            {
                DiscountId = Guid.Empty,
                ProductFeeEfFeeId = Guid.Empty,
                Description = "Description",
                DiscountType = "DiscountType",
                Amount = "Amount",
                Eligibility = new List<ProductEligibility>() { productEligibility },
            };
            ProductFee productFee = new ProductFee()
            {
                FeeId = Guid.Empty,
                ProductDataEfProductId = "ProductDataEfProductId",
                Name = "Name",
                FeeType = "FeeType",
                Amount = "Amount",
                Currency = "Currency",
                AdditionalInfo = "AdditionalInfo",
                AdditionalValue = "AdditionalValue",
                TransactionRate = "TransactionRate",
                Discounts = new List<ProductDiscount>() { productDiscount },
            };
            //ProductResponseApi productResponseApi = new ProductResponseApi()
            //{
            //    Data = new ProductData()
            ProductData productData = new ProductData()
            {
                Constraints = new List<ProductConstraint>() { productConstraint },
                Features = new List<ProductFeature>() { productFeature },
                Eligibility = new List<ProductEligibility>() { productEligibility },
                Fees = new List<ProductFee>() { productFee },
                LendingRates = new List<ProductLendingRate>() { productLendingRate },
                AdditionalInformation = new ProductAdditionalInformation()
                {
                    AdditionalInformationId = Guid.Empty,
                    ProductDataEfProductId = "ProductDataEfProductId",
                    OverviewUri = "OverviewUri",
                    TermsUri = "TermsUri",
                    EligibilityUri = "EligibilityUri",
                    FeesAndPricingUri = "FeesAndPricingUri",
                },
                ProductId = "ProductId1",
                EffectiveFrom = DateTime.Today,
                EffectiveTo = DateTime.Today,
                LastUpdated = DateTime.Today,
                ProductCategory = "ProductCategory",
                Name = "Name",
                Description = "Description",
                Brand = "Brand",
                BrandName = "BrandName",
                ApplicationUri = "ApplicationUri",
                IsTailored = true,
                //}
            };
            return productData;
        }
        public static ProductResponseApi productResponseApi()
        {

            ProductConstraint productConstraint = new ProductConstraint()
            {
                ConstraintId = Guid.Empty,
                ProductDataEfProductId = "ProductId1",
                ConstraintType = "ConstraintType",
                AdditionalValue = "ConstraintValue",
                AdditionalInfo = "ConstraintInfo",
            };
            ProductFeature productFeature = new ProductFeature()
            {
                FeatureId = Guid.Empty,
                ProductDataEfProductId = "ProductId1",
                FeatureType = "FeatureType",
                AdditionalValue = "AdditionalValue",
                AdditionalInfo = "AdditionalInfo",
                AdditionalInfoUri = "AdditionalInfoUri",
            };
            ProductLendingRate productLendingRate = new ProductLendingRate()
            {
                LendingRatesId = Guid.Empty,
                ProductDataEfProductId = "ProductDataEfProductId",
                LendingRateType = "LendingRateType",
                Rate = "Rate",
                CalculationFrequency = "CalculationFrequency",
                AdditionalInfo = "AdditionalInfo",
            };
            ProductEligibility productEligibility = new ProductEligibility()
            {
                EligibilityId = Guid.Empty,
                ProductDataEfProductId = "ProductDataEfProductId",
                EligibilityType = "EligibilityType",
                AdditionalValue = "AdditionalValue",
                AdditionalInfo = "AdditionalInfo",
                DiscountEligibilityType = "DiscountEligibilityType",
            };
            ProductDiscount productDiscount = new ProductDiscount()
            {
                DiscountId = Guid.Empty,
                ProductFeeEfFeeId = Guid.Empty,
                Description = "Description",
                DiscountType = "DiscountType",
                Amount = "Amount",
                Eligibility = new List<ProductEligibility>() { productEligibility },
            };
            ProductFee productFee = new ProductFee()
            {
                FeeId = Guid.Empty,
                ProductDataEfProductId = "ProductDataEfProductId",
                Name = "Name",
                FeeType = "FeeType",
                Amount = "Amount",
                Currency = "Currency",
                AdditionalInfo = "AdditionalInfo",
                AdditionalValue = "AdditionalValue",
                TransactionRate = "TransactionRate",
                Discounts = new List<ProductDiscount>() { productDiscount },
            };
            ProductResponseApi productResponseApi = new ProductResponseApi()
            {
                Data = new ProductData()
            {
                Constraints = new List<ProductConstraint>() { productConstraint },
                Features = new List<ProductFeature>() { productFeature },
                Eligibility = new List<ProductEligibility>() { productEligibility },
                Fees = new List<ProductFee>() { productFee },
                LendingRates = new List<ProductLendingRate>() { productLendingRate },
                AdditionalInformation = new ProductAdditionalInformation()
                {
                    AdditionalInformationId = Guid.Empty,
                    ProductDataEfProductId = "ProductDataEfProductId",
                    OverviewUri = "OverviewUri",
                    TermsUri = "TermsUri",
                    EligibilityUri = "EligibilityUri",
                    FeesAndPricingUri = "FeesAndPricingUri",
                },
                ProductId = "ProductId1",
                EffectiveFrom = DateTime.Today,
                EffectiveTo = DateTime.Today,
                LastUpdated = DateTime.Today,
                ProductCategory = "ProductCategory",
                Name = "Name",
                Description = "Description",
                Brand = "Brand",
                BrandName = "BrandName",
                ApplicationUri = "ApplicationUri",
                IsTailored = true,
                }
            };
            return productResponseApi;
        }
        public static ProductsResponseApi listProducts()
        {
            Products products = new Products
            {
                ProductId = "ProductId1",
                LastUpdated = DateTime.Today,
                Name = "NameOfProduct",
                Brand = "BrandOfProduct",
                BrandName = "BrandNameOfProduct",
                ProductCategory = "",
            };
            ProductsResponseApi productsResponseApi = new ProductsResponseApi
            {
                Data = new Data()
                {
                    Products = new List<Products>() { products }
                }
            };
            return productsResponseApi;
        }
        public static List<Products> getListProducts()
        {
            Products products = new Products
            {
                ProductId = "ProductId1",
                LastUpdated = DateTime.Today,
                Name = "NameOfProduct",
                Brand = "BrandOfProduct",
                BrandName = "BrandNameOfProduct",
                ProductCategory = "",
            };
            List<Products> productss = new List<Products>() { products };
            return productss;
        }

    }
}

