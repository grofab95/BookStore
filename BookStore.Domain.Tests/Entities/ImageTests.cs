using BookStore.Common.Exceptions;
using BookStore.Domain.Entities;
using FluentAssertions;
using Xunit;

namespace BookStore.Domain.Tests.Entities
{
    public class ImageTests
    {
        private readonly string _imagePath = "location/image.PNG";
        private Image _image;

        public ImageTests()
        {
            var path = new Path(_imagePath);
            _image = new Image(path);
        }

        [Fact]
        public void CreatedImage_Should_HasPath()
        {
            _image.Path.Should().NotBeNullOrEmpty();
        }

        [Theory]
        [InlineData("png")]
        [InlineData("aVi")]
        [InlineData("mp3")]
        [InlineData("rar")]
        [InlineData("zip")]
        public void ValidPath_For_FileExtension_Throw_InvalidImageExtension(string imageExtension)
        {
            var path = new Path($"location/image.{imageExtension}");

            FluentActions.Invoking(() => new Image(path))
                .Should()
                .Throw<InvalidImageExtension>();
        }
    }
}
