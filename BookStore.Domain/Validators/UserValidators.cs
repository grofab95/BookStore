using BookStore.Common.Exceptions;
using BookStore.Common.Extensions;
using System.Text.RegularExpressions;

namespace BookStore.Domain.Validators
{
    public class UserValidators
    {
        public static void ValidFirstName(string firstName)
        {
            if (firstName.IsNotExist())
                throw new MissingFirstName();
        }

        public static void ValidLastName(string lastName)
        {
            if (lastName.IsNotExist())
                throw new MissingLastName();
        }

        public static void ValidEmail(string email)
        {
            if (email.IsNotExist())
                throw new MissingEmail();

            if (!Regex.IsMatch(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
                throw new InvalidEmail();
        }
    }
}
