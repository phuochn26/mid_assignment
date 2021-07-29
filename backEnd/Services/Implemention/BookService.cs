using System;
using System.Collections.Generic;
using System.Linq;
using backEnd.Models;
using backEnd.Models.DTO;
using backEnd.Services;

namespace backEnd.Services.Implemention
{
    public class BookService : IBookService
    {
        private DataContext _dataContext;
        public BookService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<Book> GetBooks()
        {
            return _dataContext.Books.ToList();
        }
        public Book GetBookById(int id)
        {
            return _dataContext.Books.Where(s => s.BookId == id).FirstOrDefault();
        }
        public bool CreateBook(BookDTO book)
        {
            using var transation = _dataContext.Database.BeginTransaction();
            try
            {
                var newBook = new Book()
                {
                    BookName = book.BookName,
                    PublicDay = book.PublicDay,
                    CategoryId = book.CategoryId
                };
                _dataContext.Books.Add(newBook);
                _dataContext.SaveChanges();
                transation.Commit();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public bool UpdateBook(BookDTO book, int id)
        {
            using var transation = _dataContext.Database.BeginTransaction();
            try
            {
                var updateBook = _dataContext.Books.Where(u => u.BookId == id).FirstOrDefault();
                updateBook.BookName = book.BookName;
                updateBook.PublicDay = book.PublicDay; 
                updateBook.CategoryId = book.CategoryId;

                _dataContext.SaveChanges();
                transation.Commit();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public bool DeleteBook(int id)
        {
            
            using var transation = _dataContext.Database.BeginTransaction();
            try
            {
                var book = _dataContext.Books.Where(u => u.BookId == id).FirstOrDefault();
                _dataContext.Books.Remove(book);
                _dataContext.SaveChanges();
                transation.Commit();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
    }
}