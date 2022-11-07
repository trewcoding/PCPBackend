using API.DTOS.Product;
using API.DTOS.Products;
using ServiceLayer.DTOS.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.unitTests.MockData
{
    public class MockDataDtoApi
    {
        public static ProductDataApi productDataApi()
        {
            ProductConstraintApi productConstraintApi = new ProductConstraintApi()
            {
                ConstraintId = Guid.Empty,
                ProductDataEfProductId = "ProductId1",
                ConstraintType = "ConstraintType",
                AdditionalValue = "ConstraintValue",
                AdditionalInfo = "ConstraintInfo",
            };
            ProductFeatureApi productFeatureApi = new ProductFeatureApi()
            {
                FeatureId = Guid.Empty,
                ProductDataEfProductId = "ProductId1",
                FeatureType = "FeatureType",
                AdditionalValue = "AdditionalValue",
                AdditionalInfo = "AdditionalInfo",
                AdditionalInfoUri = "AdditionalInfoUri",
            };
            ProductLendingRateApi productLendingRateApi = new ProductLendingRateApi()
            {
                LendingRatesId = Guid.Empty,
                ProductDataEfProductId = "ProductDataEfProductId",
                LendingRateType = "LendingRateType",
                Rate = "Rate",
                CalculationFrequency = "CalculationFrequency",
                AdditionalInfo = "AdditionalInfo",
            };
            ProductEligibilityApi productEligibilityApi = new ProductEligibilityApi()
            {
                EligibilityId = Guid.Empty,
                ProductDataEfProductId = "ProductDataEfProductId",
                EligibilityType = "EligibilityType",
                AdditionalValue = "AdditionalValue",
                AdditionalInfo = "AdditionalInfo",
                DiscountEligibilityType = "DiscountEligibilityType",
            };
            ProductDiscountApi productDiscountApi = new ProductDiscountApi()
            {
                DiscountId = Guid.Empty,
                ProductFeeEfFeeId = Guid.Empty,
                Description = "Description",
                DiscountType = "DiscountType",
                Amount = "Amount",
                Eligibility = new List<ProductEligibilityApi>() { productEligibilityApi },
            };
            ProductFeeApi productFeeApi = new ProductFeeApi()
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
                Discounts = new List<ProductDiscountApi>() { productDiscountApi },
            };
            //ProductResponseApiApi productResponseApiApi = new ProductResponseApiApi()
            //{
            //    Data = new ProductDataApi()
            //    {
            ProductDataApi productDataApi = new ProductDataApi()
            {
                Constraints = new List<ProductConstraintApi>() { productConstraintApi },
                Features = new List<ProductFeatureApi>() { productFeatureApi },
                Eligibility = new List<ProductEligibilityApi>() { productEligibilityApi },
                Fees = new List<ProductFeeApi>() { productFeeApi },
                LendingRates = new List<ProductLendingRateApi>() { productLendingRateApi },
                AdditionalInformation = new ProductAdditionalInformationApi()
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
            return productDataApi;
        }
        public static List<ProductsApi> listProductsApi()
        {
            ProductsApi productsApi = new ProductsApi
            {
                ProductId = "ProductId1",
                LastUpdated = DateTime.Today,
                Name = "NameOfProduct",
                Brand = "BrandOfProduct",
                BrandName = "BrandNameOfProduct",
                ProductCategory = "CategoryOfProduct",
            };
            var listProductsApi = new List<ProductsApi>()
            { productsApi };
            return listProductsApi;
        }
    }
}
