using BookStore.Common.Exceptions;
using BookStore.Domain.Entities;
using FluentAssertions;
using Xunit;

namespace BookStore.Domain.Tests.Entities
{
    public class AuthorTests
    {
        private readonly string _firstName = "Jack";
        private readonly string _lastName = "London";

        [Fact]
        public void CreatedAuthorShouldHasFirstName()
        {
            var author = new Author(_firstName, _lastName);

            author.FirstName.Should().NotBeNullOrEmpty();
        }

        [Fact]
        public void CreatedAuthorShouldHasLastName()
        {
            var author = new Author(_firstName, _lastName);

            author.LastName.Should().NotBeNullOrEmpty();
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void ValidAuthorName_For_MissingFirstName_Throw_MissingFirstName(string firstName)
        {
            FluentActions.Invoking(() => new Author(firstName, _lastName))
                .Should()
                .Throw<MissingFirstName>();
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void ValidAuthorName_For_MissingLastName_Throw_MissingLastName(string lastName)
        {
            FluentActions.Invoking(() => new Author(_firstName, lastName))
                .Should()
                .Throw<MissingLastName>();
        }

        [Fact]
        public void ValidAuthoName_For_SameNames_Throw_SameNames()
        {
            FluentActions.Invoking(() => new Author(_firstName, _firstName))
                .Should()
                .Throw<SameNames>();
        }
    }
}
