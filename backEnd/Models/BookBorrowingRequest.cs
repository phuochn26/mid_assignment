using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backEnd.Models
{
    [Table("BookBorrowingRequests")]
    public class BookBorrowingRequest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RequestId { get; set; }
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