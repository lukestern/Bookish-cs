using Bookish_cs.EntityClasses;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bookish_cs.Models
{
    public class BookManagementViewModel
    {
        public List<BookViewModel> Books { get; set; }

        public BookManagementViewModel(List<BookDbModel> books)
        {
            Books = books.Select(book => new BookViewModel(book)).ToList();
        }
    }
}