using System.Collections.Generic;
using backEnd.Models;
using backEnd.Models.DTO;

namespace backEnd.Services{
    public interface IBookService{
        List<Book> GetBooks();
        Book GetBookById(int id);
        void CreateBook(BookDTO books);
        void UpdateBook(BookDTO books, int id);
        void DeleteBook(int id);
    }
}