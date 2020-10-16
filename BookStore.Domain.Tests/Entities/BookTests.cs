using BookStore.Common.Exceptions;
using BookStore.Domain.Entities;
using FluentAssertions;
using Xunit;

namespace BookStore.Domain.Tests.Entities
{
    public class BookTests
    {
        private readonly string _bookTitle = "Robinson Crusoe";
        private readonly string _categoryName = "Adventures";
        private readonly string _authorFirstName = "Jack";
        private readonly string _authorLastName = "London";

        private Book _book;
        private Category _category;

        public BookTests()
        {
            _category = new Category(_categoryName);
            _book = new Book(_bookTitle, _category);
        }

        [Fact]
        public void CreatedBookShouldHasTitle()
        {
            _book.Title.Should().NotBeNullOrEmpty();
        }

        [Fact]
        public void CreatedBookShouldHasCategory()
        {
            _book.Category.Should().NotBeNull();
        }

        [Fact]
        public void CreatedBookShouldHasNotNullAuthorsList()
        {
            _book.Authors.Should().NotBeNull();  
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void ValidTitle_For_MissingTitle_Throw_EmptyTitle(string title)
        {
            FluentActions.Invoking(() => new Book(title, _category))
                .Should()
                .Throw<MissingTitle>();
        }

        [Fact]
        public void AddAuthor_Expect_AddedAuthor()
        {
            var author = new Author(_authorFirstName, _authorLastName);

            _book.AddAuthor(author);

            _book.Authors.Should().Contain(author);
        }
    }
}
