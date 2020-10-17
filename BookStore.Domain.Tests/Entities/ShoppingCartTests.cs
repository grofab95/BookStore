using BookStore.Domain.Entities;
using FluentAssertions;
using Xunit;

namespace BookStore.Domain.Tests.Entities
{
    public class ShoppingCartTests
    {
        private ShoppingCart<Book> _cart;

        public ShoppingCartTests()
        {
            var address = new Address("Wrocław", "Oławska", "12-345", 50, 2);
            var customer = new Customer("Fabian", "Grochla", "fabian.grochla@gmail.com", address);

            _cart = new ShoppingCart<Book>(customer);
        }

        [Fact]
        public void ShoppingCart_Should_Has_Customer()
        {
            _cart.Customer.Should().NotBeNull();
        }

        // methods: AddPosition, RemovePosition, SetPositionQuantity, GetCartQuantity, GetCartTotalPrice
    }
}
