using Bookish_cs.EntityClasses;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Bookish_cs.Services
{
    public interface IBookService
    {
        List<BookDbModel> GetAllBooks();
        BookDbModel GetBookById(int id);
    }

    public class BookService : IBookService
    {
        private readonly BookishContext _context;
        public BookService(BookishContext context)
        {
            _context = context;
        }

        public List<BookDbModel> GetAllBooks() => _context.Books.ToList();

        public BookDbModel GetBookById(int id)
        {
            return _context.Books
                .Include(book => book.Authors)
                .Include(book => book.Bookings)
                .ThenInclude(booking => booking.Person)
                .Single(book => book.Id == id);
        }
    }
}
