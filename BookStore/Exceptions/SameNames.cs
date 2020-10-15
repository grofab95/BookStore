namespace BookStore.Common.Exceptions
{
    public class SameNames : BookStoreException
    {
        private const string message =
            "First name and last name cannot be the same!";

        public SameNames() : base(message)
        { }
    }
}
