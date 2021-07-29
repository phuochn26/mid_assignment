using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backEnd.Models.DTO
{
    public class BookBorrowingRequestDetailDTO
    {
        public int BookId { get; set; }
        public List<Book> Books { get; set; }
        public BookBorrowingRequest Request { get; set; }
    }
}