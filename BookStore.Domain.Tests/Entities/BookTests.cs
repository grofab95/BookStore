using BookStore.Domain.Entities;
using BookStore.Exceptions;
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

        public BookTests()
        {
            var category = new Category(_categoryName);
            _book = new Book(_bookTitle, category);
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

        [Fact]
        public void ValidTitle_For_EmptyTitle_Throw_EmptyTitle()
        {
            Assert.Throws<EmptyTitle>(() => new Book("", null));
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
