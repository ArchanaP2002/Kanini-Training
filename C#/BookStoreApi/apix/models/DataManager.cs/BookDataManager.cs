using BookStoreApi.models;
using Microsoft.EntityFrameworkCore;

namespace BookStoreApi.Models.DataManager
{
    public class BookDataManager
    {
        private readonly BookStoreContext _bookStoreContext;

        public BookDataManager(BookStoreContext bookStoreContext)
        {
            _bookStoreContext = bookStoreContext;
        }

        public Book Get(long id)
        {
            _bookStoreContext.ChangeTracker.LazyLoadingEnabled = false;

            var book = _bookStoreContext.Books
                .Include(b => b.BookAuthors)
                .ThenInclude(ba => ba.Author)
                .Include(b => b.Publisher)
                .SingleOrDefault(b => b.Id == id);

            return book;
        }
    }
}
