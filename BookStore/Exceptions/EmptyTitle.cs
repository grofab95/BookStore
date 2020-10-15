namespace BookStore.Exceptions
{
    public class EmptyTitle : BookStoreException
    {
        private const string message =
            "Title cannot be empty!";

        public EmptyTitle() : base(message)
        { }
    }
}
