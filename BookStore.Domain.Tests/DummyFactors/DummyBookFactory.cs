using BookStore.Domain.Entities;
using FakeItEasy;
using System;

namespace BookStore.Domain.Tests.DummyFactors
{
    public class DummyBookFactory : IDummyFactory
    {
        public Priority Priority => Priority.Default;

        public bool CanCreate(Type type)
        {
            return true;
        }

        public object Create(Type type)
        {
            var category = new Category("Adventures");
            return new Book("Robinson Crusoe", category);
        }
    }
}
