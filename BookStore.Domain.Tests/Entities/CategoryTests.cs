using BookStore.Common.Exceptions;
using BookStore.Domain.Entities;
using FluentAssertions;
using Xunit;

namespace BookStore.Domain.Tests.Entities
{
    public class CategoryTests
    {
        [Fact]
        public void CreatedCategoryShouldHasName()
        {
            var category = new Category("Adventures");

            category.Name.Should().NotBeNull();
        }

        [Fact]
        public void ValidName_For_MissingName_Throw_EmptyName()
        {
            FluentActions.Invoking(() => new Category(""))
                .Should()
                .Throw<MissingName>();
        }
    }
}
