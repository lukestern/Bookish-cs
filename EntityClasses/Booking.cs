using System;

public class Booking
{
    public int Id { get; set; }
    public int BookId { get; set; }
    public int PersonId { get; set; }
    public DateTime Checkout { get; set; }
    public DateTime Due { get; set; }
    public DateTime Returned { get; set; }
}