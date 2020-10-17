using BookStore.Domain.Validators;

namespace BookStore.Domain.Entities
{
    public class Author : EntityBase
    {
        public string FirstName { get; }
        public string LastName { get; }

        public Author(string firstName, string lastName)
        {
            AuthorValidators.ValidAuthorName(firstName, lastName);

            FirstName = firstName;
            LastName = lastName;
        }
    }
}
