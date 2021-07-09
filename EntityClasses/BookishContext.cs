using Microsoft.EntityFrameworkCore;

namespace Bookish_cs.EntityClasses
{

    public class BookishContext : DbContext
    {
        public BookishContext(DbContextOptions<BookishContext> options)
        : base(options)
        {

        }
        public DbSet<BookDbModel> Books { get; set; }
        public DbSet<AuthorDbModel> Authors { get; set; }
        public DbSet<BookingDbModel> Bookings { get; set; }
        public DbSet<PersonDbModel> People { get; set; }

    }
}
