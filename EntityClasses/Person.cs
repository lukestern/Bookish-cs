using System.Collections.Generic;

namespace Bookish_cs.EntityClasses
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        
        public List<Booking> Bookings { get; set; }
}
}