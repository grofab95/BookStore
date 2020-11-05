namespace BookStore.Common.Exceptions
{
    public class InvalidEmail : BookStoreException
    {
        private const string message =
            "E-mail is invalid!";

        public InvalidEmail() : base(message)
        { }
    }
}
