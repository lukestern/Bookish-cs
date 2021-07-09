using Bookish_cs.EntityClasses;
using System.Collections.Generic;
using System.Linq;

namespace Bookish_cs.Models
{
    public class BookManagementViewModel
    {
        public List<BookPageViewModel> Books { get; set; }

        public BookManagementViewModel(List<BookDbModel> books)
        {
            Books = books.Select(book => new BookPageViewModel(book)).ToList();
        }
    }
}