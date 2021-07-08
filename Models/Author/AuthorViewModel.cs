using Bookish_cs.EntityClasses;
using System.Collections.Generic;
using System.Linq;

namespace Bookish_cs.Models
{
    public class AuthorViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<BookViewModel> Books { get; set; }

        public AuthorViewModel(AuthorDbModel author)
        {
            Id = author.Id;
            Name = author.Name;
            Books = author.Books.Select(book => new BookViewModel(book)).ToList();
        }
    }
}