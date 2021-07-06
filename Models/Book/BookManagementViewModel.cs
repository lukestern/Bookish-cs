using System;

namespace Bookish_cs.Models
{
    public class BookManagementViewModel
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public BookManagementViewModel()
        {
            Title = "The Lord of the Rings";
            Author = "J.R.R Tolkien";
        }
    }
}