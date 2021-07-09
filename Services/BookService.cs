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
        void UpdateBook(UpdateBookViewModel updateBook, int id);
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
            var allAuthors = GetAuthorFromString(newBook.AuthorNames);

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
        public void UpdateBook(UpdateBookViewModel updateBook, int id)
        {
            var book = GetBookById(id);
            book.Title = updateBook.Title;
            book.ISBN = updateBook.ISBN;
            book.Quantity = updateBook.Quantity;
            var allAuthors = GetAuthorFromString(updateBook.AuthorNames);
            book.Authors = allAuthors;
      
            _context.SaveChanges();
        }

        public List<AuthorDbModel> GetAuthorFromString(string authorNames)
        {
            var names = new List<string>(
                authorNames.Split(",").Select(name => name.Trim())
            );

            var existingAuthors = _context.Authors
                .Where(author => names
                    .Contains(author.Name))
                .ToList();
            var newAuthors = names
                .Where(name => !existingAuthors
                    .Any(n => n.Name == name))
                .Select(name => new AuthorDbModel() { Name = name })
                .ToList();
            return existingAuthors.Concat(newAuthors).ToList();
        }
    }
}
