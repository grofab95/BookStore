namespace BookStore.Common.Exceptions
{
    public class MissingStreet : BookStoreException
    {
        private const string message =
            "Street must be set!";

        public MissingStreet() : base(message)
        { }
    }
}
