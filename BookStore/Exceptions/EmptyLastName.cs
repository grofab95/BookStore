namespace BookStore.Exceptions
{
    public class EmptyLastName : BookStoreException
    {
        private const string message =
            "Last name cannot be empty!";

        public EmptyLastName() : base(message)
        { }
    }
}
