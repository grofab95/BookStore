using BookStore.Common.Exceptions;
using BookStore.Domain.Entities;
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

            Assert.NotNull(author.FirstName);
        }

        [Fact]
        public void CreatedAuthorShouldHasLastName()
        {
            var author = new Author(_firstName, _lastName);

            Assert.NotNull(author.LastName);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void ValidAuthorName_For_MissingFirstName_Throw_MissingFirstName(string firstName)
        {
            Assert.Throws<MissingFirstName>(() => new Author(firstName, _lastName));
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void ValidAuthorName_For_MissingLastName_Throw_MissingLastName(string lastName)
        {
            Assert.Throws<MissingLastName>(() => new Author(_firstName, lastName));
        }

        [Fact]
        public void ValidAuthoName_For_SameNames_Throw_SameNames()
        {
            Assert.Throws<SameNames>(() => new Author(_firstName, _firstName));
        }
    }
}
