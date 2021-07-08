using System.Collections.Generic;

namespace Bookish_cs.EntityClasses
{
    public class AuthorDbModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<BookDbModel> Books { get; set; }
    }
}