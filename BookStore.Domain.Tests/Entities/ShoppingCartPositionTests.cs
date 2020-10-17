using BookStore.Common.Exceptions;
using BookStore.Domain.Entities;
using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace BookStore.Domain.Tests.Entities
{
    public class ShoppingCartPositionTests
    {
        private Book _book;
        private ShoppingCartPosition<Book> _shoppingCartPosition;

        public ShoppingCartPositionTests()
        {
            var category = new Category("Adventures");
            var authors = new List<Author>
            {
                new Author("Jack", "London")
            };

            _book = new Book("Robinson Crusoe", category, 20, authors);
            _book.Stock.SetQuantity(10);
            _shoppingCartPosition = new ShoppingCartPosition<Book>(_book, 1);
        }


        [Fact]
        public void ShoppingCartPosition_Should_HasPosition()
        {
            var shoppingCartPosition = new ShoppingCartPosition<Book>(_book, 3);

            shoppingCartPosition.Position.Should().NotBeNull();
        }

        [Fact]
        public void ShoppingCartPosition_Should_HasQuantity()
        {
            var shoppingCartPosition = new ShoppingCartPosition<Book>(_book, 3);

            shoppingCartPosition.Quantity.Should().NotBe(0);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        public void Quantity_For_Negative_Throw_NegativeQuantity(int value)
        {
            FluentActions.Invoking(() => new ShoppingCartPosition<Book>(_book, value))
                .Should()
                .Throw<NegativeQuantity>();
        }

        [Theory]
        [InlineData(4)]
        [InlineData(8)]
        public void AddQuantity_Should_IncreaseQuantity(int value)
        {
            _shoppingCartPosition.AddQuantity(value);
            var expected = _shoppingCartPosition.Quantity += value;

            _shoppingCartPosition.Quantity.Should().Be(expected);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        public void AddQuantity_For_Negative_Throw_NegativeQuantity(int value)
        {
            FluentActions.Invoking(() => _shoppingCartPosition.AddQuantity(value))
                .Should()
                .Throw<NegativeQuantity>();
        }

        [Fact]
        public void AddQuantity_For_NotEnoughQuantity_Throw_NotEnoughQuantity()
        {
            _book.Stock.SetQuantity(5);

            FluentActions.Invoking(() => _shoppingCartPosition.AddQuantity(6))
                .Should()
                .Throw<NotEnoughQuantity>();
        }

        [Theory]
        [InlineData(4)]
        [InlineData(8)]
        public void SubtractQuantity_Should_DecreaseQuantity(int value)
        {
            var shoppingCartPosition = new ShoppingCartPosition<Book>(_book, 10);

            shoppingCartPosition.SubtractQuantity(value);
            var expected = shoppingCartPosition.Quantity -= value;

            shoppingCartPosition.Quantity.Should().Be(expected);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        public void SubtractQuantity_For_Negative_Throw_NegativeQuantity(int value)
        {
            FluentActions.Invoking(() => _shoppingCartPosition.SubtractQuantity(value))
                .Should()
                .Throw<NegativeQuantity>();
        }

        [Fact]
        public void SubtractQuantity_For_ToManyDecrease_Throw_MissingQuantityToDecrease()
        {
            var quantityToDecrease = _shoppingCartPosition.Quantity + 2;

            FluentActions.Invoking(() => _shoppingCartPosition.SubtractQuantity(quantityToDecrease))
                .Should()
                .Throw<MissingQuantityToDecrease>();
        }
    }
}
