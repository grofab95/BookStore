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
            _address = new Address("Opole", "Prószkowska", "45-758", 76);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void ValidCity_For_MissingCity_Throw_MissingCity(string city)
        {
            FluentActions.Invoking(() => new Address(city, "Prószkowska", "45-758", 76))
                .Should()
                .Throw<ArgumentException>();
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void ValidStreet_For_MissingStreet_Throw_MissingStreet(string street)
        {
            FluentActions.Invoking(() => new Address("Opole", street, "45-758", 76))
                .Should()
                .Throw<ArgumentException>();
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
                .Throw<ArgumentException>();
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
        public void GetAddress_Should_ReturnAddressInfo()
        {
            var expected = "45-758 Opole, ul. Prószkowska 76";
            var actual = _address.GetAddress();

            actual.Should().Be(expected);
        }

        [Fact]
        public void GetAddress_Should_ReturnAddressInfoWithFlatNumber()
        {
            var address = new Address("Opole", "Prószkowska", "45-758", 76, 1);

            var expected = "45-758 Opole, ul. Prószkowska 76/1";
            var actual = address.GetAddress();

            actual.Should().Be(expected);
        }
    }
}
