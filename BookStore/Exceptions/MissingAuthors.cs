namespace BookStore.Common.Exceptions
{
    public class MissingAuthors : BookStoreException
    {
        private const string message =
            "Authors must be definied!";

        public MissingAuthors() : base(message)
        { }
    }
}
