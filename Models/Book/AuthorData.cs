using Bookish_cs.EntityClasses;
using System.Collections.Generic;
using System.Linq;

namespace Bookish_cs.Models
{
    public class AuthorData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Books { get; set; }

        public AuthorData(AuthorDbModel author)
        {
            Id = author.Id;
            Name = author.Name;
            Books = author.Books.Select(book => book.Title).ToList();
        }
    }
}