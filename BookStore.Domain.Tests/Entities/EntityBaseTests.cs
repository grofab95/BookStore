using BookStore.Domain.Entities;
using FluentAssertions;
using System;
using Xunit;

namespace BookStore.Domain.Tests.Entities
{
    public class EntityBaseTests
    {
        private readonly DateTime _createdAt = new DateTime(2020, 07, 26, 15, 30, 00);
        private readonly DateTime _updatedAt = new DateTime(2020, 10, 3, 12, 00, 00);

        private Path _path;

        public EntityBaseTests()
        {
            _path = new Path("localization/app.exe");
            _path.Id = 1;
            _path.CreatedAt = _createdAt;
            _path.UpdatedAt = _updatedAt;
        }

        [Fact]
        public void Id_Should_ReturnID()
        {
            var expected = 1;
            var actual = _path.Id;

            actual.Should().Be(expected);
        }

        [Fact]
        public void CreatedAt_Should_ReturnCreateDate()
        {
            var expected = _createdAt;
            var actual = _path.CreatedAt;

            actual.Should().Be(expected);
        }

        [Fact]
        public void UpdatedAt_Should_ReturnUpdateDate()
        {
            var expected = _updatedAt;
            var actual = _path.UpdatedAt;

            actual.Should().Be(expected);
        }
    }
}
