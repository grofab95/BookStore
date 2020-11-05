using BookStore.Common.Extensions;
using System;

namespace BookStore.Domain.Validators
{
    public class CategoryValidators
    {
        public static void ValidName(string name)
        {
            if (name.IsNotExist())
                throw new ArgumentException("Name is required.");
        }
    }
}
