using Domain.Entities.Product;
using Domain.Entities.Products;

namespace Domain.Services
{
    public class StringProcessing : IStringProcessing
    {
        public async Task<ProductData> StringReplaceProduct(ProductData productData)
        {
            await Task.Run(() =>
            {
                var adelaideBankReplace = new List<string>() { "AFG Home Loans Alpha", "Connective Home Loans Select",
                "Aussie Elevate", "Tic:Toc", "Mezy Home Loans", "mortgageport", "Pepper Money", "MyBudget",
                "Well Home Loans", "AMO", "Credabl", "Mortgage House", "emoney", "Finance Path", "Dreamstreet" };
                for (int i = 0; i < adelaideBankReplace.Count; i++)
                {
                    if (productData.Brand == adelaideBankReplace[i])
                    {
                        productData.Brand = productData.Brand.Replace(adelaideBankReplace[i], "Adelaide Bank");
                    }
                }
                for (int i = 0; i < productData.Features?.Count; i++)
                {
                    productData.Features[i].FeatureType = productData.Features[i].FeatureType.Replace("_", " ").ToLower();
                }
                for (int i = 0; i < productData.Constraints?.Count; i++)
                {
                    productData.Constraints[i].ConstraintType = productData.Constraints[i].ConstraintType.Replace("_", " ").ToLower();
                }
                for (int i = 0; i < productData.Eligibility?.Count; i++)
                {
                    productData.Eligibility[i].EligibilityType = productData.Eligibility[i].EligibilityType.Replace("_", " ").ToLower();
                }
                for (int i = 0; i < productData.Fees?.Count; i++)
                {
                    productData.Fees[i].FeeType = productData.Fees[i].FeeType.Replace("_", " ").ToLower();
                    for (int j = 0; j < productData.Fees[i].Discounts?.Count; j++)
                    {
                        productData.Fees[i].Discounts[j].DiscountType = productData.Fees[i].Discounts[j].DiscountType.Replace("_", " ").ToLower();
                        for (int k = 0; k < productData.Fees[i].Discounts[j].Eligibility?.Count; k++)
                        {
                            productData.Fees[i].Discounts[j].Eligibility[k].DiscountEligibilityType = productData.Fees[i].Discounts[j].Eligibility[k].DiscountEligibilityType.Replace("_", " ").ToLower();
                        }
                    }
                }
                for (int i = 0; i < productData.LendingRates?.Count; i++)
                {
                    productData.LendingRates[i].LendingRateType = productData.LendingRates[i].LendingRateType.Replace("_", " ").ToLower();
                }
                if (productData.Brand == "BT")
                {
                    productData.Brand = productData.Brand.Replace("BT", "Westpac");
                }
                if (productData.Brand == "STL")
                {
                    productData.Brand = productData.Brand.Replace("STL", "BENDIGO");
                }
                if (productData.Brand == "Macquarie Bank Limited")
                {
                    productData.Brand = productData.Brand.Replace("Macquarie Bank Limited", "Macquarie Bank");
                }
                productData.ProductCategory = productData.ProductCategory?.Replace("_", " ").ToLower();
                if (productData.ProductCategory == "trans and savings accounts")
                {
                    productData.ProductCategory = productData.ProductCategory.Replace("trans and savings accounts", "transaction and savings accounts");
                }
                if (productData.ProductCategory == "cred and chrg cards")
                {
                    productData.ProductCategory = productData.ProductCategory.Replace("cred and chrg cards", "credit and charge cards");
                }
                if (productData.ProductCategory == "pers loans")
                {
                    productData.ProductCategory = productData.ProductCategory.Replace("pers loans", "personal loans");
                }
                return productData;
            });
            return productData;

        }
        public async Task<ProductsResponseApi> StringReplaceProducts(ProductsResponseApi productData)
        {
            await Task.Run(() =>
            {
                var adelaideBankReplace = new List<string>() { "AFG Home Loans Alpha", "Connective Home Loans Select",
                "Aussie Elevate", "Tic:Toc", "Mezy Home Loans", "mortgageport", "Pepper Money", "MyBudget",
                "Well Home Loans", "AMO", "Credabl", "Mortgage House", "emoney", "Finance Path", "Dreamstreet" };
                var response = productData.Data.Products;
                for (int i = 0; i < response.Count; i++)
                {
                    response[i].ProductCategory = response[i].ProductCategory.Replace("_", " ").ToLower();
                    if (response[i].ProductCategory == "trans and savings accounts")
                    {
                        response[i].ProductCategory = response[i].ProductCategory.Replace("trans and savings accounts", "transaction and savings accounts");
                    }
                    if (response[i].ProductCategory == "cred and chrg cards")
                    {
                        response[i].ProductCategory = response[i].ProductCategory.Replace("cred and chrg cards", "credit and charge cards");
                    }
                    if (response[i].ProductCategory == "pers loans")
                    {
                        response[i].ProductCategory = response[i].ProductCategory.Replace("pers loans", "personal loans");
                    }
                    if (response[i].Brand == "BT")
                    {
                        response[i].Brand = response[i].Brand.Replace("BT", "Westpac");
                    }
                    if (response[i].Brand == "STL")
                    {
                        response[i].Brand = response[i].Brand.Replace("STL", "BENDIGO");
                    }
                    for (int j = 0; j < adelaideBankReplace.Count; j++)
                    {
                        if (response[i].Brand == adelaideBankReplace[j])
                        {
                            response[i].Brand = response[i].Brand.Replace(adelaideBankReplace[j], "Adelaide Bank");
                        }
                    }
                    if (response[i].Brand == "Macquarie Bank Limited")
                    {
                        response[i].Brand = response[i].Brand.Replace("Macquarie Bank Limited", "Macquarie Bank");
                    }
                }
            });
            return productData;
        }
    }
}
