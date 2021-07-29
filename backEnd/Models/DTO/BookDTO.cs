using System;

namespace backEnd.Models.DTO
{
    public class BookDTO
    {
        public string BookName { get; set; }
        public DateTime PublicDay { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public BookBorrowingRequestDetail Detail { get; set; }
    }
}