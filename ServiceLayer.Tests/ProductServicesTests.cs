using ApiClients.ProductsApiClient;
using AutoMapper;
using Domain.Entities.Product;
using Domain.Entities.Products;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using NSubstitute.ReturnsExtensions;
using ServiceLayer.DetailsService;
using ServiceLayer.DTOS.Product;
using ServiceLayer.DTOS.Products;
using ServiceLayer.UnitTests.MockData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.UnitTests
{
    public class ProductServicesTests
    {
        private ProductServices _sut;
        private readonly IMapper _mapper;
        private readonly IProductsExternalCall _productsExternalCall;
        private readonly IProductsPassThrough _productsPassThrough;

        public ProductServicesTests()
        {
            _mapper = Substitute.For<IMapper>();
            _productsPassThrough = Substitute.For<IProductsPassThrough>();
            _productsExternalCall = Substitute.For<IProductsExternalCall>();
            _sut = new ProductServices(_mapper, _productsExternalCall, _productsPassThrough);
        }

        [Fact]
        public async Task Should_RecieveApiResponse_PassToDBToSave_SaveProductAsync()
        {
            //Arrange
            var productResponseApiSl = MockDtoDataSl.productResponseApiSl();
            var productResponseApi = MockDtoData.productResponseApi();
            var productResponseApiAc = MockDtoDataAc.productResponseApiAc();

            var productId = "ProductId1";
            var bank = "Bank";

            _productsExternalCall.GetProductExternal(productId, bank).Returns(productResponseApiAc);
            _mapper.Map<ProductResponseApiSl>(productResponseApiAc).Returns(productResponseApiSl);
            _mapper.Map<ProductResponseApi>(productResponseApiSl).Returns(productResponseApi);
            await _productsPassThrough.SaveProductPassThrough(productResponseApi.Data);
            //Act
            var result = _sut.SaveProductAsync(productId, bank);
            //Assert
            result.Should().ReturnsNull();
            await _productsExternalCall.Received().GetProductExternal(productId, bank);
        }

        [Fact]
        public async Task Should_RecieveApiResponse_PassToDbToSave_ReturnListUpdatedProducts_SaveProductsExternalCall()
        {
            //Arrange
            var productsResponseApi = MockDtoData.listProducts();
            var productsResponseApiSl = MockDtoDataSl.listProductsSl();
            var productsResponseApiAc = MockDtoDataAc.listProductsAc();

            var bank = "Bank";
            var listOfProductIds = new List<string>()
            {
                "ProductId1",
                "ProductId2"
            };

            _productsExternalCall.GetProductsExternal(bank).Returns(productsResponseApiAc);
            _mapper.Map<ProductsResponseApiSl>(productsResponseApiAc).Returns(productsResponseApiSl);
            _mapper.Map<ProductsResponseApi>(productsResponseApiSl).Returns(productsResponseApi);
            _productsPassThrough.SaveProductsPassThrough(productsResponseApi).Returns(listOfProductIds);

            //Act
            var result = await _sut.SaveProductsExternalCall(bank);
            //Assert
            result.Should().NotBeNull();
            result.Should().BeEquivalentTo(listOfProductIds);
        }

        [Fact]
        public async Task Should_ReturnProductDetails_GetProductDetails()
        {
            //Arrange
            var productDataSl = MockDtoDataSl.productDataSl();
            var productData = MockDtoData.productData();

            var productId = "ProductId1";

            _productsPassThrough.GetProductDetailsPassThrough(productId).Returns(productData);
            _mapper.Map<ProductDataSl>(productData).Returns(productDataSl);

            //Act
            var result = await _sut.GetProductDetails(productId);
            //Assert
            result.Should().NotBeNull();
            result.Should().BeOfType<ProductDataSl>();
        }
        [Fact]
        public async Task Should_ReturnAllProducts_GetAllProducts()
        {
            //Arrange
            var products = MockDtoData.getListProducts();
            var productsSl = MockDtoDataSl.getListProductsSl();

            _productsPassThrough.GetAllProductsPassThrough().Returns(products);
            _mapper.Map<List<ProductsSl>>(products).Returns(productsSl);
            //Act
            var result = await _sut.GetAllProducts();
            //Assert
            result.Should().NotBeNull();
            result.Should().BeOfType<List<ProductsSl>>();
        }
    }
}
