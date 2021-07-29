using System;

namespace backEnd.Models.DTO
{
    public class BookBorrowingRequestDTO
    {
        public DateTime RequestedDate { get; set; }
        public int BorrowerId { get; set; }
        public User User { get; set; }
        public int RepondentId { get; set; }
        public string RepondentName { get; set; }
        public string status { get; set; }
        public int DetailId { get; set; }
        public BookBorrowingRequestDetail Detail { get; set; }
    }
}