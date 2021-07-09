using Bookish_cs.Models;
using Bookish_cs.Services;
using Microsoft.AspNetCore.Mvc;

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
            return View(new BookPageViewModel(book));
        }

        [HttpGet("Create")]
        public IActionResult AddBook()
        {
            return View(new AddBookViewModel());
        }

        [HttpPost("Create")]
        public IActionResult AddBook(AddBookViewModel addBookViewModel)
        {
            _bookService.AddBook(addBookViewModel);
            return RedirectToAction(nameof(BookList));
        }
    }
}
