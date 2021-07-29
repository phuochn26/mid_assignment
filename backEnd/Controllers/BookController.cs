using System.Collections.Generic;
using backEnd.Models;
using backEnd.Models.DTO;
using backEnd.Services;
using Microsoft.AspNetCore.Mvc;

namespace backEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }
        [HttpGet]
        public List<Book> List()
        {
            return _bookService.GetBooks();
        }
        [HttpGet("{id}")]
        public Book GetById(int id)
        {
            return _bookService.GetBookById(id);
        }
        [HttpPost]
        public List<Book> Create(BookDTO book)
        {
            _bookService.CreateBook(book);
            return _bookService.GetBooks();
        }
        [HttpPut("{id}")]
        public List<Book> Update(BookDTO book, int id)
        {
            _bookService.UpdateBook(book, id);
            return _bookService.GetBooks();
        }
        [HttpDelete("{id}")]
        public List<Book> Delete(int id)
        {
            _bookService.DeleteBook(id);
            return _bookService.GetBooks();
        }
    }
}