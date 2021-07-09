using Bookish_cs.EntityClasses;
using System;

namespace Bookish_cs.Models
{
    public class BookingData
    {
        public string PersonName { get; set; }
        public DateTime Checkout { get; set; }
        public DateTime Due { get; set; }
        public double OverdueDays { get; set; }

        public BookingData(BookingDbModel booking)
        {
            PersonName = booking.Person.Name;
            Checkout = booking.Checkout;
            Due = booking.Due;
            OverdueDays = (DateTime.Today - Due).TotalDays;
        }
    }
}