namespace BookStore.Common.Exceptions
{
    public class MissingTitle : BookStoreException
    {
        private const string message =
            "Title must be set!";

        public MissingTitle() : base(message)
        { }
    }
}
