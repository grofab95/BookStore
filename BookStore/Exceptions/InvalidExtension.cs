namespace BookStore.Exceptions
{
    public class InvalidExtension : BookStoreException
    {
        private const string message =
            "Extension is not valid!";

        public InvalidExtension() : base(message)
        { }
    }
}
