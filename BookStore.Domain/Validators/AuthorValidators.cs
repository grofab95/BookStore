using BookStore.Common.Exceptions;
using BookStore.Common.Extensions;
using System;

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
            if (firstName.IsNotExist())
                throw new ArgumentException("First name is required.");
        }

        public static void ValidLastName(string lastName)
        {
            if (lastName.IsNotExist())
                throw new ArgumentException("Last name is required.");
        }
    }
}
