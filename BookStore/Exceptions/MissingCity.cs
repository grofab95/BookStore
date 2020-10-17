namespace BookStore.Common.Exceptions
{
    public class MissingCity : BookStoreException
    {
        private const string message =
            "City must be set!";

        public MissingCity() : base(message)
        { }
    }
}
