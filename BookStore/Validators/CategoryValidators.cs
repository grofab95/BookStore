using BookStore.Common.Exceptions;

namespace BookStore.Validators
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
