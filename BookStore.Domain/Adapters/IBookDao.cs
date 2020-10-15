using BookStore.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookStore.Domain.Adapters
{
    public interface IBookDao
    {
        Task<int> AddBookAsync(Book book);
        Task<Book> GetBookById(int bookId);
        Task<List<Book>> GetBooksAsync(int offset, int limit);
        Task<Book> UpdateBookAsync(Book book);
        Task RemoveBookAsync(Book book);
    }
}
