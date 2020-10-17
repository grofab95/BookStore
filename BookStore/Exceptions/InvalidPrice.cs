namespace BookStore.Common.Exceptions
{
    public class InvalidPrice : BookStoreException
    {
        private const string message =
            "Price must be positive!";

        public InvalidPrice() : base(message)
        { }
    }
}
