namespace BookStore.Common.Exceptions
{
    public class InvalidPostcode : BookStoreException
    {
        private const string message =
            "Postcode is not valid!";

        public InvalidPostcode() : base(message)
        { }
    }
}
