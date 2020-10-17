using BookStore.Domain.Validators;

namespace BookStore.Domain.Entities
{
    public class User : EntityBase
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string Email { get; }
        public Address Addresss { get; }

        public User(string firstName, string lastName, string email, Address addresss)
        {
            UserValidators.ValidFirstName(firstName);
            UserValidators.ValidLastName(lastName);
            UserValidators.ValidEmail(email);

            FirstName = firstName;
            LastName = lastName;
            LastName = lastName;
            Email = email;
            Addresss = addresss;
        }

        public string Name => $"{FirstName} {LastName}";
    }
}
