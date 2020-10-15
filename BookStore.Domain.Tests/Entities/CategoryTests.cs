using BookStore.Domain.Entities;
using BookStore.Exceptions;
using Xunit;

namespace BookStore.Domain.Tests.Entities
{
    public class CategoryTests
    {
        [Fact]
        public void CreatedCategoryShouldHasName()
        {
            var category = new Category("Adventures");

            Assert.NotNull(category.Name);
        }

        [Fact]
        public void ValidName_For_EmptyName_Throw_EmptyName()
        {
            Assert.Throws<EmptyName>(() => new Category(""));
        }
    }
}
