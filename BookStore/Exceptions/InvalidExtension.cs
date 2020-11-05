namespace BookStore.Common.Exceptions
{
    public class InvalidExtension : BookStoreException
    {
        private const string message =
            "Extension is invalid!";

        public InvalidExtension() : base(message)
        { }
    }
}
