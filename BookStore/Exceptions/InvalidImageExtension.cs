namespace BookStore.Common.Exceptions
{
    public class InvalidImageExtension : BookStoreException
    {
        private const string message =
            "Image extension is not valid!";

        public InvalidImageExtension() : base(message)
        { }
    }
}
