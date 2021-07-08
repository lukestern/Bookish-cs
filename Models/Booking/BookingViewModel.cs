using Bookish_cs.EntityClasses;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bookish_cs.Models
{
    public class BookingViewModel
    {
        public int Id { get; set; }
        public BookViewModel Book { get; set; }
        public PersonViewModel Person { get; set; }
        public DateTime Checkout { get; set; }
        public DateTime Due { get; set; }
        public DateTime? Returned { get; set; }
        public double OverdueDays { get; set; }

        public BookingViewModel(BookingDbModel booking)
        {
            Id = booking.Id;
            Book = new BookViewModel(booking.Book);
            Person = new PersonViewModel(booking.Person);
            Checkout = booking.Checkout;
            Due = booking.Due;
            Returned = booking.Returned;
            OverdueDays = (DateTime.Today - Due).TotalDays;
        }
    }
}