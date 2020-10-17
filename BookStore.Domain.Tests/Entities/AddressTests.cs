using BookStore.Common.Exceptions;
using BookStore.Domain.Entities;
using FluentAssertions;
using Xunit;

namespace BookStore.Domain.Tests.Entities
{
    public class AddressTests
    {
        private Address _address;

        public AddressTests()
        {
            _address = new Address("Opole", "Prószkowska", "45-758", 76);
        }

        [Fact]
        public void Address_Should_HasCity()
        {
            _address.City.Should().NotBeNullOrEmpty();
        }

        [Fact]
        public void Address_Should_HasStreet()
        {
            _address.Street.Should().NotBeNullOrEmpty();
        }

        [Fact]
        public void Address_Should_HasHomeNumber()
        {
            _address.HomeNumber.Should().BePositive();
        }

        [Fact]
        public void Address_Should_PostCode()
        {
            _address.PostCode.Should().NotBeNullOrEmpty();
        }

        [Fact]
        public void ValidCity_For_MissingCity_Throw_MissingCity()
        {
            FluentActions.Invoking(() => new Address(null, "Prószkowska", "45-758", 76))
                .Should()
                .Throw<MissingCity>();
        }

        [Fact]
        public void ValidStreet_For_MissingStreet_Throw_MissingStreet()
        {
            FluentActions.Invoking(() => new Address("Opole", null, "45-758", 76))
                .Should()
                .Throw<MissingStreet>();
        }
        
        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        public void ValidHomeNumber_For_NotPositiveNumber_Throw_NotPositiveHomeNumber(int homeNumber)
        {
            FluentActions.Invoking(() => new Address("Opole", "Prószkowska", "45-758", homeNumber))
                .Should()
                .Throw<NotPositiveHomeNumber>();
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        public void ValidFlatNumber_For_NotPositiveNumber_Throw_NotPositiveFlatNumber(int flatNumber)
        {
            FluentActions.Invoking(() => new Address("Opole", "Prószkowska", "45-758", 1, flatNumber))
                .Should()
                .Throw<NotPositiveFlatNumber>();
        }

        [Fact]
        public void ValidStreet_For_MissingPostCode_Throw_MissingPostCode()
        {
            FluentActions.Invoking(() => new Address("Opole", "Prószkowska", null, 76))
                .Should()
                .Throw<MissingPostcode>();
        }

        [Theory]
        [InlineData("45758")]
        [InlineData("xx-yyy")]
        [InlineData("#$%")]
        public void ValidPostCode_For_InvalidPostcode_Throw_InvalidPostcode(string postCode)
        {
            FluentActions.Invoking(() => new Address("Opole", "Prószkowska", postCode, 76))
                .Should()
                .Throw<InvalidPostcode>();
        }

        [Fact]
        public void GetAddress_For_ReturnAddressInfo()
        {
            var expected = "45-758 Opole, ul. Prószkowska 76";
            var actual = _address.GetAddress();

            Assert.Equal(expected, actual);

            actual.Should().Be(expected);
        }

        [Fact]
        public void GetAddress_For_ReturnAddressInfoWithFlatNumber()
        {
            var address = new Address("Opole", "Prószkowska", "45-758", 76, 1);

            var expected = "45-758 Opole, ul. Prószkowska 76/1";
            var actual = address.GetAddress();

            Assert.Equal(expected, actual);

            actual.Should().Be(expected);
        }

    }
}
