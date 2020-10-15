using BookStore.Exceptions;

namespace BookStore.Validators
{
    public class CategoryValidator
    {
        public static void ValidName(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new EmptyName();
        }
    }
}
