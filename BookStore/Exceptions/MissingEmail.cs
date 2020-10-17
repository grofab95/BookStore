namespace BookStore.Common.Exceptions
{
    public class MissingEmail : BookStoreException
    {
        private const string message =
            "E-mail must be set!";

        public MissingEmail() : base(message)
        { }
    }
}
