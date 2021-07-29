using System.Collections.Generic;
using backEnd.Models;
using backEnd.Models.DTO;

namespace backEnd.Services{
    public interface IBookBorrowingRequestService{
        List<BookBorrowingRequest> GetRequests();
        BookBorrowingRequest GetRequestById(int id);
        bool CreateRequest(BookBorrowingRequestDTO bookBorrowingRequest);
        bool UpdateRequest(BookBorrowingRequestDTO bookBorrowingRequest, int id);
        bool DeleteRequest(int id);
    }
}