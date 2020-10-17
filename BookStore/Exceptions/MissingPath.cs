namespace BookStore.Common.Exceptions
{
    public class MissingPath : BookStoreException
    {
        private const string message =
            "Path value must be set!";

        public MissingPath() : base(message)
        { }
    }
}
