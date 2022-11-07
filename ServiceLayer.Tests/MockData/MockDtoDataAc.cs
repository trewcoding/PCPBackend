using ApiClients.DTOS.Product;
using ApiClients.DTOS.Products;
using Domain.Entities.Products;

namespace ServiceLayer.UnitTests.MockData
{
    public class MockDtoDataAc
    {
        public static ProductResponseApiAc productResponseApiAc()
        {

            ProductConstraintAc productConstraintAc = new ProductConstraintAc()
            {
                ConstraintId = Guid.Empty,
                ProductDataEfProductId = "ProductId1",
                ConstraintType = "ConstraintType",
                AdditionalValue = "ConstraintValue",
                AdditionalInfo = "ConstraintInfo",
            };
            ProductFeatureAc productFeatureAc = new ProductFeatureAc()
            {
                FeatureId = Guid.Empty,
                ProductDataEfProductId = "ProductId1",
                FeatureType = "FeatureType",
                AdditionalValue = "AdditionalValue",
                AdditionalInfo = "AdditionalInfo",
                AdditionalInfoUri = "AdditionalInfoUri",
            };
            ProductLendingRateAc productLendingRateAc = new ProductLendingRateAc()
            {
                LendingRatesId = Guid.Empty,
                ProductDataEfProductId = "ProductDataEfProductId",
                LendingRateType = "LendingRateType",
                Rate = "Rate",
                CalculationFrequency = "CalculationFrequency",
                AdditionalInfo = "AdditionalInfo",
            };
            ProductEligibilityAc productEligibilityAc = new ProductEligibilityAc()
            {
                EligibilityId = Guid.Empty,
                ProductDataEfProductId = "ProductDataEfProductId",
                EligibilityType = "EligibilityType",
                AdditionalValue = "AdditionalValue",
                AdditionalInfo = "AdditionalInfo",
                DiscountEligibilityType = "DiscountEligibilityType",
            };
            ProductDiscountAc productDiscountAc = new ProductDiscountAc()
            {
                DiscountId = Guid.Empty,
                ProductFeeEfFeeId = Guid.Empty,
                Description = "Description",
                DiscountType = "DiscountType",
                Amount = "Amount",
                Eligibility = new List<ProductEligibilityAc>() { productEligibilityAc },
            };
            ProductFeeAc productFeeAc = new ProductFeeAc()
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
                Discounts = new List<ProductDiscountAc>() { productDiscountAc },
            };
            ProductResponseApiAc productResponseApiAc = new ProductResponseApiAc()
            {
                Data = new ProductDataAc()
                {
                    Constraints = new List<ProductConstraintAc>() { productConstraintAc },
                    Features = new List<ProductFeatureAc>() { productFeatureAc },
                    Eligibility = new List<ProductEligibilityAc>() { productEligibilityAc },
                    Fees = new List<ProductFeeAc>() { productFeeAc },
                    LendingRates = new List<ProductLendingRateAc>() { productLendingRateAc },
                    AdditionalInformation = new ProductAdditionalInformationAc()
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
            return productResponseApiAc;
        }

        public static ProductsResponseApiAc listProductsAc()
        {
            ProductsAc productsAc = new ProductsAc
            {
                ProductId = "ProductId1",
                LastUpdated = DateTime.Today,
                Name = "NameOfProduct",
                Brand = "BrandOfProduct",
                BrandName = "BrandNameOfProduct",
                ProductCategory = "",
            };
            ProductsResponseApiAc productsResponseApiAc = new ProductsResponseApiAc
            {
                Data = new DataAc()
                {
                    Products = new List<ProductsAc>() { productsAc }
                }
            };
            return productsResponseApiAc;
        }

    }
}

