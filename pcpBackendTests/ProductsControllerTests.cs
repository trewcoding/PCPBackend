using API.Controllers;
using API.DTOS.Product;
using API.DTOS.Products;
using API.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using NSubstitute.ReturnsExtensions;
using ServiceLayer.DetailsService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.unitTests
{
    public class ProductsControllerTests
    {
        private ProductsController _sut;
        private readonly IMediator _mediator;
        private readonly IProductService _productService;
        public ProductsControllerTests()
        {
            _productService = Substitute.For<IProductService>();
            _mediator = Substitute.For<IMediator>();
            _sut = new ProductsController(_mediator, _productService);
        }

        [Fact]
        public async Task GetProductsCall_Should_return_OKStatus()
        {
            //Arrange
            List<string> returnedProducts = new List<string>
            {
                "productId1",
                "productId2"
            };

            _productService.SaveProductsExternalCall(Arg.Any<string>()).Returns(returnedProducts);
            _productService.SaveProductAsync(Arg.Any<string>(), Arg.Any<string>()).Returns(Task.CompletedTask);
            //Act
            var result = (OkObjectResult)await _sut.GetProductsCall();
            //Assert
            result.StatusCode.Should().Be(200);
            result.Should().NotBeNull();
        }

        [Fact]
        public async Task GetAllProducts_Should_Return_OkStatus()
        {
            //Arrange
            //Act
            var result = (OkObjectResult)await _sut.GetAllProducts();
            //Assert
            result.StatusCode.Should().Be(200);
            result.Should().NotBeNull();

        }

        [Fact]
        public async Task GetProduct_Should_Return_OkStatus()
        {
            //Arrange
            string productId = new string("ProductId1");
            //Act
            var result = (OkObjectResult)await _sut.GetProduct(productId);
            //Assert
            result.StatusCode.Should().Be(200);
            result.Should().NotBeNull();

        }

        //[Fact]
        //public async Task Practice()
        //{
        //    //Arrange
        //    ProductsApi products = new ProductsApi
        //    {
        //        ProductId = "ManarCanCode",
        //    };
        //    ProductsResponseApiApi results = new ProductsResponseApiApi()
        //    {
        //        Data = new DataApi
        //        {
        //            Products = new List<ProductsApi>()
        //            { products },
        //        }            
        //    };
        //    //Act

        //    //Assert
        //}


        //Arrange

        //Act

        //Assert
    }
}
