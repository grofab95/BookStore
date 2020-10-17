using BookStore.Common.Exceptions;

namespace BookStore.Domain.Validators
{
    public class AuthorValidators
    {
        public static void ValidAuthorName(string firstName, string lastName)
        {
            ValidFirstName(firstName);
            ValidLastName(lastName);

            if (firstName.ToLower().Trim() == lastName.ToLower().Trim())
                throw new SameNames();
        }

        public static void ValidFirstName(string firstName)
        {
            if (string.IsNullOrEmpty(firstName))
                throw new MissingFirstName();
        }

        public static void ValidLastName(string lastName)
        {
            if (string.IsNullOrEmpty(lastName))
                throw new MissingLastName();
        }
    }
}
