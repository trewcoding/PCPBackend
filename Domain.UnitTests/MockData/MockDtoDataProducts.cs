using Domain.Entities.Product;
using Domain.Entities.Products;

namespace Domain.UnitTests.MockData
{
    public static class MockDtoDataProducts
    {
        public static ProductsResponseApi listProducts()
        {
            Products products = new Products
            {
                ProductId = "ProductId1",
                LastUpdated = DateTime.Today,
                Name = "NameOfProduct",
                Brand = "BrandOfProduct",
                BrandName = "BrandNameOfProduct",
                ProductCategory = "product",
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
                ProductCategory = "product",
            };
            List<Products> productsList = new List<Products>() { products };
            return productsList;
        }

        public static ProductsResponseApi listProductsEmpty(Products products)
        {
            ProductsResponseApi productsResponseApi = new ProductsResponseApi
            {
                Data = new Data()
                {
                    Products = new List<Products>() { products }
                }
            };
            return productsResponseApi;
        }

        public static IEnumerable<object[]> ProductsTestCases =>
        new List<object[]>
        {
            new object[] { listProductsEmpty(new Products() {ProductCategory = "Trans_and_Savings_Accounts", ProductId="ProductId" })
                , listProductsEmpty(new Products() { ProductCategory = "transaction and savings accounts", ProductId="ProductId" })},

            new object[] { listProductsEmpty(new Products() {ProductCategory = "cred_And chrg cards", ProductId="ProductId" })
                , listProductsEmpty(new Products() { ProductCategory = "credit and charge cards", ProductId="ProductId" })},

            new object[] { listProductsEmpty(new Products() {ProductCategory = "pers_LOAns", ProductId="ProductId" })
                , listProductsEmpty(new Products() { ProductCategory = "personal loans", ProductId="ProductId" })},

            new object[] { listProductsEmpty(new Products() { Brand = "BT", ProductCategory = "Trans_and_Savings_Accounts", ProductId="ProductId" })
                , listProductsEmpty(new Products() { Brand = "Westpac", ProductCategory = "transaction and savings accounts", ProductId="ProductId" })},

            new object[] { listProductsEmpty(new Products() { Brand = "STL", ProductCategory = "Trans_and_Savings_Accounts", ProductId="ProductId" })
                , listProductsEmpty(new Products() { Brand = "BENDIGO", ProductCategory = "transaction and savings accounts", ProductId="ProductId" })},

            new object[] { listProductsEmpty(new Products() { Brand = "MyBudget", ProductCategory = "Trans_and_Savings_Accounts", ProductId="ProductId" })
                , listProductsEmpty(new Products() { Brand = "Adelaide Bank", ProductCategory = "transaction and savings accounts", ProductId="ProductId" })},

            new object[] { listProductsEmpty(new Products() { Brand = "Connective Home Loans Select", ProductCategory = "Trans_and_Savings_Accounts", ProductId="ProductId" })
                , listProductsEmpty(new Products() { Brand = "Adelaide Bank", ProductCategory = "transaction and savings accounts", ProductId="ProductId" })},

            new object[] { listProductsEmpty(new Products() { Brand = "Macquarie Bank Limited", ProductCategory = "Trans_and_Savings_Accounts", ProductId="ProductId" })
                , listProductsEmpty(new Products() { Brand = "Macquarie Bank", ProductCategory = "transaction and savings accounts", ProductId="ProductId" })},

        };
    }
}


