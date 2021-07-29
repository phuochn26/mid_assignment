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
        public IActionResult Create(BookDTO book)
        {
            if (_bookService.CreateBook(book))
            {
                return Ok();
            }
            return BadRequest();
        }
        [HttpPut("{id}")]
        public IActionResult Update(BookDTO book, int id)
        {

            if (_bookService.UpdateBook(book, id))
            {
                return Ok();
            }
            return BadRequest();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (_bookService.DeleteBook(id))
            {
                return Ok();
            }
            return BadRequest();
        }
    }
}