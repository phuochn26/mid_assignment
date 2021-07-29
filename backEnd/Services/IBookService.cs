using System.Collections.Generic;
using backEnd.Models;
using backEnd.Models.DTO;

namespace backEnd.Services{
    public interface IBookService{
        List<Book> GetBooks();
        Book GetBookById(int id);
        bool CreateBook(BookDTO books);
        bool UpdateBook(BookDTO books, int id);
        bool DeleteBook(int id);
    }
}