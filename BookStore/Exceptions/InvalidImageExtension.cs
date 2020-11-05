namespace BookStore.Common.Exceptions
{
    public class InvalidImageExtension : BookStoreException
    {
        private const string message =
            "Image extension is invalid!";

        public InvalidImageExtension() : base(message)
        { }
    }
}
