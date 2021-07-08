using System.Collections.Generic;

namespace Bookish_cs.EntityClasses
{
    public class BookDbModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ISBN { get; set; }
        public int Quantity { get; set; }
        public List<AuthorDbModel> Authors { get; set; }
        public List<BookingDbModel> Bookings { get; set; }
    }
}