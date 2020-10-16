using BookStore.Common.Exceptions;
using BookStore.Domain.Entities;
using FluentAssertions;
using Xunit;

namespace BookStore.Domain.Tests.Entities
{
    public class PathTests
    {
        private readonly string _value = "localization/file.exe";
        private Path _path;

        public PathTests()
        {
            _path = new Path(_value);
        }

        [Fact]
        public void CreatedPathShouldHasValue()
        {
            _path.Value.Should().NotBeNullOrEmpty();
        }

        [Fact]
        public void ValidPath_For_FileExtension_Throw_MissingExtension()
        {
            var value = "location/imagepng";

            FluentActions.Invoking(() => new Path(value))
                .Should()
                .Throw<MissingExtension>();
        }

        [Fact]
        public void ValidPath_For_OnlyOneDot_Throw_InvalidExtension()
        {
            var value = "location.pictures/image.png";

            FluentActions.Invoking(() => new Path(value))
                .Should()
                .Throw<InvalidExtension>();
        }
    }
}
