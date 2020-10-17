namespace BookStore.Common.Exceptions
{
    public class NotPositiveFlatNumber : BookStoreException
    {
        private const string message =
            "Flat number must be positive!";

        public NotPositiveFlatNumber() : base(message)
        { }
    }
}
