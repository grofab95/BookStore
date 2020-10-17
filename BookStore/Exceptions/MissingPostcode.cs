namespace BookStore.Common.Exceptions
{
    public class MissingPostcode : BookStoreException
    {
        private const string message =
            "Postcode must be set!";

        public MissingPostcode() : base(message)
        { }
    }
}
