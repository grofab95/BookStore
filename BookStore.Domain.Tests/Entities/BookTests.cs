using BookStore.Common.Exceptions;
using BookStore.Domain.Entities;
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
            Assert.NotNull(_book.Title);
        }

        [Fact]
        public void CreatedBookShouldHasCategory()
        {
            Assert.NotNull(_book.Category);
        }


        [Fact]
        public void CreatedBookShouldHasNotNullAuthorsList()
        {
            Assert.NotNull(_book.Authors); 
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void ValidTitle_For_MissingTitle_Throw_EmptyTitle(string title)
        {
            Assert.Throws<MissingTitle>(() => new Book(title, _category));
        }

        [Fact]
        public void AddAuthor_Expect_AddedAuthor()
        {
            var author = new Author(_authorFirstName, _authorLastName);

            _book.AddAuthor(author);

            Assert.Contains(author, _book.Authors);
        }
    }
}
