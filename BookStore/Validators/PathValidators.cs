using BookStore.Common.Exceptions;
using System.Linq;

namespace BookStore.Common.Validators
{
    public class PathValidators
    {
        public static void ValidPath(string extension)
        {
            if (!extension.Any(c => c == '.'))
                throw new MissingExtension();

            if (extension.Where(c => c == '.').Count() != 1)
                throw new InvalidExtension();
        }
    }
}
