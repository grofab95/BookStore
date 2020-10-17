using BookStore.Common.Exceptions;

namespace BookStore.Domain.Validators
{
    public class CategoryValidators
    {
        public static void ValidName(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new MissingName();
        }
    }
}
