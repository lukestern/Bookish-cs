using System;

namespace Bookish_cs.Models
{
    public class BookManagementViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}