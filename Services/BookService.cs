using Bookish_cs.EntityClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookish_cs.Services
{
    public interface IBookService
    {
        List<Book> GetAllBooks();
    }
    public class BookService : IBookService
    {
        private readonly BookishContext Context;
        public BookService(BookishContext context)
        {
            Context = context;
        }

        public List<Book> GetAllBooks()
        {

            var result = Context.Books.ToList();
            return result;
        }
    }
}
