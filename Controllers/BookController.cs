using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Bookish_cs.Models;
using Bookish_cs.Services;

namespace Bookish_cs.Controllers
{
    [Route("/[controller]")]
    public class BookController : Controller
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public IActionResult BookList()
        {
            var books = _bookService.GetAllBooks();
            return View(new BookManagementViewModel(books));
        }

        [HttpGet("{id}")]
        public IActionResult BookPage(int id)
        {
            var book = _bookService.GetBookById(id);
            return View(new BookViewModel(book));
        }
    }
}
