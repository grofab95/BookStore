namespace BookStore.Common.Exceptions
{
    public class MissingLastName : BookStoreException
    {
        private const string message =
            "Last name must be set!";

        public MissingLastName() : base(message)
        { }
    }
}
