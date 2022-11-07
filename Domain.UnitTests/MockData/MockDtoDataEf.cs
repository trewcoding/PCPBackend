using DataAccess.EfModels.Product;
using DataAccess.EfModels.Products;

namespace Domain.UnitTests.MockData
{
    public class MockDtoDataEf
        {
            public static ProductDataEf productDataEf()
            {

                ProductConstraintEf productConstraintEf = new ProductConstraintEf()
                {
                    ConstraintId = Guid.Empty,
                    ProductDataEfProductId = "ProductId1",
                    ConstraintType = "ConstraintType",
                    AdditionalValue = "ConstraintValue",
                    AdditionalInfo = "ConstraintInfo",
                };
                ProductFeatureEf productFeatureEf = new ProductFeatureEf()
                {
                    FeatureId = Guid.Empty,
                    ProductDataEfProductId = "ProductId1",
                    FeatureType = "FeatureType",
                    AdditionalValue = "AdditionalValue",
                    AdditionalInfo = "AdditionalInfo",
                    AdditionalInfoUri = "AdditionalInfoUri",
                };
                ProductLendingRateEf productLendingRateEf = new ProductLendingRateEf()
                {
                    LendingRatesId = Guid.Empty,
                    ProductDataEfProductId = "ProductDataEfProductId",
                    LendingRateType = "LendingRateType",
                    Rate = "Rate",
                    CalculationFrequency = "CalculationFrequency",
                    AdditionalInfo = "AdditionalInfo",
                };
                ProductEligibilityEf productEligibilityEf = new ProductEligibilityEf()
                {
                    EligibilityId = Guid.Empty,
                    ProductDataEfProductId = "ProductDataEfProductId",
                    EligibilityType = "EligibilityType",
                    AdditionalValue = "AdditionalValue",
                    AdditionalInfo = "AdditionalInfo",
                    DiscountEligibilityType = "DiscountEligibilityType",
                };
                ProductDiscountEf productDiscountEf = new ProductDiscountEf()
                {
                    DiscountId = Guid.Empty,
                    ProductFeeEfFeeId = Guid.Empty,
                    Description = "Description",
                    DiscountType = "DiscountType",
                    Amount = "Amount",
                    Eligibility = new List<ProductEligibilityEf>() { productEligibilityEf },
                };
                ProductFeeEf productFeeEf = new ProductFeeEf()
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
                    Discounts = new List<ProductDiscountEf>() { productDiscountEf },
                };
                //ProductResponseApiEf productResponseApiEf = new ProductResponseApiEf()
                //{
                //    Data = new ProductDataEf()
                ProductDataEf productDataEf = new ProductDataEf()
                {
                    Constraints = new List<ProductConstraintEf>() { productConstraintEf },
                    Features = new List<ProductFeatureEf>() { productFeatureEf },
                    Eligibility = new List<ProductEligibilityEf>() { productEligibilityEf },
                    Fees = new List<ProductFeeEf>() { productFeeEf },
                    LendingRates = new List<ProductLendingRateEf>() { productLendingRateEf },
                    AdditionalInformation = new ProductAdditionalInformationEf()
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
                return productDataEf;
            }
            public static ProductResponseApiEf productResponseApiEf()
            {
                ProductConstraintEf productConstraintEf = new ProductConstraintEf()
                {
                    ConstraintId = Guid.Empty,
                    ProductDataEfProductId = "ProductId1",
                    ConstraintType = "ConstraintType",
                    AdditionalValue = "ConstraintValue",
                    AdditionalInfo = "ConstraintInfo",
                };
                ProductFeatureEf productFeatureEf = new ProductFeatureEf()
                {
                    FeatureId = Guid.Empty,
                    ProductDataEfProductId = "ProductId1",
                    FeatureType = "FeatureType",
                    AdditionalValue = "AdditionalValue",
                    AdditionalInfo = "AdditionalInfo",
                    AdditionalInfoUri = "AdditionalInfoUri",
                };
                ProductLendingRateEf productLendingRateEf = new ProductLendingRateEf()
                {
                    LendingRatesId = Guid.Empty,
                    ProductDataEfProductId = "ProductDataEfProductId",
                    LendingRateType = "LendingRateType",
                    Rate = "Rate",
                    CalculationFrequency = "CalculationFrequency",
                    AdditionalInfo = "AdditionalInfo",
                };
                ProductEligibilityEf productEligibilityEf = new ProductEligibilityEf()
                {
                    EligibilityId = Guid.Empty,
                    ProductDataEfProductId = "ProductDataEfProductId",
                    EligibilityType = "EligibilityType",
                    AdditionalValue = "AdditionalValue",
                    AdditionalInfo = "AdditionalInfo",
                    DiscountEligibilityType = "DiscountEligibilityType",
                };
                ProductDiscountEf productDiscountEf = new ProductDiscountEf()
                {
                    DiscountId = Guid.Empty,
                    ProductFeeEfFeeId = Guid.Empty,
                    Description = "Description",
                    DiscountType = "DiscountType",
                    Amount = "Amount",
                    Eligibility = new List<ProductEligibilityEf>() { productEligibilityEf },
                };
                ProductFeeEf productFeeEf = new ProductFeeEf()
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
                    Discounts = new List<ProductDiscountEf>() { productDiscountEf },
                };
                ProductResponseApiEf productResponseApiEf = new ProductResponseApiEf()
                {
                    Data = new ProductDataEf()
                    {
                        Constraints = new List<ProductConstraintEf>() { productConstraintEf },
                        Features = new List<ProductFeatureEf>() { productFeatureEf },
                        Eligibility = new List<ProductEligibilityEf>() { productEligibilityEf },
                        Fees = new List<ProductFeeEf>() { productFeeEf },
                        LendingRates = new List<ProductLendingRateEf>() { productLendingRateEf },
                        AdditionalInformation = new ProductAdditionalInformationEf()
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
                return productResponseApiEf;
            }
            public static ProductsResponseApiEf listProductsEf()
            {
                ProductsEf productsEf = new ProductsEf
                {
                    ProductId = "ProductId1",
                    LastUpdated = DateTime.Today,
                    Name = "NameOfProduct",
                    Brand = "BrandOfProduct",
                    BrandName = "BrandNameOfProduct",
                    ProductCategory = "",
                };
                ProductsResponseApiEf productsResponseApiEf = new ProductsResponseApiEf
                {
                    Data = new DataEf()
                    {
                        Products = new List<ProductsEf>() { productsEf }
                    }
                };
                return productsResponseApiEf;
            }
            public static List<ProductsEf> getListProductsEf()
            {
                ProductsEf productsEf = new ProductsEf
                {
                    ProductId = "ProductId1",
                    LastUpdated = DateTime.Today,
                    Name = "NameOfProduct",
                    Brand = "BrandOfProduct",
                    BrandName = "BrandNameOfProduct",
                    ProductCategory = "",
                };
                List<ProductsEf> productsEfs = new List<ProductsEf>() { productsEf };
                return productsEfs;
            }
        }
    }


