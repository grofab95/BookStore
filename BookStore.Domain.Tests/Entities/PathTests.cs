﻿using BookStore.Common.Exceptions;
using BookStore.Domain.Entities;
using FluentAssertions;
using System;
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

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void ValidPath_For_MissingPath_Throw_MissingPath(string value)
        {
            FluentActions.Invoking(() => new Path(value))
                .Should()
                .Throw<ArgumentException>();
        }

        [Fact]
        public void ValidPath_For_FileExtension_Throw_MissingExtension()
        {
            var value = "location/imagepng";

            FluentActions.Invoking(() => new Path(value))
                .Should()
                .Throw<ArgumentException>();
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
