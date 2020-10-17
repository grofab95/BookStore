using BookStore.Common.Exceptions;
using BookStore.Common.Extensions;

namespace BookStore.Domain.Validators
{
    public class CategoryValidators
    {
        public static void ValidName(string name)
        {
            if (name.IsNotExist())
                throw new MissingName();
        }
    }
}
