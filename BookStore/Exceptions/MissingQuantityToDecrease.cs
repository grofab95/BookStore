namespace BookStore.Common.Exceptions
{
    public class MissingQuantityToDecrease : BookStoreException
    {
        private const string message =
            "Not enough quantity to decrease!";

        public MissingQuantityToDecrease() : base(message)
        { }
    }
}
