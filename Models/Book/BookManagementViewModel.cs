using Bookish_cs.EntityClasses;
using System;
using System.Collections.Generic;

namespace Bookish_cs.Models
{
    public class BookManagementViewModel
    {
        public List<Book> Books { get; set; }

        public BookManagementViewModel(List<Book> books)
        {
            Books = books;
        }
    }
}