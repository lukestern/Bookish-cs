using Bookish_cs.EntityClasses;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookish_cs.Services
{
    public interface IBookService
    {
        List<BookDbModel> GetAllBooks();
        BookDbModel GetBookById(int id);
    }

    public class BookService : IBookService
    {
        private readonly BookishContext Context;
        public BookService(BookishContext context)
        {
            Context = context;
        }

        public List<BookDbModel> GetAllBooks()
        {
            return Context.Books.ToList();
        }

        public BookDbModel GetBookById(int id)
        {
            return Context.Books
                .Include(book => book.Authors)
                .Include(book => book.Bookings)
                .Single(book => book.Id == id);
        }
    }
}
