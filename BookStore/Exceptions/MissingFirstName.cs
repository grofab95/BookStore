namespace BookStore.Common.Exceptions
{
    public class MissingFirstName : BookStoreException
    {
        private const string message =
            "First name must be set!";

        public MissingFirstName() : base(message)
        { }
    }
}
