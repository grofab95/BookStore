using BookStore.Domain.Adapters;
using BookStore.Domain.Entities;
using FakeItEasy;
using Xunit;

namespace BookStore.Domain.Tests.Adapters
{
    public class BookDaoTests
    {
        [Fact]
        public void GetBookByIdAsync_Expect_ReturnBookById()
        {
            var book = A.Dummy<Book>();
            book.Id = 2;
            var bookDao = A.Fake<IBookDao>();

            A.CallTo(() => bookDao.GetBookById(1)).Returns(book);
        }
    }
}
