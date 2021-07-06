using System;

namespace Bookish_cs.Models
{
    public class MemberManagementViewModel
    {
        public string Name { get; set; }
        public string Role { get; set; }

        public MemberManagementViewModel()
        {
            Name = "Awesome";
            Role = "Librarian";
        }
    }
}