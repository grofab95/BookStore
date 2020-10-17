namespace BookStore.Domain.Entities
{
    public class Customer : User
    {
        public Customer(string firstName, string lastName, string email, Address addresss) 
            : base(firstName, lastName, email, addresss)
        {

        }
    }
}
