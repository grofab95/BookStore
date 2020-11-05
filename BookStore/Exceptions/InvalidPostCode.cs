namespace BookStore.Common.Exceptions
{
    public class InvalidPostcode : BookStoreException
    {
        private const string message =
            "Postcode is invalid!";

        public InvalidPostcode() : base(message)
        { }
    }
}
