﻿using BookStore.Validators;

namespace BookStore.Domain.Entities
{
    public class Author : EntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Author(string firstName, string lastName)
        {
            AuthorValidator.ValidFirstName(firstName);
            AuthorValidator.ValidLastName(lastName);

            FirstName = firstName;
            LastName = lastName;
        }
    }
}