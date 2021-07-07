using Bookish_cs.EntityClasses;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookish_cs.EntityClasses
{

    public class BookishContext : DbContext
    {
        public BookishContext(DbContextOptions<BookishContext> options)
        : base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Person> People{ get; set; }

        
    }

}
