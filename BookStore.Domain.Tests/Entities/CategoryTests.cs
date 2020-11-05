using BookStore.Domain.Entities;
using FluentAssertions;
using System;
using Xunit;

namespace BookStore.Domain.Tests.Entities
{
    public class CategoryTests
    {
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void ValidName_For_MissingName_Throw_EmptyName(string name)
        {
            FluentActions.Invoking(() => new Category(name))
                .Should()
                .Throw<ArgumentException>();
        }

        [Fact]
        public void Name_Should_ReturnFirstNameAndLastName()
        {
            var category = new Category("Adventures");
            var expected = "Adventures";
            var actual = category.Name;

            actual.Should().Be(expected);
        }
    }
}
