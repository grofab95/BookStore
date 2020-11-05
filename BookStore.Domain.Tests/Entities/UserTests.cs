using BookStore.Common.Exceptions;
using BookStore.Domain.Entities;
using FluentAssertions;
using System;
using Xunit;

namespace BookStore.Domain.Tests.Entities
{
    public class UserTests
    {
        private User _user;
        private Address _address;

        public UserTests()
        {
            _address = new Address("Wrocław", "Oławska", "12-345", 50, 2);
            _user = new User("Fabian", "Grochla", "fabian.grochla@gmail.com", _address);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void ValidFirstName_For_MissingFirstName_Throw_MissingFirstName(string firstName)
        {
            FluentActions.Invoking(() => new User(firstName, "Grochla", "fabian.grochla@gmail.com", _address))
                .Should()
                .Throw<ArgumentException>();
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void ValidLastName_For_MissingLastName_Throw_MissingLastName(string lastName)
        {
            FluentActions.Invoking(() => new User("Fabian", lastName, "fabian.grochla@gmail.com", _address))
                .Should()
                .Throw<ArgumentException>();
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void ValidEmail_For_MissingEmail_Throw_MissingEmail(string email)
        {
            FluentActions.Invoking(() => new User("Fabian", "Grochla", email, _address))
                .Should()
                .Throw<ArgumentException>();
        }

        [Theory]
        [InlineData("addresswp.pl")]
        [InlineData("addresswppl")]
        [InlineData("address#?")]
        [InlineData("4574568")]
        [InlineData("address@@wp.pl")]
        public void ValidEmail_For_InvalidFormat_Throw_InvalidEmail(string email)
        {
            FluentActions.Invoking(() => new User("Fabian", "Grochla", email, _address))
                .Should()
                .Throw<InvalidEmail>();
        }

        [Fact]
        public void User_Should_HasAddress()
        {
            _user.Addresss.Should().NotBeNull();
        }

        [Fact]
        public void Name_Should_ReturnFirstNameAndLastName()
        {
            var expected = "Fabian Grochla";
            var actual = _user.Name;

            actual.Should().Be(expected);
        }

        [Fact]
        public void Email_Should_ReturnEmail()
        {
            var expected = "fabian.grochla@gmail.com";
            var actual = _user.Email;

            actual.Should().Be(expected);
        }
    }
}
