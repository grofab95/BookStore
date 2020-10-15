using BookStore.Common.Exceptions;

namespace BookStore.Validators
{
    public class BookValidators
    {
        public static void ValidTitle(string title)
        {
            if (string.IsNullOrEmpty(title))
                throw new MissingTitle();
        }
    }
}
