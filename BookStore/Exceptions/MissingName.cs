namespace BookStore.Common.Exceptions
{
    public class MissingName : BookStoreException
    {
        private const string message =
            "Name must be set!";

        public MissingName() : base(message)
        { }
    }
}
