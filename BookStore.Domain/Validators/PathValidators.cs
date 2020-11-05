using BookStore.Common.Exceptions;
using BookStore.Common.Extensions;
using System;
using System.Linq;

namespace BookStore.Domain.Validators
{
    public class PathValidators
    {
        public static void ValidPath(string path)
        {
            if (path.IsNotExist())
                throw new ArgumentException("Path is required.");

            if (!path.Any(c => c == '.'))
                throw new ArgumentException("Extension is required.");

            if (path.Where(c => c == '.').Count() != 1)
                throw new InvalidExtension();
        }
    }
}
