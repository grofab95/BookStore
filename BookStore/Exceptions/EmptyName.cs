namespace BookStore.Exceptions
{
    public class EmptyName : BookStoreException
    {
        private const string message =
            "Name cannot be empty!";

        public EmptyName() : base(message)
        { }
    }
}
