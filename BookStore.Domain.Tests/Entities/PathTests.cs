using BookStore.Common.Exceptions;
using BookStore.Domain.Entities;
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
            Assert.NotNull(_path.Value);
        }

        [Fact]
        public void ValidPath_For_FileExtension_Throw_MissingExtension()
        {
            var path = "location/imagepng";

            Assert.Throws<MissingExtension>(() => new Path(path));
        }

        [Fact]
        public void ValidPath_For_OnlyOneDot_Throw_InvalidExtension()
        {
            var path = "location.pictures/image.png";

            Assert.Throws<InvalidExtension>(() => new Path(path));
        }
    }
}
