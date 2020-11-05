using BookStore.Common.Exceptions;
using BookStore.Domain.Entities;
using FluentAssertions;
using System;
using Xunit;

namespace BookStore.Domain.Tests.Entities
{
    public class AuthorTests
    {
        private readonly string _firstName = "Jack";
        private readonly string _lastName = "London";

        private Author _author;

        public AuthorTests()
        {
            _author = new Author(_firstName, _lastName);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void ValidAuthorName_For_MissingFirstName_Throw_MissingFirstName(string firstName)
        {
            FluentActions.Invoking(() => new Author(firstName, _lastName))
                .Should()
                .Throw<ArgumentException>();
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void ValidAuthorName_For_MissingLastName_Throw_MissingLastName(string lastName)
        {
            FluentActions.Invoking(() => new Author(_firstName, lastName))
                .Should()
                .Throw<ArgumentException>();
        }

        [Fact]
        public void ValidAuthorName_For_SameNames_Throw_SameNames()
        {
            FluentActions.Invoking(() => new Author(_firstName, _firstName))
                .Should()
                .Throw<SameNames>();
        }

        [Fact]
        public void FirstName_Should_ReturnFirstName()
        {
            var expected = _firstName;
            var actual = _author.FirstName;

            actual.Should().Be(expected);
        }

        [Fact]
        public void LastName_Should_ReturnLastName()
        {
            var expected = _lastName;
            var actual = _author.LastName;

            actual.Should().Be(expected);
        }
    }
}
