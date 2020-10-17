﻿using BookStore.Common.Exceptions;
using BookStore.Common.Extensions;

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
                throw new MissingFirstName();
        }

        public static void ValidLastName(string lastName)
        {
            if (lastName.IsNotExist())
                throw new MissingLastName();
        }
    }
}
