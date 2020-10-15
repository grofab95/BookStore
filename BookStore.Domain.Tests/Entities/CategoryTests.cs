using BookStore.Common.Exceptions;
using BookStore.Domain.Entities;
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
        public void ValidName_For_MissingName_Throw_EmptyName()
        {
            Assert.Throws<MissingName>(() => new Category(""));
        }
    }
}
