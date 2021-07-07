using System.Collections.Generic;

namespace Bookish_cs.EntityClasses
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ISBN { get; set; }
        public int Quantity { get; set; }
        public List<Author> Authors { get; set; }
        public List<Booking> Bookings { get; set; }
    }
}