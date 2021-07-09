using Bookish_cs.EntityClasses;
using System.Collections.Generic;
using System.Linq;

namespace Bookish_cs.Models
{
    public class PersonViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public List<BookingData> Bookings { get; set; }

        public PersonViewModel(PersonDbModel person)
        {
            Id = person.Id;
            Name = person.Name;
            Role = person.Role;
            Bookings = person.Bookings.Select(booking => new BookingData(booking)).ToList();
        }
    }

}