using ServiceLayer.DTOS.Product;
using ServiceLayer.DTOS.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.unitTests.MockData
{
    public class MockDtoDataSl
    {
        public static ProductDataSl productDataSl()
        {

            ProductConstraintSl productConstraintSl = new ProductConstraintSl()
            {
                ConstraintId = Guid.Empty,
                ProductDataEfProductId = "ProductId1",
                ConstraintType = "ConstraintType",
                AdditionalValue = "ConstraintValue",
                AdditionalInfo = "ConstraintInfo",
            };
            ProductFeatureSl productFeatureSl = new ProductFeatureSl()
            {
                FeatureId = Guid.Empty,
                ProductDataEfProductId = "ProductId1",
                FeatureType = "FeatureType",
                AdditionalValue = "AdditionalValue",
                AdditionalInfo = "AdditionalInfo",
                AdditionalInfoUri = "AdditionalInfoUri",
            };
            ProductLendingRateSl productLendingRateSl = new ProductLendingRateSl()
            {
                LendingRatesId = Guid.Empty,
                ProductDataEfProductId = "ProductDataEfProductId",
                LendingRateType = "LendingRateType",
                Rate = "Rate",
                CalculationFrequency = "CalculationFrequency",
                AdditionalInfo = "AdditionalInfo",
            };
            ProductEligibilitySl productEligibilitySl = new ProductEligibilitySl()
            {
                EligibilityId = Guid.Empty,
                ProductDataEfProductId = "ProductDataEfProductId",
                EligibilityType = "EligibilityType",
                AdditionalValue = "AdditionalValue",
                AdditionalInfo = "AdditionalInfo",
                DiscountEligibilityType = "DiscountEligibilityType",
            };
            ProductDiscountSl productDiscountSl = new ProductDiscountSl()
            {
                DiscountId = Guid.Empty,
                ProductFeeEfFeeId = Guid.Empty,
                Description = "Description",
                DiscountType = "DiscountType",
                Amount = "Amount",
                Eligibility = new List<ProductEligibilitySl>() { productEligibilitySl },
            };
            ProductFeeSl productFeeSl = new ProductFeeSl()
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
                Discounts = new List<ProductDiscountSl>() { productDiscountSl },
            };
            //ProductResponseApiSl productResponseApiSl = new ProductResponseApiSl()
            //{
            //    Data = new ProductDataSl()
            ProductDataSl productDataSl = new ProductDataSl()
            {
                Constraints = new List<ProductConstraintSl>() { productConstraintSl },
                Features = new List<ProductFeatureSl>() { productFeatureSl },
                Eligibility = new List<ProductEligibilitySl>() { productEligibilitySl },
                Fees = new List<ProductFeeSl>() { productFeeSl },
                LendingRates = new List<ProductLendingRateSl>() { productLendingRateSl },
                AdditionalInformation = new ProductAdditionalInformationSl()
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
            return productDataSl;
        }
        public static List<ProductsSl> listProductsSl()
        {
            ProductsSl productsSl = new ProductsSl
            {
                ProductId = "ProductId1",
                LastUpdated = DateTime.Today,
                Name = "NameOfProduct",
                Brand = "BrandOfProduct",
                BrandName = "BrandNameOfProduct",
                ProductCategory = "",
            };
            var listProductsSl = new List<ProductsSl>()
            { productsSl };
            return listProductsSl;
        }

    }
}
