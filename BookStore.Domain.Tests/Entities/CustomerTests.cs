using BookStore.Domain.Entities;
using FluentAssertions;
using Xunit;

namespace BookStore.Domain.Tests.Entities
{
    public class CustomerTests
    {
        [Fact]
        public void Customer_Should_Created()
        {
            var address = new Address("Wrocław", "Oławska", "12-345", 50, 2);
            var customer = new Customer("Fabian", "Grochla", "fabian.grochla@gmail.com", address);

            customer.Should().NotBeNull();
        }
    }
}
