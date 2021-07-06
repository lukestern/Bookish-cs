using System;

namespace Bookish_cs.Models
{
    public class BookViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}