using Bookish_cs.EntityClasses;
using System.Collections.Generic;
using System.Linq;

namespace Bookish_cs.Models
{
    public class BookPageViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ISBN { get; set; }
        public int Quantity { get; set; }
        public List<string> AuthorNames { get; set; }
        public List<BookingData> Bookings { get; set; }
        public int AvailbleCopies { get; set; }

        public BookPageViewModel(BookDbModel book)
        {
            Id = book.Id;
            Title = book.Title;
            ISBN = book.ISBN;
            Quantity = book.Quantity;
            AuthorNames = book.Authors?.Select(author => author.Name).ToList() ?? new List<string>();
            Bookings = book.Bookings
                ?.Where(booking => booking.Returned is null)
                .Select(booking => new BookingData(booking))
                .ToList()
                ?? new List<BookingData>();
            AvailbleCopies = Quantity - Bookings.Count;
        }
    }
}