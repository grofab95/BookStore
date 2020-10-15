using BookStore.Exceptions;

namespace BookStore.Validators
{
    public class AuthorValidator
    {
        public static void ValidFirstName(string firstName)
        {
            if (string.IsNullOrEmpty(firstName))
            {
                throw new EmptyFirstName();
            }
        }

        public static void ValidLastName(string lastName)
        {
            if (string.IsNullOrEmpty(lastName))
            {
                throw new EmptyLastName();
            }
        }
    }
}
