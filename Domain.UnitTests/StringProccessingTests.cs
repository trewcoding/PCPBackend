using Domain.Entities.Product;
using Domain.Entities.Products;
using Domain.Services;
using Domain.UnitTests.MockData;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Domain.UnitTests
{ 

    public class StringProccessingTests
    {
        private StringProcessing _sut;

        public StringProccessingTests()
        {
            _sut = new StringProcessing();
        }

        [Theory]
        [MemberData(nameof(MockDtoDataProducts.ProductsTestCases), MemberType = typeof(MockDtoDataProducts))]
        public async Task Should_ReplaceStringsWhereConditionsMet_StringReplaceProducts(ProductsResponseApi first, ProductsResponseApi second)
        {
            var result = await _sut.StringReplaceProducts(first);
            result.Should().BeEquivalentTo(second, options => options
            .ComparingRecordsByValue()
            .ComparingByMembers<ProductsResponseApi>());
        }

        [Theory]
        [MemberData(nameof(MockDtoDataProduct.ProductTestCases), MemberType = typeof(MockDtoDataProduct))]
        public async Task Should_ReplaceStringsWhereConditionsMet_StringReplaceProduct(ProductData first, ProductData second)
        {
            var result = await _sut.StringReplaceProduct(first);
            result.Should().BeEquivalentTo(second, options => options
            .ComparingRecordsByValue()
            .ComparingByMembers<ProductData>());
        }

    }
}
