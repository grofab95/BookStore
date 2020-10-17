namespace BookStore.Common.Exceptions
{
    public class NegativeQuantity : BookStoreException
    {
        private const string message =
            "Quantity must be positive!";

        public NegativeQuantity() : base(message)
        { }
    }
}
