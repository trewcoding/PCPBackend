using Domain.Entities.Product;
using Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class StringProcessing : IStringProcessing
    {
        public async Task<ProductData> StringReplaceProduct(ProductData productData)
        {
            var adelaideBankReplace = new List<string>() { "AFG Home Loans Alpha", "Connective Home Loans Select",
                "Aussie Elevate", "Tic:Toc", "Mezy Home Loans", "mortgageport", "Pepper Money", "MyBudget",
                "Well Home Loans", "AMO", "Credabl", "Mortgage House", "emoney", "Finance Path", "Dreamstreet" };
            foreach (var item in adelaideBankReplace)
            {
                if (productData.Brand == item)
                {
                    productData.Brand = productData.Brand.Remove(0).Insert(0, "Adelaide Bank");
                }
            }
            foreach (var items in productData.Features)
            {
                items.FeatureType = items.FeatureType.Replace("_", " ").ToLower();
            }
            foreach (var items in productData.Constraints)
            {
                items.ConstraintType = items.ConstraintType.Replace("_", " ").ToLower();
            }
            foreach (var items in productData.Eligibility)
            {
                items.EligibilityType = items.EligibilityType.Replace("_", " ").ToLower();
            }
            try
            {
                foreach (var items in productData.Fees)
                {
                    items.FeeType = items.FeeType.Replace("_", " ").ToLower();
                    foreach (var item in items.Discounts)
                    {
                        item.DiscountType = item.DiscountType.Replace("_", " ").ToLower();
                        foreach (var itemx in item.Eligibility)
                        {
                            itemx.DiscountEligibilityType = itemx.DiscountEligibilityType.Replace("_", " ").ToLower();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            
            foreach (var items in productData.LendingRates)
            {
                items.LendingRateType = items.LendingRateType.Replace("_", " ").ToLower();
            }
            foreach (var items in productData.LendingRates)
            {
                items.LendingRateType = items.LendingRateType.Replace("_", " ").ToLower();
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
            productData.ProductCategory.Replace("_", " ").ToLower();
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
        }
        public async Task<ProductsResponseApi> StringReplaceProducts(ProductsResponseApi productData)
        {
            var adelaideBankReplace = new List<string>() { "AFG Home Loans Alpha", "Connective Home Loans Select", 
                "Aussie Elevate", "Tic:Toc", "Mezy Home Loans", "mortgageport", "Pepper Money", "MyBudget", 
                "Well Home Loans", "AMO", "Credabl", "Mortgage House", "emoney", "Finance Path", "Dreamstreet" };
            var response = productData.Data.Products;
            foreach (var items in response)
            {
                items.ProductCategory = items.ProductCategory.Replace("_", " ").ToLower();
                if (items.ProductCategory == "trans and savings accounts")
                {
                    items.ProductCategory = items.ProductCategory.Replace("trans and savings accounts", "transaction and savings accounts");
                }
                if (items.ProductCategory == "cred and chrg cards")
                {
                    items.ProductCategory = items.ProductCategory.Replace("cred and chrg cards", "credit and charge cards");
                }
                if (items.ProductCategory == "pers loans")
                {
                    items.ProductCategory = items.ProductCategory.Replace("pers loans", "personal loans");
                }
                if (items.Brand == "BT")
                {
                    items.Brand = items.Brand.Replace("BT", "Westpac");
                }
                if (items.Brand == "STL")
                {
                    items.Brand = items.Brand.Replace("STL", "BENDIGO");
                }
                foreach (var item in adelaideBankReplace)
                {
                    if (items.Brand == item)
                    {
                        items.Brand = items.Brand.Remove(0).Insert(0, "Adelaide Bank");
                    }
                }
                if (items.Brand == "Macquarie Bank Limited")
                {
                    items.Brand = items.Brand.Replace("Macquarie Bank Limited", "Macquarie Bank");
                }
            }

            return productData;
        }
    }
}
