using BookStore.Common.Exceptions;
using BookStore.Domain.Entities;
using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace BookStore.Domain.Tests.Entities
{
    public class BookTests
    {
        private readonly string _bookTitle = "Robinson Crusoe";

        private Category _category;
        private List<Author> _authors;
        private Book _book;

        public BookTests()
        {
            _category = new Category("Adventures");
            _authors = new List<Author> 
            {
                new Author("Jack", "London")
            };

            _book = new Book(_bookTitle, _category, _authors);           
        }

        [Fact]
        public void CreatedBook_Should_HasTitle()
        {
            _book.Title.Should().NotBeNullOrEmpty();
        }

        [Fact]
        public void CreatedBook_Should_HasCategory()
        {
            _book.Category.Should().NotBeNull();
        }

        [Fact]
        public void CreatedBook_Should_HasAuthors()
        {
            _book.Authors.Should()
                .NotBeNull()
                .And
                .NotBeEmpty();  
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void ValidTitle_For_MissingTitle_Throw_MissingTitle(string title)
        {
            FluentActions.Invoking(() => new Book(title, _category, _authors))
                .Should()
                .Throw<MissingTitle>();
        }

        [Fact]
        public void ValidAuthors_For_MissingAuthors_Throw_MissingAuthors()
        {
            FluentActions.Invoking(() => new Book(_bookTitle, _category, null))
                .Should()
                .Throw<MissingAuthors>();
        }

        [Fact]
        public void ValidAuthors_For_EmptyAuthorsList_Throw_MissingAuthors()
        {
            var authors = new List<Author>();
            FluentActions.Invoking(() => new Book(_bookTitle, _category, authors))
                .Should()
                .Throw<MissingAuthors>();
        }
    }
}
