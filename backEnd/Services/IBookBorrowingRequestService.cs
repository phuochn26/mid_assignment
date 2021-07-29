using System.Collections.Generic;
using backEnd.Models;
using backEnd.Models.DTO;

namespace backEnd.Services{
    public interface IBookBorrowingRequestService{
        List<BookBorrowingRequest> GetRequests();
        BookBorrowingRequest GetRequestById(int id);
        void CreateRequest(BookBorrowingRequestDTO bookBorrowingRequest);
        void UpdateRequest(BookBorrowingRequestDTO bookBorrowingRequest, int id);
        void DeleteRequest(int id);
    }
}