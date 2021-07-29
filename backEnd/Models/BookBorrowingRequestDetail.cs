using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backEnd.Models
{
    [Table("BookBorrowingRequestDetails")]
    public class BookBorrowingRequestDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DetailId { get; set; }
        public int BookId { get; set; }
        public List<Book> Books { get; set; }
        public BookBorrowingRequest Request { get; set; }
    }
}