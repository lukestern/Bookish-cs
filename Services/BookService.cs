using Bookish_cs.EntityClasses;
using Bookish_cs.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Bookish_cs.Services
{
    public interface IBookService
    {
        List<BookDbModel> GetAllBooks();
        BookDbModel GetBookById(int id);
        void AddBook(AddBookViewModel addBook);
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

        public void AddBook(AddBookViewModel newBook)
        {
            var authorNames = new List<string>(
                newBook.AuthorNames.Split(",").Select(name => name.Trim())
            );

            var existingAuthors = _context.Authors
                .Where(author => authorNames
                    .Contains(author.Name))
                .ToList();
            var newAuthors = authorNames
                .Where(name => !existingAuthors
                    .Any(n => n.Name == name))
                .Select(name => new AuthorDbModel() { Name = name })
                .ToList();
            var allAuthors = existingAuthors.Concat(newAuthors).ToList();

            var book = new BookDbModel()
            {
                Title = newBook.Title,
                ISBN = newBook.ISBN,
                Quantity = newBook.Quantity,
                Authors = allAuthors
            };
            _context.Books.Add(book);
            _context.SaveChanges();
        }
    }
}
