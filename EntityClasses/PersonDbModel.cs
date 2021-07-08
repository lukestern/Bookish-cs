using System.Collections.Generic;

namespace Bookish_cs.EntityClasses
{
    public class PersonDbModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public List<BookingDbModel> Bookings { get; set; }
}
}