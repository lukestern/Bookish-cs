using System;

namespace Bookish_cs.EntityClasses
{
    public class BookingDbModel
    {
        public int Id { get; set; }
        public BookDbModel Book { get; set; }
        public PersonDbModel Person { get; set; }
        public DateTime Checkout { get; set; }
        public DateTime Due { get; set; }
        public DateTime? Returned { get; set; }
    }
}