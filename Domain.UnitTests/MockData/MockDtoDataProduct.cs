using Domain.Entities.Product;
using Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.UnitTests.MockData
{
    public static class MockDtoDataProduct
    {
        public static ProductData productData()
        {

            ProductConstraint productConstraint = new ProductConstraint()
            {
                ConstraintId = Guid.Empty,
                ProductDataEfProductId = "ProductId1",
                ConstraintType = "Constraint_Type",
                AdditionalValue = "ConstraintValue",
                AdditionalInfo = "ConstraintInfo",
            };
            ProductFeature productFeature = new ProductFeature()
            {
                FeatureId = Guid.Empty,
                ProductDataEfProductId = "ProductId1",
                FeatureType = "Feature_Type",
                AdditionalValue = "AdditionalValue",
                AdditionalInfo = "AdditionalInfo",
                AdditionalInfoUri = "AdditionalInfoUri",
            };
            ProductLendingRate productLendingRate = new ProductLendingRate()
            {
                LendingRatesId = Guid.Empty,
                ProductDataEfProductId = "ProductDataEfProductId",
                LendingRateType = "Lending_Rate_Type",
                Rate = "Rate",
                CalculationFrequency = "CalculationFrequency",
                AdditionalInfo = "AdditionalInfo",
            };
            ProductEligibility productEligibility = new ProductEligibility()
            {
                EligibilityId = Guid.Empty,
                ProductDataEfProductId = "ProductDataEfProductId",
                EligibilityType = "Eligibility_Type",
                AdditionalValue = "AdditionalValue",
                AdditionalInfo = "AdditionalInfo",
                DiscountEligibilityType = "",
            };
            ProductEligibility productEligibilityDiscount = new ProductEligibility()
            {
                EligibilityId = Guid.Empty,
                ProductDataEfProductId = "",
                EligibilityType = "",
                AdditionalValue = "",
                AdditionalInfo = "",
                DiscountEligibilityType = "Discount_Eligibility_Type",
            };
            ProductDiscount productDiscount = new ProductDiscount()
            {
                DiscountId = Guid.Empty,
                ProductFeeEfFeeId = Guid.Empty,
                Description = "Description",
                DiscountType = "Discount_Type",
                Amount = "Amount",
                Eligibility = new List<ProductEligibility>() { productEligibilityDiscount },
            };
            ProductFee productFee = new ProductFee()
            {
                FeeId = Guid.Empty,
                ProductDataEfProductId = "ProductDataEfProductId",
                Name = "Name",
                FeeType = "Fee_Type",
                Amount = "Amount",
                Currency = "Currency",
                AdditionalInfo = "AdditionalInfo",
                AdditionalValue = "AdditionalValue",
                TransactionRate = "TransactionRate",
                Discounts = new List<ProductDiscount>() { productDiscount },
            };
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
                ProductCategory = "Product_Category",
                Name = "Name",
                Description = "Description",
                Brand = "Brand",
                BrandName = "BrandName",
                ApplicationUri = "ApplicationUri",
                IsTailored = true,
            };
            return productData;
        }
        public static ProductData productDataPost()
        {

            ProductConstraint productConstraint = new ProductConstraint()
            {
                ConstraintId = Guid.Empty,
                ProductDataEfProductId = "ProductId1",
                ConstraintType = "constraint type",
                AdditionalValue = "ConstraintValue",
                AdditionalInfo = "ConstraintInfo",
            };
            ProductFeature productFeature = new ProductFeature()
            {
                FeatureId = Guid.Empty,
                ProductDataEfProductId = "ProductId1",
                FeatureType = "feature type",
                AdditionalValue = "AdditionalValue",
                AdditionalInfo = "AdditionalInfo",
                AdditionalInfoUri = "AdditionalInfoUri",
            };
            ProductLendingRate productLendingRate = new ProductLendingRate()
            {
                LendingRatesId = Guid.Empty,
                ProductDataEfProductId = "ProductDataEfProductId",
                LendingRateType = "lending rate type",
                Rate = "Rate",
                CalculationFrequency = "CalculationFrequency",
                AdditionalInfo = "AdditionalInfo",
            };
            ProductEligibility productEligibility = new ProductEligibility()
            {
                EligibilityId = Guid.Empty,
                ProductDataEfProductId = "ProductDataEfProductId",
                EligibilityType = "eligibility type",
                AdditionalValue = "AdditionalValue",
                AdditionalInfo = "AdditionalInfo",
                DiscountEligibilityType = "",
            };
            ProductEligibility productEligibilityDiscount = new ProductEligibility()
            {
                EligibilityId = Guid.Empty,
                ProductDataEfProductId = "",
                EligibilityType = "",
                AdditionalValue = "",
                AdditionalInfo = "",
                DiscountEligibilityType = "discount eligibility type",
            };
            ProductDiscount productDiscount = new ProductDiscount()
            {
                DiscountId = Guid.Empty,
                ProductFeeEfFeeId = Guid.Empty,
                Description = "Description",
                DiscountType = "discount type",
                Amount = "Amount",
                Eligibility = new List<ProductEligibility>() { productEligibilityDiscount },
            };
            ProductFee productFee = new ProductFee()
            {
                FeeId = Guid.Empty,
                ProductDataEfProductId = "ProductDataEfProductId",
                Name = "Name",
                FeeType = "fee type",
                Amount = "Amount",
                Currency = "Currency",
                AdditionalInfo = "AdditionalInfo",
                AdditionalValue = "AdditionalValue",
                TransactionRate = "TransactionRate",
                Discounts = new List<ProductDiscount>() { productDiscount },
            };
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
                ProductCategory = "product category",
                Name = "Name",
                Description = "Description",
                Brand = "Brand",
                BrandName = "BrandName",
                ApplicationUri = "ApplicationUri",
                IsTailored = true,
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



        public static IEnumerable<object[]> ProductTestCases =>
        new List<object[]>
        {
            new object[] { new ProductData() {ProductCategory = "Trans_and_Savings_Accounts", ProductId="ProductId" }
                , new ProductData() { ProductCategory = "transaction and savings accounts", ProductId="ProductId" }},

            new object[] { new ProductData() {ProductCategory = "cred_And chrg cards", ProductId="ProductId" }
                , new ProductData() { ProductCategory = "credit and charge cards", ProductId="ProductId" }},

            new object[] { (new ProductData() {ProductCategory = "pers_LOAns", ProductId="ProductId" })
                , new ProductData() { ProductCategory = "personal loans", ProductId="ProductId" }},

            new object[] { (new ProductData() { Brand = "BT", ProductCategory = "Trans_and_Savings_Accounts", ProductId="ProductId" })
                , new ProductData() { Brand = "Westpac", ProductCategory = "transaction and savings accounts", ProductId="ProductId" }},

            new object[] { (new ProductData() { Brand = "STL", ProductCategory = "Trans_and_Savings_Accounts", ProductId="ProductId" })
                , new ProductData() { Brand = "BENDIGO", ProductCategory = "transaction and savings accounts", ProductId="ProductId" }},

            new object[] { (new ProductData() { Brand = "MyBudget", ProductCategory = "Trans_and_Savings_Accounts", ProductId="ProductId" })
                , (new ProductData() { Brand = "Adelaide Bank", ProductCategory = "transaction and savings accounts", ProductId="ProductId" })},

            new object[] { (new ProductData() { Brand = "Connective Home Loans Select", ProductCategory = "Trans_and_Savings_Accounts", ProductId="ProductId" })
                , (new ProductData() { Brand = "Adelaide Bank", ProductCategory = "transaction and savings accounts", ProductId="ProductId" })},

            new object[] { (new ProductData() { Brand = "Macquarie Bank Limited", ProductCategory = "Trans_and_Savings_Accounts", ProductId="ProductId" })
                , (new ProductData() { Brand = "Macquarie Bank", ProductCategory = "transaction and savings accounts", ProductId="ProductId" })},

            new object[] { productData(), productDataPost()}

        };
    }
}
