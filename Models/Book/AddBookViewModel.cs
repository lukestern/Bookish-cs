using Bookish_cs.EntityClasses;
using System.Collections.Generic;
using System.Linq;

namespace Bookish_cs.Models
{
    public class AddBookViewModel
    {
        public string Title { get; set; }
        public int ISBN { get; set; }
        public int Quantity { get; set; }
        public string AuthorNames { get; set; }

        public AddBookViewModel()
        {
        }
    }
}