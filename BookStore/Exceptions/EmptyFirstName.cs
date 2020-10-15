namespace BookStore.Exceptions
{
    public class EmptyFirstName : BookStoreException
    {
        private const string message =
            "First name cannot be empty!";

        public EmptyFirstName() : base(message)
        { }
    }
}
