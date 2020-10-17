using BookStore.Common.Exceptions;
using BookStore.Common.Extensions;
using System.Linq;

namespace BookStore.Domain.Validators
{
    public class PathValidators
    {
        public static void ValidPath(string path)
        {
            if (path.IsNotExist())
                throw new MissingPath();

            if (!path.Any(c => c == '.'))
                throw new MissingExtension();

            if (path.Where(c => c == '.').Count() != 1)
                throw new InvalidExtension();
        }
    }
}
