using System.Collections.Generic;
using backEnd.Models;
using backEnd.Models.DTO;

namespace backEnd.Services{
    public interface IBookBorrowingRequestDetailService{
        List<BookBorrowingRequestDetail> GetDetails();
        BookBorrowingRequestDetail GetDetailById(int id);
        void CreateDetail(BookBorrowingRequestDetailDTO bookBorrowingRequestDetail);
        void UpdateDetail(BookBorrowingRequestDetailDTO bookBorrowingRequestDetail, int id);
        void DeleteDetail(int id);
    }
}