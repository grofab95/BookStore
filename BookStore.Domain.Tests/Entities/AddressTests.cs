using BookStore.Common.Exceptions;
using BookStore.Domain.Entities;
using FluentAssertions;
using System;
using Xunit;

namespace BookStore.Domain.Tests.Entities
{
    public class AddressTests
    {
        private Address _address;

        public AddressTests()
        {
            _address = new Address("Opole", "Prószkowska", "47-143", 13);
        }

        [Fact]
        public void CreatedAddressShouldHasCity()
        {
            _address.City.Should().NotBeNullOrEmpty();
        }

        [Fact]
        public void CreatedAddressShouldHasStreet()
        {
            _address.Street.Should().NotBeNullOrEmpty();
        }

        [Fact]
        public void CreatedAddressShouldHasHomeNumber()
        {
            _address.HomeNumber.Should().BePositive();
        }

        [Fact]
        public void CreatedAddressShouldPostCode()
        {
            _address.PostCode.Should().NotBeNullOrEmpty();
        }

        [Fact]
        public void ValidCity_For_MissingCity_Throw_MissingCity()
        {
            FluentActions.Invoking(() => new Address(null, "Prószkowska", "47-143", 13))
                .Should()
                .Throw<MissingCity>();
        }

        [Fact]
        public void ValidStreet_For_MissingStreet_Throw_MissingStreet()
        {
            FluentActions.Invoking(() => new Address("Opole", null, "47-143", 13))
                .Should()
                .Throw<MissingStreet>();
        }
        
        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        public void ValidHomeNumber_For_NotPositiveNumber_Throw_NotPositiveHomeNumber(int homeNumber)
        {
            FluentActions.Invoking(() => new Address("Opole", "Prószkowska", "47-143", homeNumber))
                .Should()
                .Throw<NotPositiveHomeNumber>();
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        public void ValidFlatNumber_For_NotPositiveNumber_Throw_NotPositiveFlatNumber(int flatNumber)
        {
            FluentActions.Invoking(() => new Address("Opole", "Prószkowska", "47-143", 1, flatNumber))
                .Should()
                .Throw<NotPositiveFlatNumber>();
        }

        [Fact]
        public void ValidStreet_For_MissingPostCode_Throw_MissingPostCode()
        {
            FluentActions.Invoking(() => new Address("Opole", "Prószkowska", null, 13))
                .Should()
                .Throw<MissingPostcode>();
        }

        [Theory]
        [InlineData("47143")]
        [InlineData("xx-yyy")]
        [InlineData("#$%")]
        public void ValidPostCode_For_InvalidPostcode_Throw_InvalidPostcode(string postCode)
        {
            FluentActions.Invoking(() => new Address("Opole", "Prószkowska", postCode, 13))
                .Should()
                .Throw<InvalidPostcode>();
        }
    }
}
