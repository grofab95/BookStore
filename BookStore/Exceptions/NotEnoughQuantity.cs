namespace BookStore.Common.Exceptions
{
    public class NotEnoughQuantity : BookStoreException
    {
        private const string message =
            "Not enough quantity!";

        public NotEnoughQuantity() : base(message)
        { }
    }
}
