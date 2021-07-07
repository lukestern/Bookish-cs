using System;

namespace Bookish_cs.EntityClasses
{
    public class Booking
    {
        public int Id { get; set; }
        public Book Book { get; set; }
        public Person Person { get; set; }
        public DateTime Checkout { get; set; }
        public DateTime Due { get; set; }
        public DateTime? Returned { get; set; }
    }
}