using BookStore.Exceptions;

namespace BookStore.Validators
{
    public class BookValidator
    {
        public static void ValidTitle(string title)
        {
            if (string.IsNullOrEmpty(title))
                throw new EmptyTitle();
        }
    }
}
