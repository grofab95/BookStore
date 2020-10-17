namespace BookStore.Common.Exceptions
{
    public class NotPositiveHomeNumber : BookStoreException
    {
        private const string message =
            "Home number must be positive!";

        public NotPositiveHomeNumber() : base(message)
        { }
    }
}
