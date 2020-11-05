namespace BookStore.Common.Exceptions
{
    public class InvalidVat : BookStoreException
    {
        private const string message =
            "Vat is invalid!";

        public InvalidVat() : base(message)
        { }
    }
}
