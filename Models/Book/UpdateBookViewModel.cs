using Bookish_cs.EntityClasses;
using System.Collections.Generic;
using System.Linq;

namespace Bookish_cs.Models
{
    public class UpdateBookViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ISBN { get; set; }
        public int Quantity { get; set; }
        public string AuthorNames { get; set; }

        public UpdateBookViewModel()
        {
                
        }

        public UpdateBookViewModel(BookDbModel book)
        {
            Id = book.Id;
            Title = book.Title;
            ISBN = book.ISBN;
            Quantity = book.Quantity;
            AuthorNames = string.Join(", ", book.Authors?.Select(author => author.Name).ToList());
        }
    }
}