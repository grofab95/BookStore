namespace BookStore.Common.Exceptions
{
    public class InvalidEmail : BookStoreException
    {
        private const string message =
            "E-mail is not valid!";

        public InvalidEmail() : base(message)
        { }
    }
}
