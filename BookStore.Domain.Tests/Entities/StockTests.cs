using BookStore.Domain.Entities;
using FluentAssertions;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BookStore.Common.Enums;
using BookStore.Common.Exceptions;

namespace BookStore.Domain.Tests.Entities
{
    public class StockTests
    {
        private Stock _stock;
        public StockTests()
        {
            _stock = new Stock(5);
        }

        [Fact]
        public void Stock_Should_HasVat()
        {
            var stock = new Stock(5);
            stock.Vat.Should().Be(5);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        public void Vat_For_NotPositive_Throw_InvalidVat(int vat)
        {
            FluentActions.Invoking(() => new Stock(vat))
                .Should()
                .Throw<InvalidVat>();
        }

        [Fact]
        public void When_Creating_Quantity_ShouldBe_0()
        {
            var stock = new Stock(23);
            stock.Quantity.Should().Be(0);
        }

        [Fact]
        public void When_Creating_WholesalePriceGross_ShouldBe_0()
        {
            var stock = new Stock(23);
            stock.WholesalePriceGross.Should().Be(0);
        }

        [Fact]
        public void When_Creating_RetailPriceGross_ShouldBe_0()
        {
            var stock = new Stock(23);
            stock.RetailPriceGross.Should().Be(0);
        }

        [Theory]
        [InlineData(-1, PriceType.RetailPrice)]
        [InlineData(0, PriceType.RetailPrice)]
        [InlineData(-1, PriceType.WholesalePrice)]
        [InlineData(0, PriceType.WholesalePrice)]
        public void SetPrice_For_NotPositivePrice_Throw_InvalidPrice(decimal price, PriceType priceType)
        {
            FluentActions.Invoking(() => _stock.SetPrice(price, priceType))
                .Should()
                .Throw<InvalidPrice>();
        }

        [Theory]
        [InlineData(98.58)]
        [InlineData(70)]
        public void SetPrice_Should_SetWholesalePrice(decimal price)
        {
            _stock.SetPrice(price, PriceType.WholesalePrice);

            _stock.WholesalePriceGross.Should().Be(price);
        }

        [Theory]
        [InlineData(98.58)]
        [InlineData(70)]
        public void SetPrice_Should_SetRetailPrice(decimal price)
        {
            _stock.SetPrice(price, PriceType.RetailPrice);

            _stock.RetailPriceGross.Should().Be(price);
        }
    }
}
