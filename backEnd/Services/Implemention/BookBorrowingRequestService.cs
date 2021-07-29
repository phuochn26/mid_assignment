using System;
using System.Collections.Generic;
using System.Linq;
using backEnd.Models;
using backEnd.Models.DTO;
using backEnd.Services;

namespace backEnd.Services.Implemention
{
    public class BookBorrowingRequestService : IBookBorrowingRequestService
    {
        private DataContext _dataContext;
        public BookBorrowingRequestService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<BookBorrowingRequest> GetRequests()
        {
            return _dataContext.BookBorrowingRequests.ToList();
        }
        public BookBorrowingRequest GetRequestById(int id)
        {
            return _dataContext.BookBorrowingRequests.Where(s => s.RequestId == id).FirstOrDefault();
        }
        public void CreateRequest(BookBorrowingRequestDTO request)
        {
            using var transation = _dataContext.Database.BeginTransaction();
            try
            {
                var newRequest = new BookBorrowingRequest()
                {
                    RequestedDate = request.RequestedDate,
                    BorrowerId = request.BorrowerId,
                    status = request.status,
                    DetailId = request.DetailId
                };
                _dataContext.BookBorrowingRequests.Add(newRequest);
                _dataContext.SaveChanges();
                transation.Commit();
            }
            catch(Exception)
            {
                return;
            }
        }

        public void UpdateRequest(BookBorrowingRequestDTO request, int id)
        {
            using var transation = _dataContext.Database.BeginTransaction();
            try
            {
                var updateRequest = _dataContext.BookBorrowingRequests.Where(u => u.RequestId == id).FirstOrDefault();
                updateRequest.RepondentId = request.RepondentId;
                updateRequest.RepondentName = request.RepondentName;
                updateRequest.status = request.status;

                _dataContext.SaveChanges();
                transation.Commit();
            }
            catch(Exception)
            {
                return;
            }
        }

        public void DeleteRequest(int id)
        {
            
            using var transation = _dataContext.Database.BeginTransaction();
            try
            {
                var request = _dataContext.BookBorrowingRequests.Where(u => u.RequestId == id).FirstOrDefault();
                _dataContext.BookBorrowingRequests.Remove(request);
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