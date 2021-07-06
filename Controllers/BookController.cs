using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Bookish_cs.Models;

namespace Bookish_cs.Controllers
{
    [Route("/[controller]/{action=Booklist}")]
    public class BookController : Controller
    {
        private readonly ILogger<BookController> _logger;

        public BookController(ILogger<BookController> logger)
        {
            _logger = logger;
        }

        public IActionResult Booklist()
        {
            return View(new BookManagementViewModel());
        }

    }
}
