namespace BookStore.Common.Exceptions
{
    public class InvalidVat : BookStoreException
    {
        private const string message =
            "Vat is not valid!";

        public InvalidVat() : base(message)
        { }
    }
}
