using Bookish_cs.EntityClasses;
using System.Collections.Generic;
using System.Linq;

namespace Bookish_cs.Models
{
    public class BookViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ISBN { get; set; }
        public int Quantity { get; set; }
        public List<AuthorViewModel> Authors { get; set; }
        public List<BookingViewModel> Bookings { get; set; }

        public BookViewModel(BookDbModel book)
        {
            Id = book.Id;
            Title = book.Title;
            ISBN = book.ISBN;
            Quantity = book.Quantity;
            Authors = book.Authors?.Select(author => new AuthorViewModel(author)).ToList() ?? new List<AuthorViewModel>();
            Bookings = book.Bookings?.Select(booking => new BookingViewModel(booking)).ToList() ?? new List<BookingViewModel>();
        }
    }
}