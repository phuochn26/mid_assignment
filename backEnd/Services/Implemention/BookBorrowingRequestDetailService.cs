using System;
using System.Collections.Generic;
using System.Linq;
using backEnd.Models;
using backEnd.Models.DTO;
using backEnd.Services;

namespace backEnd.Services.Implemention
{
    public class BookBorrowingRequestDetailService : IBookBorrowingRequestDetailService
    {
        private DataContext _dataContext;
        public BookBorrowingRequestDetailService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<BookBorrowingRequestDetail> GetDetails()
        {
            return _dataContext.BookBorrowingRequestDetails.ToList();
        }
        public BookBorrowingRequestDetail GetDetailById(int id)
        {
            return _dataContext.BookBorrowingRequestDetails.Where(s => s.DetailId == id).FirstOrDefault();
        }
        public void CreateDetail(BookBorrowingRequestDetailDTO detail)
        {
            using var transation = _dataContext.Database.BeginTransaction();
            try
            {
                var newDetail = new BookBorrowingRequestDetail()
                {
                    Books = detail.Books,
                };
                _dataContext.BookBorrowingRequestDetails.Add(newDetail);
                _dataContext.SaveChanges();
                transation.Commit();
            }
            catch(Exception)
            {
                return;
            }
        }

        public void UpdateDetail(BookBorrowingRequestDetailDTO detail, int id)
        {
            using var transation = _dataContext.Database.BeginTransaction();
            try
            {
                var updateDetail = _dataContext.BookBorrowingRequestDetails.Where(u => u.DetailId == id).FirstOrDefault();
                updateDetail.Books = updateDetail.Books;

                _dataContext.SaveChanges();
                transation.Commit();
            }
            catch(Exception)
            {
                return;
            }
        }

        public void DeleteDetail(int id)
        {
            
            using var transation = _dataContext.Database.BeginTransaction();
            try
            {
                var detail = _dataContext.BookBorrowingRequestDetails.Where(u => u.DetailId == id).FirstOrDefault();
                _dataContext.BookBorrowingRequestDetails.Remove(detail);
                _dataContext.SaveChanges();
                transation.Commit();
            }
            catch(Exception)
            {
                return;
            }
        }
    }
}