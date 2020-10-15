using System;

namespace BookStore.Exceptions
{
    public class BookStoreException : Exception
    {
        public BookStoreException(string message) : base(message)
        {  }
    }
}
