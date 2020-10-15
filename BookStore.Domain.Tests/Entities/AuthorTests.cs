using BookStore.Domain.Entities;
using BookStore.Exceptions;
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

        [Fact]
        public void ValidAuthor_For_EmptyFirstName_Throw_EmptyFirstName()
        {
            Assert.Throws<EmptyFirstName>(() => new Author("", _lastName));
        }

        [Fact]
        public void ValidAuthor_For_EmptyLastName_Throw_EmptyLastName()
        {
            Assert.Throws<EmptyLastName>(() => new Author(_firstName, ""));
        }
    }
}
