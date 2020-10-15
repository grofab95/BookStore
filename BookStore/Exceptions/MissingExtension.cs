namespace BookStore.Exceptions
{
    public class MissingExtension : BookStoreException
    {
        private const string message =
            "Path must contains extension!";

        public MissingExtension() : base(message)
        { }
    }
}
